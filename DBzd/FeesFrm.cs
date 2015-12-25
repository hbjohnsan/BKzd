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
using Interop.Excel;

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
            int xh = 1;
            foreach (var i in q5)
            {

                string namecode = PinYin.GetCodstring(i.shortname);
                if (namecode.StartsWith(upper))
                {
                    ListViewItem lv = new ListViewItem(new string[] {(xh++).ToString(),i.shortname, i.paykind, i.money.ToString(), i.over, i.year, i.bz });
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
            int xh = 1;
            foreach (var i in q)
            {


                ListViewItem lv = new ListViewItem(new string[] {(xh++).ToString(), i.shortname, i.paykind, i.money.ToString(), i.over, i.year, i.bz });
                listView1.Items.Add(lv); ;

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
            int xh = 1;
            foreach (var i in q)
            {


                ListViewItem lv = new ListViewItem(new string[] {(xh++).ToString(), i.shortname, i.paykind, i.money.ToString(), i.over, i.year, i.bz });
                listView1.Items.Add(lv); ;

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

        private void 导出ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExecl();
        }

        private void ExportToExecl()
        {

            System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 文件(*.xls)|*.xls";
            sfd.DefaultExt = "xls";
            //sfd.FileName = "未交款单位";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TurnToExcel(listView1, sfd.FileName);
            }
        }

        //具体输出Excel2003文件
        public void TurnToExcel(ListView listView, string strFileName)
        {
            int rowNum = listView.Items.Count;
            int columnNum = listView.Items[0].SubItems.Count;
            int rowIndex = 1;
            int columnIndex = 0;
            if (rowNum == 0 || string.IsNullOrEmpty(strFileName))
            {
                return;
            }
           
            if (rowNum > 0)
            {
                Interop.Excel.Application xlApp = new Interop.Excel.Application();
                
                if (xlApp == null)
                {
                    MessageBox.Show("无法创建excel对象，可能您的系统没有安装excel");
                    return;
                }
                xlApp.DefaultFilePath = "";
                xlApp.DisplayAlerts = true;
                xlApp.SheetsInNewWorkbook = 1;
                Interop.Excel.Workbook xlBook = xlApp.Workbooks.Add(true);
                //将ListView的列名导入Excel表第一行
                foreach (ColumnHeader dc in listView.Columns)
                {
                    columnIndex++;
                    xlApp.Cells[rowIndex, columnIndex] = dc.Text;
                }
                //将ListView中的数据导入Excel中
                for (int i = 0; i < rowNum; i++)
                {
                    rowIndex++;
                    columnIndex = 0;
                    for (int j = 0; j < columnNum; j++)
                    {
                        columnIndex++;
                        //注意这个在导出的时候加了“\t” 的目的就是避免导出的数据显示为科学计数法。可以放在每行的首尾。
                        xlApp.Cells[rowIndex, columnIndex] = Convert.ToString(listView.Items[i].SubItems[j].Text);//+ "\t";
                    }
                }
                //例外需要说明的是用strFileName,Excel.XlFileFormat.xlExcel9795保存方式时 当你的Excel版本不是95、97 而是2003、2007 时导出的时候会报一个错误：异常来自 HRESULT:0x800A03EC。 解决办法就是换成strFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal。
                xlBook.SaveAs(strFileName, Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                //xlApp = null;
                //xlBook = null;

                xlBook.Close(true, Type.Missing, Type.Missing);
                xlBook = null;
                xlApp.Quit();
                xlApp = null;
                MessageBox.Show("OK");
            }
            
        }

    }
}
