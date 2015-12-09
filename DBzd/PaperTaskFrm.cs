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
    public partial class PaperTaskFrm : DockContent
    {
        private MainFrm mf;
        private double Plan, Sub;

        public PaperTaskFrm()
        {
            InitializeComponent();
        }
        public PaperTaskFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void HigherTaskFrm_Load(object sender, EventArgs e)
        {

            DropDownShowYear();
        }
        //显示年度下拉列表
        private void DropDownShowYear()
        {
            #region 年度下拉列表
            toolStripComboBox1.Items.Clear();

            var q = from p in mf.DS.PaperTask.AsEnumerable()
                    orderby p.year descending
                    select p.year;
            foreach (var y in q.Distinct())
            {
                toolStripComboBox1.Items.Add(y);               
            }
            toolStripComboBox1.SelectedIndex = 0;
            #endregion
        }

        public void getPaperTaskListView()
        {
            listViewPaperTask.Items.Clear();

            var q = from p in mf.DS.PaperTask.AsEnumerable()
                    from pe in mf.DS.Paper.AsEnumerable()
                    where p.year == toolStripComboBox1.SelectedItem.ToString().Trim() && p.paperid == pe.paperid && pe.year == toolStripComboBox1.SelectedItem.ToString().Trim()
                    select new
                    {
                        id = p.id,
                        papername = pe.name,
                        num = p.number,
                        price = pe.price,
                        totalmoney = pe.price * p.number,
                        subsidy = pe.subsidy,
                        totalsubsidy = pe.subsidy * p.number
                    };

            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { i.papername, i.num.ToString(), i.price.ToString(), i.totalmoney.ToString(), i.subsidy.ToString(), i.totalsubsidy.ToString(), toolStripComboBox1.SelectedItem.ToString().Trim() });
                lv.Tag = i.id;
                listViewPaperTask.Items.Add(lv);
            }


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mf.papertaskTap.Update(mf.DS.PaperTask);
        }
        //年度选择更新
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPaperTaskListView();
            CalMoney();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewPaperTask.SelectedItems.Count > 0)
            {
                int id = Int32.Parse(listViewPaperTask.SelectedItems[0].Tag.ToString());
                string year = toolStripComboBox1.SelectedItem.ToString().Trim();
                PaperTaskEdit pte = new PaperTaskEdit(mf, id);
                pte.ShowDialog();

            }
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaperTaskInsert pti = new PaperTaskInsert(mf);
            pti.ShowDialog();
            DropDownShowYear();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewPaperTask.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(listViewPaperTask.SelectedItems[0].Tag.ToString());
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BKDataSet.PaperTaskRow pr = mf.DS.PaperTask.FindByid(id);
                    pr.Delete();
                    mf.papertaskTap.Update(mf.DS.PaperTask);

                    getPaperTaskListView();
                }
            }
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            增加ToolStripMenuItem_Click(sender, e);
        }

        private void tsbtnSub_Click(object sender, EventArgs e)
        {
            删除ToolStripMenuItem_Click(sender, e);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            修改ToolStripMenuItem_Click(sender, e);
        }

        //计算任务总额
        private void tsbCol_Click(object sender, EventArgs e)
        {
            CalMoney();
        }

        //计算任务金额方法
        private void CalMoney()
        {
            Plan = Sub = 0.0;

            if (listViewPaperTask.Items.Count > 0)
            {
                for (int i = 0; i < listViewPaperTask.Items.Count; i++)
                {
                    Plan += double.Parse(listViewPaperTask.Items[i].SubItems[3].Text);
                    Sub += double.Parse(listViewPaperTask.Items[i].SubItems[5].Text);
                }

            }
            labPlanTmoney.Text = Plan.ToString();
            labSubTmoney.Text = Sub.ToString();
            labSjTmoney.Text = (Plan - Sub).ToString();
        }
        //新增年度报刊数方法
        public void AddPaperNumbyNewYear(string OldYear, string NewYear)
        {
            var q = from p in mf.DS.PaperTask.AsEnumerable()
                    where p.year == OldYear
                    select p;
            foreach (var i in q)
            {
                mf.papertaskTap.Insert(i.paperid, i.number, NewYear);
            }
            mf.papertaskTap.Update(mf.DS.PaperTask);
            mf.DS.PaperTask.Dispose();
            mf.papertaskTap.Fill(mf.DS.PaperTask);
            //显示所有年度 下拉列表中要有新年度，并选中。
            DropDownShowYear();
            getPaperTaskListView();
            CalMoney();
        }
        public void ShowAllPaperTask()
        {
            DropDownShowYear();
           


        }
    }
}
