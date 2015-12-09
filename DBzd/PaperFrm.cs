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
    public partial class PaperFrm : DockContent
    {
        private MainFrm mf;
        public PaperFrm()
        {
            InitializeComponent();
        }
        public PaperFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void NewsPaperFrm_Load(object sender, EventArgs e)
        {
            DropDownShowYear();
            getPaperListView();
            AddNewYearList();
        }

        #region 年度下拉列表
        private void DropDownShowYear()
        {

            toolStripComboBox1.Items.Clear();

            var q = from p in mf.DS.Paper.AsEnumerable()
                    orderby p.Year descending
                    select p.Year;
            foreach (var y in q.Distinct())
            {
                toolStripComboBox1.Items.Add(y);
            }
            toolStripComboBox1.SelectedIndex = 0;

        }
        #endregion

        //显示列表中的报纸列表
        public void getPaperListView()
        {
            double TotalMoney, TotalSubsidy;
            TotalMoney = TotalSubsidy = 0;
            listView1.Items.Clear();

            var qe = from p in mf.DS.Paper.AsEnumerable()
                     where p.Year == toolStripComboBox1.SelectedItem.ToString().Trim()
                     select p;
            foreach (var i in qe)
            {
                Paper paper = new Paper(i.ID, i.PaperID, i.YFDH, i.Name, i.Number, i.Price, i.SubSidy, i.TotalPrice, i.TotalSubSidy, i.IsDanKan, i.Year);

                ListViewItem lv = new ListViewItem(new string[] { i.PaperID, i.YFDH, i.Name, i.Number.ToString(), i.Price.ToString(), i.SubSidy.ToString(), i.TotalPrice.ToString(), i.TotalSubSidy.ToString(), i.IsDanKan, i.Year });
                lv.Tag = paper;
                listView1.Items.Add(lv);
            }
            //显示总金额及补贴额
            foreach (var item in qe)
            {
                TotalMoney = TotalMoney + item.TotalPrice;
                TotalSubsidy = TotalSubsidy + item.TotalSubSidy;
            }



            mf.toolStripStatusLabel1.Text = "上级总任务金额：" + TotalMoney.ToString() + "                "
                + "总补贴金额：" + TotalSubsidy.ToString();
        }

        #region 工具栏
        //增加
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            PaperInsert pi = new PaperInsert(mf, toolStripComboBox1.SelectedItem.ToString());
            DialogResult result = pi.ShowDialog();
            if (result == DialogResult.OK)
            {
                getPaperListView();
            }
        }
        //删除
        private void tsbtnSub_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int id = Int32.Parse(listView1.SelectedItems[0].Tag.ToString());
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BKDataSet.PaperRow pr = mf.DS.Paper.FindByID(id);
                    pr.Delete();
                    mf.paperTap.Update(mf.DS.Paper);
                    mf.paperTap.Dispose();
                    mf.paperTap.Fill(mf.DS.Paper);
                    getPaperListView();
                    if (listView1.Items.Count < 1)
                    {
                        DropDownShowYear();
                    }
                }
            }

        }
        #region 修改报刊
        //修改
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            EditPaper();
        }
        //双击单元格，修改报刊项
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            EditPaper();
        }
        //修改报刊上级任务
        private void EditPaper()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Paper paper = listView1.SelectedItems[0].Tag as Paper;
                PaperEdit pe = new PaperEdit(mf, paper);
                DialogResult result = pe.ShowDialog();
                if (result == DialogResult.OK)
                {
                    getPaperListView();

                }
            }
        }

        #endregion
        //年度列表框
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPaperListView();
        }


        //复制增加新年度报刊及任务数
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //需求判断这个新年度任务是否已经存在。
            //if (HasYear())
            //{
            //    MessageBox.Show("该年度任务已经存，请不要再添加！或选择正确的年度任务！");
            //    return;
            //}
            //else
            //{
            //    var q = from p in mf.DS.Paper.AsEnumerable()
            //            where p.year == toolStripComboBox1.SelectedItem.ToString()
            //            select p;
            //    foreach (var i in q)
            //    {
            //        mf.paperTap.Insert(i.paperid, i.yfdh, i.name, i.number, i.price, i.subsidy, i.totalPrice, i.totalSubsidy, i.IsDanKan, toolStripComboBox2.SelectedItem.ToString().Trim());
            //    }
            //    mf.paperTap.Update(mf.DS.Paper);
            //    mf.DS.Paper.Dispose();
            //    mf.paperTap.Fill(mf.DS.Paper);

            //    DropDownShowYear();
            //    getPaperListView();
            //}
        }
        #endregion

        #region 功能
        //添加新年度列表。
        private void AddNewYearList()
        {
            for (int i = 2000; i < 2101; i++)
            {
                toolStripComboBox2.Items.Add(i.ToString());
            }
            toolStripComboBox2.SelectedItem = (Convert.ToInt32(toolStripComboBox1.SelectedItem) + 1).ToString();
        }
        //判断该新年度是否已经存在
        private bool HasYear()
        {
            bool f = true;
            //var q = (from p in mf.DS.Paper.AsEnumerable()
            //         where p.year == toolStripComboBox2.SelectedItem.ToString().Trim()
            //         select p.year).ToList();
            //if (q.Count() > 0)
            //{
            //    return f;
            //}
            //else
            //{
            //    f = false;
            //}
            return f;
        }

        //判断当年列表中的项是否为否，如果为空也就同删除了所有年度任务，需要重新加载下拉年度表。

        #endregion

    }
}
