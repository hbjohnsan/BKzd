using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Drawing.Printing;
using System.IO;

namespace DBzd
{
    public partial class FeesFrm : DockContent
    {
        private MainFrm mf;
        //交款方式

        public FeesFrm()
        {
            InitializeComponent();
        }
        public FeesFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;

        }

        private void FeesFrm_Load(object sender, EventArgs e)
        {
            #region 年度列表
            
            toolStripComboBox1.Items.Clear();
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
                toolStripComboBox1.Items.Add(it.year);
            }
            toolStripComboBox1.SelectedIndex = 0;
            #endregion

            

            LoadListviews();
            CalcHasPayUnit();
        }

        #region 工具栏 搜索

        private void tsTxtSearch_TextChanged(object sender, EventArgs e)
        {
            string year = toolStripComboBox1.SelectedItem.ToString().Trim();

            listView1.Items.Clear();
            string upper = tsTxtSearch.Text.ToUpper();
            var q5 = from p in mf.DS.Unit.AsEnumerable()
                     from r in mf.DS.Receivables.AsEnumerable()
                     where p.UnitID == r.UnitID && r.Year == year
                     select new
                     {
                         shortname = p.ShortName,
                         paykind = r.PayKind,
                         money = r.TrueMoney,
                         over = r.IsOver,
                         year = r.Year,
                         bz = r.BZ

                     };
            foreach (var i in q5)
            {

                string namecode = PinYin.GetCodstring(i.shortname);
                if (namecode.StartsWith(upper))
                {
                    ListViewItem lv = new ListViewItem(new string[] { i.shortname, i.paykind, i.money.ToString(), i.over, i.year, i.bz });
                    listView1.Items.Add(lv); ;

                }

            }


        }

        #endregion

        private void LoadListviews()
        {
            listView1.Items.Clear();
             string year = toolStripComboBox1.SelectedItem.ToString().Trim();
            var q = from p in mf.DS.Unit.AsEnumerable()
                    from r in mf.DS.Receivables.AsEnumerable()
                    where p.UnitID == r.UnitID &&  r.Year==year
                    select new
                    {
                        shortname = p.ShortName,
                        paykind = r.PayKind,
                        money = r.TrueMoney,
                        over = r.IsOver,
                        year = r.Year,
                        bz = r.BZ

                    };
            foreach (var i in q)
            {


                ListViewItem lv = new ListViewItem(new string[] {"", i.shortname, i.paykind, i.money.ToString(), i.over, i.year, i.bz });
                listView1.Items.Add(lv); ;

            }
            //显示序号
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }
        //现金
        private void ToolStripClick(object sender, EventArgs e)
        {
            string year = toolStripComboBox1.SelectedItem.ToString().Trim();
            ToolStripButton tsb = sender as ToolStripButton;

            listView1.Items.Clear();
            var q = from p in mf.DS.Unit.AsEnumerable()
                    from r in mf.DS.Receivables.AsEnumerable()
                    where p.UnitID == r.UnitID && r.PayKind == tsb.Text && r.Year==year
                    select new
                    {
                        shortname = p.ShortName,
                        paykind = r.PayKind,
                        money = r.TrueMoney,
                        over = r.IsOver,
                        year = r.Year,
                        bz = r.BZ
                    };
            foreach (var i in q)
            {


                ListViewItem lv = new ListViewItem(new string[] {"", i.shortname, i.paykind, i.money.ToString(), i.over, i.year, i.bz });
                listView1.Items.Add(lv); ;

            }
            //显示序号
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        //计算已交款单位。
        private void CalcHasPayUnit()
        {
            mf.toolStripStatusLabel1.Text = "";
            mf.toolStripStatusLabel2.Text = "";
            //总单位数：

            mf.toolStripStatusLabel1.Text += "现金总额：" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "PayKind='现金' and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";

            mf.toolStripStatusLabel1.Text += "    汇卡总额：" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "PayKind='汇卡' and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";

            mf.toolStripStatusLabel1.Text += "    汇邮局账户：" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "PayKind='转账' and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";

            mf.toolStripStatusLabel1.Text += "    欠条：" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "PayKind='欠条' and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";

            //mf.toolStripStatusLabel1.Text += "    未交：" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "PayKind='未交' and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";

            mf.toolStripStatusLabel2.Text += "合计各类总额:" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].BackColor = Color.Red;
        }



    }
}
