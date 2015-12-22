using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Threading;

namespace DBzd
{
    public partial class ToolsPaperNum : DockContent
    {
        private MainFrm mf;
        //用于记录每份报纸的单价
        private double M101 = 0, M102 = 0, M103 = 0, M104 = 0, M105 = 0, M201 = 0, M202 = 0, M203 = 0, M301 = 0, M302 = 0;
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
            Price();
        }

       #region 第1步:得到每份报刊的真实价格。把这个放在窗体加载时，只运行一次就OK了。        
        private void Price()
        { 
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
        }
        #endregion
      
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
        private void fenpei()
        {
            //得到要分配的金额
            double TotalMoney = Convert.ToDouble(txtMoney.Text);          
           
            /* 第2步
             * 交款单位一般都想少交 ，收款单位一般都想多收。为了公平，在输入一个金额后，我们按这个金额的上下100浮动，
             * 并给出5个方交款提供用户选择。
             * 分析：
             * 1、勾选的单位得1或0份。
             * 2、从勾选的项中，逐一加份数，看是否最接近该值。在正付100元内记录该值用于下一步比较。
             * 3、得以一个数组，并按由小到大的差值排列
             * 4、显示相关数量。
             * 5、用户点某个方案，数量显示某个对应的数值。
             * 做法：
             * 1、找到有多少种报纸，对应单价是多少。建立数组
             * 2、m10*x+m102*y=totalmoney
             * 
             */
            //最得小单价的报纸
            //double[] ary = new double[10] { M101, M102, M103, M104, M105, M201, M202, M203, M301, M302 };

            //while (TotalMoney > ary.Min())
            //{                                           
            //    if (TotalMoney > M301 && chb301.Checked == true)
            //    {
            //        nUD301.Value++;}
           
        }

        private void butFenPei_Click(object sender, EventArgs e)
        {
            this.Invoke(new ThreadStart(delegate
               {
                   fenpei();

               }));

        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            nUD101.Value = nUD102.Value = nUD103.Value = nUD104.Value = nUD105.Value = nUD201.Value = nUD202.Value = nUD203.Value = nUD301.Value = nUD302.Value = 0;
            //手动输入时要决断为数字
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtMoney.Text, @"^([0-9]*)\.?[0-9]*$"))
            {
                MessageBox.Show("请输入正确的金额！");
                return;
            }
        }






    }
}
