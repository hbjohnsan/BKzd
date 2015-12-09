using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DBzd
{
    public partial class ToolsPaperNum : DockContent
    {
        private MainFrm mf;
        public ToolsPaperNum()
        {
            InitializeComponent();
        }
        public ToolsPaperNum(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void ToolsPaperNum_Load(object sender, EventArgs e)
        {
            LoadYear();
        }

        private void LoadYear()
        {
            combYear.Items.Clear();
            var q = from p in mf.DS.PaperTask
                    orderby p.Year descending
                    group p by p.Year into g
                    select new
                    {
                        year = g.Key,
                        g
                    };

            foreach (var it in q)
            {
                combYear.Items.Add(it.year);
            }
            combYear.SelectedIndex = 0;
        }
        //数量变化时
        private void nUD_ValueChanged(object sender, EventArgs e)
        {
            CalTotal();
        }

        //计算金额
        private void CalTotal()
        {
            var q = from p in mf.DS.Paper.AsEnumerable()
                    where p.Year == combYear.SelectedItem.ToString()
                    select p;


            double tol = 0;

            #region 循环

            foreach (var f in q)
            {
                switch (f.PaperID)
                {
                    case "101":
                        if (nUD101.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD101.Value);

                        }
                        break;
                    case "102":
                        if (nUD102.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD102.Value);

                        }
                        break;
                    case "103":
                        if (nUD103.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD103.Value);

                        }
                        break;
                    case "104":
                        if (nUD104.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD104.Value);

                        }
                        break;
                    case "105":
                        if (nUD105.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD105.Value);

                        }
                        break;

                    case "201":
                        if (nUD201.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD201.Value);

                        }
                        break;
                    case "202":
                        if (nUD202.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD202.Value);

                        }
                        break;
                    case "203":
                        if (nUD203.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD203.Value);

                        }
                        break;
                    case "301":
                        if (nUD301.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD301.Value);

                        }
                        break;
                    case "302":
                        if (nUD302.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD302.Value);

                        }
                        break;

                }
            }
            #endregion

            labTotal.Text = tol.ToString();

        }
        //自动计算最恰当的报刊分类。
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nUD101.Value = nUD102.Value = nUD103.Value = nUD104.Value = nUD105.Value = nUD201.Value = nUD202.Value = nUD203.Value = nUD301.Value = nUD302.Value = 0;
            //手动输入时要决断为数字
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtMoney.Text, @"^([0-9]*)\.?[0-9]*$"))
            {
                MessageBox.Show("请输入正确的金额！");
                return;
            }
            //得到金额
            double TotalMoney = Convert.ToDouble(txtMoney.Text);
            //要先重点分配报刊任务数量多的。 唐山、河北、人民
            //第1步，得到每份报刊的真实价格。
            //第2步，先判断钱是否大于，最小的报刊价。然后先重点分3个党刊任务，一依次各类报刊价格，再把数量增加一。
            double M101 = 0, M102 = 0, M103 = 0, M104 = 0, M105 = 0, M201 = 0, M202 = 0, M203 = 0, M301 = 0, M302 = 0;


            var q = from p in mf.DS.Paper.AsEnumerable()
                    where p.Year == combYear.Text
                    select p;
            foreach (var i in q)
            {
                switch (i.PaperID)
                {
                    case "101":
                        M101 = i.Price - i.SubSidy;
                        break;
                    case "102":
                        M102 = i.Price - i.SubSidy;
                        break;
                    case "103":
                        M103 = i.Price - i.SubSidy;
                        break;
                    case "104":
                        M104 = i.Price - i.SubSidy;
                        break;
                    case "105":
                        M105 = i.Price - i.SubSidy;
                        break;
                    case "201":
                        M201 = i.Price - i.SubSidy;
                        break;
                    case "202":
                        M202 = i.Price - i.SubSidy;
                        break;
                    case "203":
                        M203 = i.Price - i.SubSidy;
                        break;
                    case "301":
                        M301 = i.Price - i.SubSidy;
                        break;
                    case "302":
                        M302 = i.Price - i.SubSidy;
                        break;

                }

            }
            //最得小单价的报纸
            double[] ary = new double[10] { M101, M102, M103, M104, M105, M201, M202, M203, M301, M302 };

            while (TotalMoney > ary.Min())
            {
                if (TotalMoney > M301)
                {
                    nUD301.Value++;
                    TotalMoney -= M301;
                }
                if (TotalMoney > M201)
                {
                    nUD201.Value++;
                    TotalMoney -= M201;
                }
                if (TotalMoney > M101)
                {
                    nUD101.Value++;
                    TotalMoney -= M101;
                }
                if (TotalMoney > M102)
                {
                    nUD102.Value++;
                    TotalMoney -= M102;
                }
                if (TotalMoney > M103)
                {
                    nUD103.Value++;
                    TotalMoney -= M103;
                }
                if (TotalMoney > M104)
                {
                    nUD104.Value++;
                    TotalMoney -= M104;
                }
                if (TotalMoney > M105)
                {
                    nUD105.Value++;
                    TotalMoney -= M105;
                }
                if (TotalMoney > M202)
                {
                    nUD202.Value++;
                    TotalMoney -= M202;
                }
                if (TotalMoney > M203)
                {
                    nUD203.Value++;
                    TotalMoney -= M203;
                }
                if (TotalMoney > M302)
                {
                    nUD302.Value++;
                    TotalMoney -= M302;
                }
            }



        }

        




    }
}
