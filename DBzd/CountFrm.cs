using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Interop.Excel;
using System.Threading;


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

           

            TotalMoney();


            //加载未交款单位列表
            LoadListViewNoMoney();

          LoadListView();

        }
        //加载未交款单位列表       
        private void LoadListViewNoMoney()
        {
            //加载单位基本信息
            string year = toolStripComboBox1.SelectedItem.ToString();


            //未交款单位。用lambda实现方法如下：

            //var notIn =mf.DS.Unit.Where(a => !((mf.DS.Receivables.Select(b => b.UnitID)).Contains(a.UnitID)));
            //用Linq实现
            var notIn = from a in mf.DS.Unit
                        where !((from b in mf.DS.Receivables where b.Year == year select b.UnitID).Contains(a.UnitID)) && a.IsPay == "是"
                        select a;

            foreach (var i in notIn)
            {
                ListViewItem lv = new ListViewItem(new string[] { "", i.ShortName, i.Tel, "", "未交款" });
                lv.Tag = i.UnitID;
                listViewNoMoney.Items.Add(lv);

            }
            //显示序号
            for (int i = 0; i < listViewNoMoney.Items.Count; i++)
            {
                listViewNoMoney.Items[i].SubItems[0].Text = (i + 1).ToString();
                //加载金额
                string unitid = listViewNoMoney.Items[i].Tag.ToString();
                //先从计划表中找金额，涉及到的子单位，如果分配到任务数，从实际任务表中找。都没有则为0
                int hasTask = mf.DS.PaperTask.Select("Year='" + year + "' and UnitId='" + unitid + "'").Count();
                if (hasTask > 0)
                {
                    listViewNoMoney.Items[i].SubItems[3].Text = mf.DS.PaperTask.Select("Year='" + year + "' and UnitId='" + unitid + "'")[0]["TotalMoney"].ToString();
                    continue;
                }
                int HasTruePaper = mf.DS.TruePaper.Select("Year='" + year + "' and UnitID='" + unitid + "'").Count();
                if (HasTruePaper > 0)
                {
                    listViewNoMoney.Items[i].SubItems[3].Text = mf.DS.TruePaper.Select("Year='" + year + "' and UnitID='" + unitid + "'")[0]["TrueMoney"].ToString();
                }
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

            labPlantMoney.Text = mf.DS.PaperTask.Compute("Sum(TotalMoney)", "Year='" + year + "'").ToString();
            labHasMoneyBFB.Text = string.Format("{0:0.00%}", (double.Parse(labTrueMoney.Text) / double.Parse(labPlantMoney.Text))); ;
        }
        //实现查找谁多少了，少交了。
        private void LoadListView()
        {
            listView1.Items.Clear();
            string year = toolStripComboBox1.SelectedItem.ToString().Trim();
            //第一步，加裁任务单位总额，
            var q = from u in mf.DS.Unit.AsEnumerable()
                    from p in mf.DS.PaperTask.AsEnumerable()
                    where p.Year == year && u.UnitID == p.UnitId
                    select new
                    {
                        UnitID = u.UnitID,
                        Name = u.ShortName,
                        PlantMoney = p.TotalMoney
                    } into ss
                    from t in mf.DS.TruePaper.AsEnumerable()
                    where t.UnitID == ss.UnitID && t.Year == year
                    select new
                    {
                        unitID = ss.UnitID,
                        name = ss.Name,
                        plantMoney = ss.PlantMoney,
                        trueMoney = t.TrueMoney
                    };

            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { "", i.name, i.plantMoney.ToString(), i.trueMoney.ToString(), (i.plantMoney - i.trueMoney).ToString() }, "");
                lv.Tag = i.unitID;
                listView1.Items.Add(lv);

            }

            //第二步，加载交款总额。第三步比较


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
            //  double tol = 0.0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (Convert.ToDouble(listView1.Items[i].SubItems[3].Text) < Convert.ToDouble(toolStripTextBox1.Text))
                {
                    listView1.Items[i].Remove();
                    //  tol += Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                }
            }
            // mf.toolStripStatusLabel1.Text = "全计少交总额：" + tol.ToString();
        }
        //多交单位
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mf.toolStripStatusLabel1.Text = "";
            double tol = 0.0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (Convert.ToDouble(listView1.Items[i].SubItems[4].Text) > Convert.ToDouble(toolStripTextBox1.Text))
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
            ExportToExecl();
        }

        private void ExportToExecl()
        {

            System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 文件(*.xls)|*.xls";
            sfd.DefaultExt = "xls";
            sfd.FileName = "未交款单位";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TurnToExcel(listViewNoMoney, sfd.FileName);
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
                        xlApp.Cells[rowIndex, columnIndex] = Convert.ToString(listView.Items[i].SubItems[j].Text) + "\t";
                    }
                }
                //例外需要说明的是用strFileName,Excel.XlFileFormat.xlExcel9795保存方式时 当你的Excel版本不是95、97 而是2003、2007 时导出的时候会报一个错误：异常来自 HRESULT:0x800A03EC。 解决办法就是换成strFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal。
                xlBook.SaveAs(strFileName, Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                xlApp = null;
                xlBook = null;
                MessageBox.Show("OK");
            }
        }



        private void listViewNoMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNoMoney.SelectedItems.Count > 0)
            {
                listViewNoMoney.SelectedItems[0].BackColor = Color.Red;
            }
        }
        //统计少交单位的金额
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}