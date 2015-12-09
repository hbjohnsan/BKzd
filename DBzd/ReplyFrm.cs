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
    public partial class ReplyFrm : DockContent
    {
        private MainFrm mf;
        public ReplyFrm()
        {
            InitializeComponent();
        }

        public ReplyFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        #region 批复
        private void getPiFu()
        {
            rtbDoc.Clear();
            Unit u = combJKDW.SelectedItem as Unit;
            rtbDoc.Font = new Font("仿宋", 16, FontStyle.Regular);
            //todo:编号设置
            rtbDoc.Font = new Font("仿宋", 16, FontStyle.Regular);
            rtbDoc.Text = "第   号" + "\n";
            rtbDoc.Text += "\n";
            rtbDoc.Text += "          关于提取" + toolStripComboBox1.Text.Trim() + "年度重点党报党刊征订奖金的批复";
            rtbDoc.Text += "\n";
            rtbDoc.Text += "\n";
            rtbDoc.Text += u.AllName + ":";
            rtbDoc.Text += "\n";
            rtbDoc.Text += "\n";
            rtbDoc.Text += "    经研究同意，对按时完成" + toolStripComboBox1.Text.Trim() + "年度重点党报党刊征订任务的单位给予奖励，奖金为报款总额的10%，资金自筹。\n";
            rtbDoc.Text += "    你单位按要求完成了任务，报款总额为：￥" + txtTotalMoney.Text + "元，大写：" + RMBCapitalization.RMBAmount(double.Parse(txtTotalMoney.Text)) + ",奖金为" + double.Parse(txtTotalMoney.Text) * .1 + "人民币(大写)：" + RMBCapitalization.RMBAmount(double.Parse(txtTotalMoney.Text) * .1) + "。\n";
            rtbDoc.Text += "\n";
            rtbDoc.Text += "\n                              中共滦县县委宣传部";
            rtbDoc.Text += "\n";
            rtbDoc.Text += "\n";
            rtbDoc.Text += "                                 " + System.DateTime.Now.ToString("yyyy年MM月dd日");
            rtbDoc.Text += "\n";
            rtbDoc.Text += "…………………………………………………………………………";
            rtbDoc.AppendText("\n");
            rtbDoc.AppendText("第   号" + "\n");
            rtbDoc.AppendText("\n");
            rtbDoc.AppendText("          关于提取" + toolStripComboBox1.Text.Trim() + "年度重点党报党刊征订奖金的批复");
            rtbDoc.AppendText("\n");
            rtbDoc.AppendText("\n");
            rtbDoc.AppendText(u.AllName + ":");
            rtbDoc.AppendText("\n");
            rtbDoc.AppendText("\n");
            rtbDoc.AppendText("    经研究同意，对按时完成" + toolStripComboBox1.Text.Trim() + "年度重点党报党刊征订任务的单位给予奖励，奖金为报款总额的10%，资金自筹。\n");
            rtbDoc.AppendText("    你单位按要求完成了任务，报款总额为：￥" + txtTotalMoney.Text + "元，大写：" + RMBCapitalization.RMBAmount(double.Parse(txtTotalMoney.Text)) + ",奖金为" + double.Parse(txtTotalMoney.Text) * .1 + "人民币(大写)：" + RMBCapitalization.RMBAmount(double.Parse(txtTotalMoney.Text) * .1) + "。\n");
            rtbDoc.AppendText("\n");
            rtbDoc.AppendText("\n                              中共滦县县委宣传部");
            rtbDoc.AppendText("\n");
            rtbDoc.AppendText("\n");
            rtbDoc.AppendText("                                 " + System.DateTime.Now.ToString("yyyy年MM月dd日"));
            rtbDoc.AppendText("\n");

        }
        #endregion

        #region Printing
        private int checkPrint;

        private void PrintDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            checkPrint = 0;

        }


        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
                checkPrint = rtbDoc.Print(checkPrint, rtbDoc.TextLength, e);

                if (checkPrint < rtbDoc.TextLength)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }
            
        }


        private void tsbtnPrintSetup_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
        }

        private void tsbtnPrintView_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void tsbtnPrint_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        #endregion

        #region 工具栏命令


        //设置字体
        private void tsbtnFont_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    fontDialog1.Font = rtbDoc.SelectionFont;
                }
                else
                {
                    fontDialog1.Font = null;
                }
                fontDialog1.ShowApply = true;
                if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    rtbDoc.SelectionFont = fontDialog1.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        //字体加粗
        private void tsbtnBold_Click(object sender, EventArgs e)
        {

            Font oldFont = this.rtbDoc.SelectionFont;
            Font newFont;
            if (oldFont.Bold)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            this.rtbDoc.SelectionFont = newFont;
            this.rtbDoc.Focus();
        }
        //字体下划线
        private void tsbtnUnderline_Click(object sender, EventArgs e)
        {
            Font oldFont = this.rtbDoc.SelectionFont;
            Font newFont;
            if (oldFont.Underline)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            this.rtbDoc.SelectionFont = newFont;
            this.rtbDoc.Focus();
        }
        //左对齐
        private void tsbtnLeft_Click(object sender, EventArgs e)
        {
            if (this.rtbDoc.SelectionAlignment == HorizontalAlignment.Left)
                this.rtbDoc.SelectionAlignment = HorizontalAlignment.Center;
            else
                this.rtbDoc.SelectionAlignment = HorizontalAlignment.Left;
            this.rtbDoc.Focus();
        }
        //居中对齐
        private void tsbtnCenter_Click(object sender, EventArgs e)
        {
            if (this.rtbDoc.SelectionAlignment == HorizontalAlignment.Center)
                this.rtbDoc.SelectionAlignment = HorizontalAlignment.Left;
            else
                this.rtbDoc.SelectionAlignment = HorizontalAlignment.Center;
            this.rtbDoc.Focus();
        }
        //右对齐
        private void tsbtnRight_Click(object sender, EventArgs e)
        {
            if (this.rtbDoc.SelectionAlignment == HorizontalAlignment.Right)
                this.rtbDoc.SelectionAlignment = HorizontalAlignment.Left;
            else
                this.rtbDoc.SelectionAlignment = HorizontalAlignment.Right;
            this.rtbDoc.Focus();
        }
        //搜索单位
        private void tsTxtSearch_TextChanged(object sender, EventArgs e)
        {

            combJKDW.Items.Clear();
            string upper = tsTxtSearch.Text.ToUpper();
            var q5 = from p in mf.DS.Unit.AsEnumerable()
                     where p.Istake == "是"
                     select p;
            foreach (var i in q5)
            {

                string namecode = PinYin.GetCodstring(i.ShortName);
                if (namecode.StartsWith(upper))
                {
                    Unit un = new Unit();
                    un.UnitID = i.UnitID;
                    un.ShortName = i.ShortName;
                    un.AllName = i.AllName;
                    un.Tel = i.Tel;
                    combJKDW.Items.Add(un);

                }

            }
            combJKDW.DisplayMember = "shortname";
            if (combJKDW.Items.Count > 0)
            {
                combJKDW.SelectedIndex = 0;
            }
        }

        #endregion

        private void ReplyFrm_Load(object sender, EventArgs e)
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

            #region 加载单位类别
            toolStripComboBox3.Items.Clear();
            var q1 = from k in mf.DS.Unit
                     //  orderby k.kind descending
                     group k by k.Kind into g
                     select new
                     {
                         kind = g.Key,
                         g
                     };
            foreach (var i in q1)
            {
                toolStripComboBox3.Items.Add(i.kind);

            }
            toolStripComboBox3.SelectedIndex = 0;
            #endregion

            LoadUnit();

            getPiFu();
        }

        private void LoadUnit()
        {
            var q = from p in mf.DS.Unit.AsEnumerable()
                    where p.IsPay == "是"
                    select p;
            foreach (var i in q)
            {
                Unit un = new Unit();
                un.UnitID = i.UnitID;
                un.ShortName = i.ShortName;
                un.Tel = i.Tel;
                un.AllName = i.AllName;
                combJKDW.Items.Add(un);
            }
            combJKDW.DisplayMember = "ShortName";
            if (combJKDW.Items.Count > 0)
            {
                combJKDW.SelectedIndex = 0;
            }
        }

        //单位类别
        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            combJKDW.Items.Clear();
            var q5 = from p in mf.DS.Unit.AsEnumerable()
                     where p.Kind == toolStripComboBox3.SelectedItem.ToString().Trim() && p.IsPay == "是"
                     select p;
            foreach (var i in q5)
            {
                Unit un = new Unit();
                un.UnitID = i.UnitID;
                un.ShortName = i.ShortName;
                un.Tel = i.Tel;
                un.AllName = i.AllName;
                combJKDW.Items.Add(un);

            }
            combJKDW.DisplayMember = "ShortName";
            if (combJKDW.Items.Count > 0)
            {
                combJKDW.SelectedIndex = 0;
            }
        }

        private void combJKDW_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPiFu();
        }

    }
}
