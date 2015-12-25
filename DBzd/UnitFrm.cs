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
    public partial class UnitFrm : DockContent
    {
        private string UnitID;
        private MainFrm mf;
        public UnitFrm()
        {
            InitializeComponent();
        }
        public UnitFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void UnitFrm_Load(object sender, EventArgs e)
        {
            listByKind();
           
            //  listviewPostRelaod();
            //添加新年度列表。
            AddNewYearList();

            listviewUnitRelaod();
        }
        //添加新年度列表。
        private void AddNewYearList()
        {
            for (int i = 2000; i < 2101; i++)
            {
                tscmbYear.Items.Add(i.ToString());
            }
            tscmbYear.SelectedItem = (DateTime.Now.Year + 1).ToString();
        }
        //单位类别
        private void listByKind()
        {
            var q = from p in mf.DS.Unit.AsEnumerable()
                    select p.Kind;
            foreach (var i in q.Distinct())
            {
                tscombKind.Items.Add(i);
            }

        }
        //单击列表单位后，显示单位职务，人员信息
        private void listViewUnit_Click(object sender, EventArgs e)
        {
            if (listViewUnit.SelectedItems.Count > 0)
            {
                 UnitID = listViewUnit.SelectedItems[0].Tag.ToString().Trim();
                
                listviewPersoneRelaod(UnitID);
                listviewPostRelaod(UnitID);
            }
        }

        #region listview重载外窗体使用
        //加载单位表
        public void listviewUnitRelaod()
        {
            string year = tscmbYear.SelectedItem.ToString();
            listViewUnit.Items.Clear();
            var q = from un in mf.DS.Unit.AsEnumerable()
                    where un.Year == year
                    orderby un.UnitID                     
                    select un;
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { "", i.UnitID, i.AllName, i.ShortName, i.Kind, i.Tel, i.Fax, i.Istake });
                lv.Tag = i.ID;
                listViewUnit.Items.Add(lv);
            }
            //显示行号
            for (int i = 0; i < listViewUnit.Items.Count; i++)
            {
                listViewUnit.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }
        //加载单位职务表
        public void listviewPostRelaod(string uID)
        {
            listViewPost.Items.Clear();
            var q = from po in mf.DS.UnitPost.AsEnumerable()
                    from un in mf.DS.Unit.AsEnumerable()           
                    where po.UnitID == uID && un.UnitID == uID
                    select new
                    {
                        id = po.ID,
                        unname = un.ShortName,
                        post = po.UnitPost,                 
                        tel = po.UnitPostTel
                    };
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { i.unname, i.post,  i.tel });
                lv.Tag = i.id;
                listViewPost.Items.Add(lv);
            }
        }
        //加载人员表
        public void listviewPersoneRelaod(string uID)
        {
            listViewPersone.Items.Clear();
            var q = from p in mf.DS.People.AsEnumerable()
                    where p.UnitID == uID
                    select p;
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { i.Name, i.Phone, i.HomeTel, i.Sex });
                lv.Tag = i.PeopleID;
                listViewPersone.Items.Add(lv);

            }
        }
        #endregion

        #region 右键菜单

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewUnit.SelectedItems.Count > 0)
            {
                int id =Int32.Parse(listViewUnit.SelectedItems[0].Tag.ToString());
                UnitEidtFrm uef = new UnitEidtFrm(mf, id);
                uef.ShowDialog();
                listviewUnitRelaod();
            }
            else
            {
                MessageBox.Show("请选择单位！");
                return;
            }

        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitInsertFrm uif = new UnitInsertFrm(mf);
            uif.ShowDialog();
        }

        private void 删除toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewUnit.SelectedItems.Count > 0)
            {
                int id =Int32.Parse(listViewUnit.SelectedItems[0].Tag.ToString());
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mf.DS.Unit.FindByID(id).Delete();
                    listViewUnit.SelectedItems[0].Remove();                   
                    mf.unitTap.Update(mf.DS.Unit);

                }
            }
            else
            {
                MessageBox.Show("请选择单位！");
                return;
            }

        }


        private void 修改单位职务ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listViewPost.SelectedItems.Count > 0)
            {
                int id = Int32.Parse(listViewPost.SelectedItems[0].Tag.ToString());
                UnitPostEdit upe = new UnitPostEdit(mf, id);
                upe.ShowDialog();
                listviewPostRelaod(UnitID);
            }
            else
            {
                MessageBox.Show("请选择单位！");
                return;
            }
        }

        private void 删除单位职务ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listViewPost.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(listViewPost.SelectedItems[0].Tag.ToString());
                BKDataSet.UnitPostRow re = mf.DS.UnitPost.FindByID(id);
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    re.Delete();
                    listViewPost.SelectedItems[0].Remove();
                    mf.unitpostTap.Update(mf.DS.UnitPost);
                }
            }
            else
            {
                MessageBox.Show("请选择单位！");
                return;
            }
        }

        private void 修改人员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewPersone.SelectedItems.Count > 0)
            {
                int pid = Int32.Parse(listViewPersone.SelectedItems[0].Tag.ToString());
                //UnitPersoneEditFrm pue = new UnitPersoneEditFrm(mf, pid);
                //pue.ShowDialog();

            }
            else
            {
                MessageBox.Show("请选择人员！");
                return;
            }
        }

        private void 删除人员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewPersone.SelectedItems.Count > 0)
            {
                int pid = Int32.Parse(listViewPersone.SelectedItems[0].Tag.ToString());
                BKDataSet.PeopleRow re = mf.DS.People.FindByPeopleID(pid);
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    re.Delete();
                    listViewPersone.SelectedItems[0].Remove();
                    mf.peopleTap.Update(mf.DS.People);
                }
            }
            else
            {
                MessageBox.Show("请选择人员！");
                return;
            }
        }


        private void 增加单位人员ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listViewUnit.SelectedItems.Count > 0)
            {
                string unitid = listViewUnit.SelectedItems[0].Text;
                //UnitPersoneInsert upi = new UnitPersoneInsert(mf, unitid);
                //upi.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择单位！");
                return;
            }

        }


        private void 增加单位职务ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listViewUnit.SelectedItems.Count > 0)
            {
                string unitid = listViewUnit.SelectedItems[0].Tag.ToString();
                UnitPostInsert upi = new UnitPostInsert(mf, unitid);
                upi.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择单位！");
                return;
            }
        }
        #endregion



        #region 工具栏

        //搜索工具栏
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            listViewUnit.Items.Clear();
            string upper = toolStripTextBox1.Text.ToUpper();
            var unit = from p in mf.DS.Unit.AsEnumerable()
                       select p;
            int xh = 1;
            foreach (var i in unit)
            {
                string namecode = PinYin.GetCodstring(i.ShortName);

                //  if (namecode.Contains(upper))
                if (namecode.StartsWith(upper))
                {
                    ListViewItem lv = new ListViewItem(new string[] { (xh++).ToString(), i.UnitID, i.AllName, i.ShortName, i.Kind, i.Tel, i.Fax, i.Istake });
                    lv.Tag = i.ID;
                    listViewUnit.Items.Add(lv);
                }
            }
           
        }
        //增加
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            新增ToolStripMenuItem_Click(sender, e);
        }
        //删除
        private void tsbtnSub_Click(object sender, EventArgs e)
        {

            删除toolStripMenuItem_Click(sender, e);
        }
        //修改
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            修改ToolStripMenuItem_Click(sender, e);
        }
        //增加职务
        private void tsbtnPost_Click(object sender, EventArgs e)
        {
            增加单位职务ToolStripMenuItem1_Click(sender, e);
        }

        //增加人员
        private void tsbtnPerson_Click(object sender, EventArgs e)
        {
            增加单位人员ToolStripMenuItem1_Click(sender, e);
        }
        //单位类别列表
        private void tscombKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewUnit.Items.Clear();
            var q = from p in mf.DS.Unit.AsEnumerable()
                    orderby p.UnitID
                    where p.Kind == tscombKind.Text.Trim()
                    select p;
            int xh = 1;
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { (xh++).ToString(), i.UnitID, i.AllName, i.ShortName, i.Kind, i.Tel, i.Fax, i.Istake });
                lv.Tag = i.ID;
                listViewUnit.Items.Add(lv);
            }
           
        }
        //显示有订刊任务单位
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            listViewUnit.Items.Clear();
            var q = from p in mf.DS.Unit.AsEnumerable()
                    orderby p.UnitID
                    where p.Istake == "是"
                    select p;
            int xh = 1;
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { (xh++).ToString(), i.UnitID, i.AllName, i.ShortName, i.Kind, i.Tel, i.Fax, i.Istake });
                lv.Tag = i.UnitID;
                listViewUnit.Items.Add(lv);
            }
          
        }
        //显示全部单位
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            listViewUnit.Items.Clear();
            var q = from p in mf.DS.Unit.AsEnumerable()
                    orderby p.UnitID
                    select p;
            int xh = 1;
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { (xh++).ToString(), i.UnitID, i.AllName, i.ShortName, i.Kind, i.Tel, i.Fax, i.Istake });
                lv.Tag = i.ID;
                listViewUnit.Items.Add(lv);
            }
           
        }
        #endregion




    }
}
