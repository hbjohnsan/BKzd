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
    public partial class IOUFrm : DockContent
    {
        private MainFrm mf;

        public IOUFrm()
        {
            InitializeComponent();
        }
        public IOUFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }
        private void IOUFrm_Load(object sender, EventArgs e)
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

            loadPrintText();
        }

        private void LoadUnit()
        {
            var q = from p in mf.DS.Unit.AsEnumerable()
                    where p.IsPay == "是"
                    select p;
            foreach (var i in q)
            {
                Unit u = new Unit();
                u.UnitID = i.UnitID;
                u.ShortName = i.ShortName;
                combJKDW.Items.Add(u);
            }
            combJKDW.DisplayMember = "ShortName";
        }

        #region 欠条
        private void loadPrintText()
        {
            rtbDoc.Clear();
            Unit u = combJKDW.SelectedItem as Unit;
            string year = toolStripComboBox1.SelectedItem.ToString();
            rtbDoc.Font = new Font("仿宋", 16, FontStyle.Regular);

            rtbDoc.Text = "                         欠   条" + "\n";
            rtbDoc.Text += "\n";
            rtbDoc.Text += "    今欠宣传部" + toolStripComboBox1.Text + "年度，党报党刊款（小写）：￥" + txtTruePrice.Text + "元。\n" + "大写人民币：" + RMBCapitalization.RMBAmount(double.Parse(txtTruePrice.Text)) + "。";
            rtbDoc.Text += "\n\n";
            rtbDoc.Text += "\n                         欠款单位：" + u.AllName;
            rtbDoc.Text += "\n                         打欠条人：" + "               ";
            rtbDoc.Text += "\n                         电    话：" + txtTel.Text;
            rtbDoc.Text += "\n                         日    期：" + System.DateTime.Now.ToString("yyyy年MM月dd日");
            rtbDoc.Text += "\n\n\n";
            rtbDoc.Text += "---------------------------------------------------------\n";
            rtbDoc.Text += "人民日报:" + mf.DS.PaperTask.Select("UnitID='" + u.UnitID + "'and Year='" + year + "'")[0]["P101"].ToString() + "份；";
            rtbDoc.Text += "每份单价：" + mf.DS.Paper.Select("PaperID='101' and Year='" + year + "'")[0]["Price"].ToString() + "元，";
            rtbDoc.Text +="财政补贴："+mf.DS.Paper.Select("PaperID='101' and Year='"+year+"'")[0]["SubSidy"].ToString().ToString()+"元。\n";
            rtbDoc.Text += "求是:" + mf.DS.PaperTask.Select("UnitID='" + u.UnitID + "'and Year='" + year + "'")[0]["P102"].ToString() + "份；";
            rtbDoc.Text += "每份单价：" + mf.DS.Paper.Select("PaperID='102' and Year='" + year + "'")[0]["Price"].ToString() + "元，";
            rtbDoc.Text += "财政补贴：" + mf.DS.Paper.Select("PaperID='102' and Year='" + year + "'")[0]["SubSidy"].ToString().ToString() + "元。\n";
            rtbDoc.Text += "光明日报:" + mf.DS.PaperTask.Select("UnitID='" + u.UnitID + "'and Year='" + year + "'")[0]["P103"].ToString() + "份；";
            rtbDoc.Text += "每份单价：" + mf.DS.Paper.Select("PaperID='103' and Year='" + year + "'")[0]["Price"].ToString() + "元，";
            rtbDoc.Text += "财政补贴：" + mf.DS.Paper.Select("PaperID='103' and Year='" + year + "'")[0]["SubSidy"].ToString().ToString() + "元。\n";
            rtbDoc.Text += "经济日报:" + mf.DS.PaperTask.Select("UnitID='" + u.UnitID + "'and Year='" + year + "'")[0]["P104"].ToString() + "份；";
            rtbDoc.Text += "每份单价：" + mf.DS.Paper.Select("PaperID='104' and Year='" + year + "'")[0]["Price"].ToString() + "元，";
            rtbDoc.Text += "财政补贴：" + mf.DS.Paper.Select("PaperID='104' and Year='" + year + "'")[0]["SubSidy"].ToString().ToString() + "元。\n";
            rtbDoc.Text += "新华每日电讯:" + mf.DS.PaperTask.Select("UnitID='" + u.UnitID + "'and Year='" + year + "'")[0]["P105"].ToString() + "份；";
            rtbDoc.Text += "每份单价：" + mf.DS.Paper.Select("PaperID='105' and Year='" + year + "'")[0]["Price"].ToString() + "元，";
            rtbDoc.Text += "财政补贴：" + mf.DS.Paper.Select("PaperID='105' and Year='" + year + "'")[0]["SubSidy"].ToString().ToString() + "元。\n";
            rtbDoc.Text += "河北日报:" + mf.DS.PaperTask.Select("UnitID='" + u.UnitID + "'and Year='" + year + "'")[0]["P201"].ToString() + "份；";
            rtbDoc.Text += "每份单价：" + mf.DS.Paper.Select("PaperID='201' and Year='" + year + "'")[0]["Price"].ToString() + "元，";
            rtbDoc.Text += "财政补贴：" + mf.DS.Paper.Select("PaperID='201' and Year='" + year + "'")[0]["SubSidy"].ToString().ToString() + "元。\n";
            rtbDoc.Text += "河北经济日报:" + mf.DS.PaperTask.Select("UnitID='" + u.UnitID + "'and Year='" + year + "'")[0]["P202"].ToString() + "份；";
            rtbDoc.Text += "每份单价：" + mf.DS.Paper.Select("PaperID='202' and Year='" + year + "'")[0]["Price"].ToString() + "元，";
            rtbDoc.Text += "财政补贴：" + mf.DS.Paper.Select("PaperID='202' and Year='" + year + "'")[0]["SubSidy"].ToString().ToString() + "元。\n";
            rtbDoc.Text += "燕赵都市报:" + mf.DS.PaperTask.Select("UnitID='" + u.UnitID + "'and Year='" + year + "'")[0]["P203"].ToString() + "份；";
            rtbDoc.Text += "每份单价：" + mf.DS.Paper.Select("PaperID='203' and Year='" + year + "'")[0]["Price"].ToString() + "元，";
            rtbDoc.Text += "财政补贴：" + mf.DS.Paper.Select("PaperID='203' and Year='" + year + "'")[0]["SubSidy"].ToString().ToString() + "元。\n";
            rtbDoc.Text += "唐山劳动日报:" + mf.DS.PaperTask.Select("UnitID='" + u.UnitID + "'and Year='" + year + "'")[0]["P301"].ToString() + "份；";
            rtbDoc.Text += "每份单价：" + mf.DS.Paper.Select("PaperID='301' and Year='" + year + "'")[0]["Price"].ToString() + "元，";
            rtbDoc.Text += "财政补贴：" + mf.DS.Paper.Select("PaperID='301' and Year='" + year + "'")[0]["SubSidy"].ToString().ToString() + "元。\n";
            rtbDoc.Text += "唐山晚报:" + mf.DS.PaperTask.Select("UnitID='" + u.UnitID + "'and Year='" + year + "'")[0]["P302"].ToString() + "份；";
            rtbDoc.Text += "每份单价：" + mf.DS.Paper.Select("PaperID='302' and Year='" + year + "'")[0]["Price"].ToString() + "元，";
            rtbDoc.Text += "财政补贴：" + mf.DS.Paper.Select("PaperID='302' and Year='" + year + "'")[0]["SubSidy"].ToString().ToString() + "元。\n";
        
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    double result;
        //    if (IsNumberic(txtTruePrice.Text.Trim(), out result))
        //    {
        //        loadPrintText();
        //    }


        //}
        //private bool IsNumberic(string txt, out double result)
        //{
        //    result = -1;
        //    try
        //    {
        //        result = double.Parse(txt);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;

        //    }
        //}

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
            if (this.printDialog2.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        #endregion

        private void combJKDW_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPrintText();
        }

        private void txtTruePrice_TextChanged(object sender, EventArgs e)
        {
            loadPrintText();
        }

        private void combJKDW_SelectedValueChanged(object sender, EventArgs e)
        {
            //选择单位后，显示任务金额。采用Table.select方法
            txtTruePrice.Text = mf.DS.PaperTask.Select("UnitID='" + (combJKDW.SelectedItem as Unit).UnitID + "'and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'")[0]["TotalMoney"].ToString();

        }


    }
}
