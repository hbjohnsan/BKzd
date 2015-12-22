using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Office.Interop.Excel;


namespace DBzd
{
    public partial class CountFrm : DockContent
    {
        private MainFrm mf;
        public CountFrm()
        {
            InitializeComponent();
        }
        public CountFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void CountFrm_Load(object sender, EventArgs e)
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

            LoadListView();

            TotalMoney();

            //加载未交款单位列表
            LoadListViewNoMoney();
        }
        //加载未交款单位列表
        /*
         * 1
         *
         */
        private void LoadListViewNoMoney()
        {
            //加载单位基本信息
            string year = toolStripComboBox1.SelectedItem.ToString();
            var q = from p in mf.DS.Unit.AsEnumerable()
                    where p.IsPay == "是" && p.Year == year
                    select p;
            foreach (var i in q)
            {
                int haspay = mf.DS.TruePaper.Select("Year='" + year + "' and UnitID='" + i.UnitID + "'").Count();
                if (haspay == 0)
                {
                    //从PaperTask表中找出计划金额
                    string money = (from p in mf.DS.PaperTask.AsEnumerable() where p.Year == year && p.UnitId == i.UnitID select p).SingleOrDefault().TotalMoney.ToString();

                    ListViewItem lv = new ListViewItem(new string[] { "", i.ShortName, i.Tel, money, "否" });
                    listViewNoMoney.Items.Add(lv);
                }
            }

            //显示序号
            for (int i = 0; i < listViewNoMoney.Items.Count; i++)
            {
                listViewNoMoney.Items[i].SubItems[0].Text = (i + 1).ToString();
            }

        }
        //显示综合统计
        private void TotalMoney()
        {
            string year = toolStripComboBox1.SelectedItem.ToString().Trim();
            labTopGitMoney.Text = mf.DS.Paper.Compute("Sum(TotalPrice)", "Year='" + year + "'").ToString();
            labCaiZPT.Text = mf.DS.Paper.Compute("Sum(TotalSubSidy)", "Year='" + year + "'").ToString();
            labMustMoney.Text = (double.Parse(labTopGitMoney.Text) - double.Parse(labCaiZPT.Text)).ToString();

            //包含欠条也算完成
            labTrueMoney.Text = mf.DS.Receivables.Compute("Sum(TrueMoney)", "Year='" + year + "'").ToString();
            //未完成任务金额
            labNoGieMoney.Text = (double.Parse(labMustMoney.Text) - double.Parse(labTrueMoney.Text)).ToString();
            //占比 此方法能得到你想要的小数点后位数

            labZhanBi.Text = string.Format("{0:0.00%}", (double.Parse(labTrueMoney.Text) / double.Parse(labMustMoney.Text)));//得到5.88%

           labPlantMoney.Text =mf.DS.PaperTask.Compute("Sum(TotalMoney)","Year='"+year+"'").ToString();
           labHasMoneyBFB.Text = string.Format("{0:0.00%}", (double.Parse(labTrueMoney.Text) / double.Parse(labPlantMoney.Text))); ;
        }
        //实现查找谁多少了，少交了。
        private void LoadListView()
        {
            listView1.Items.Clear();
            //第一步，加裁任务单位总额，
            var q = from p in mf.DS.PaperTask.AsEnumerable()
                    from u in mf.DS.Unit.AsEnumerable()
                    where p.Year == toolStripComboBox1.SelectedItem.ToString().Trim() && p.UnitId == u.UnitID
                    select new
                    {
                        id = p.UnitId,
                        name = u.ShortName,
                        plantMoney = p.TotalMoney
                    };
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { i.name, i.plantMoney.ToString(), "0.0", "0.0", "0.0" });
                lv.Tag = i.id;
                listView1.Items.Add(lv);
            }

            //第二步，加载交款总额。第三步比较
            string year = toolStripComboBox1.SelectedItem.ToString().Trim();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                //单独判断人社局的子局
                if (listView1.Items[i].Tag.ToString() == "130223j026")
                {
                    listView1.Items[i].SubItems[2].Text = mf.DS.Receivables.Compute("Sum(TrueMoney)", "Year='" + year + "' and UnitID like '%" + listView1.Items[i].Tag.ToString() + "%'").ToString();
                }
                else
                {
                    listView1.Items[i].SubItems[2].Text = mf.DS.Receivables.Compute("Sum(TrueMoney)", "Year='" + year + "' and UnitID= '" + listView1.Items[i].Tag.ToString() + "'").ToString();

                }
                if (listView1.Items[i].SubItems[2].Text != "")
                {
                    double PM = Convert.ToDouble(listView1.Items[i].SubItems[1].Text);
                    double TM = Convert.ToDouble(listView1.Items[i].SubItems[2].Text);
                    if (PM > TM)
                    {
                        listView1.Items[i].SubItems[3].Text = (PM - TM).ToString("0.0");

                    }
                    if (TM > PM)
                    {
                        listView1.Items[i].SubItems[4].Text = (TM - PM).ToString("0.0");
                    }
                }
            }
        }
        //全部单位
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LoadListView();
        }
        //少交单位
        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            mf.toolStripStatusLabel1.Text = "";
            double tol = 0.0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (Convert.ToDouble(listView1.Items[i].SubItems[3].Text) > 1)
                {
                    listView1.Items[i].BackColor = Color.Red;
                    tol += Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                }
            }
            mf.toolStripStatusLabel1.Text = "全计少交总额：" + tol.ToString();
        }
        //多交单位
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mf.toolStripStatusLabel1.Text = "";
            double tol = 0.0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (Convert.ToDouble(listView1.Items[i].SubItems[4].Text) > 1)
                {
                    listView1.Items[i].BackColor = Color.Green;
                    tol += Convert.ToDouble(listView1.Items[i].SubItems[4].Text);
                }
            }

            mf.toolStripStatusLabel1.Text = "全计多交总额：" + tol.ToString();
        }
        //未交款表导出Excle
        private void 导出ExcleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string saveFileName = "";
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel 文件(*.xls)|*.xls";
            saveFileDialog1.RestoreDirectory = true;
            saveFileName = saveFileDialog1.FileName;

            //saveFileDialog1.FileName = DateTime.Now.ToString("yyyy-MM-dd");

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TurnToExcel(listView1, "LOG");

            }
        }


        public void TurnToExcel(ListView listView1, string sheet1)
        {

            string Sheetname = sheet1;
            if (listView1.Items.Count == 0) return;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks workbooks = excel.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Sheets worksheets = workbook.Worksheets;
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)worksheets.get_Item(1);
            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Range range;
            excel.Cells.Select();
            excel.Cells.RowHeight = 30;
            excel.Cells.Font.Size = 10;
            excel.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            int rowPos = 2;
            range = excel.get_Range(sheet.Cells[rowPos, 1], sheet.Cells[rowPos, 1]);
            range.Select();

            for (int i = 1; i <= listView1.Columns.Count; i++)
            {
                range = excel.get_Range(sheet.Cells[rowPos, i], sheet.Cells[rowPos, i]);
                range.Borders.LineStyle = 1;
                range.Font.Name = "华文仿宋";
                range.Font.Size = 16;
                range.Font.Bold = true;
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                range.ColumnWidth = 18;
                sheet.Cells[rowPos, i] = listView1.Columns[i - 1].Text.ToString();
            }
            rowPos++;

            foreach (ListViewItem item in listView1.Items)
            {
                for (int i = 1; i <= listView1.Columns.Count; ++i)
                {
                    range = excel.get_Range(sheet.Cells[rowPos, i], sheet.Cells[rowPos, i]);
                    range.Borders.LineStyle = 1;
                    range.Font.Name = "华文仿宋";
                    range.Font.Size = 12;
                    range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[rowPos, i] = item.SubItems[i - 1].Text;
                }
                rowPos++;
            }
        }

      

        private void listViewNoMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNoMoney.SelectedItems.Count > 0)
            {
                listViewNoMoney.SelectedItems[0].BackColor = Color.Red;
            }
        }
    }
}