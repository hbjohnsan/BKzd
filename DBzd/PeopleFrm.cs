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
    public partial class PeopleFrm : DockContent
    {
        private MainFrm mf;
        private int PeopleID = 0;
        public PeopleFrm()
        {
            InitializeComponent();
        }
        public PeopleFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void PeopleFrm_Load(object sender, EventArgs e)
        {
            //加载人员表
            LoadPeople();

            //加载单位列表
            LoadUnit();
        }

        private void LoadPeople()
        {
            listView1.Items.Clear();
            var q = from p in mf.DS.People.AsEnumerable()
                    select p;
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { i.Name });
                lv.Tag = i.PeopleID;
                listView1.Items.Add(lv);
            }
          
        }

        private void LoadUnit()
        {
            combUnit.Items.Clear();
            var q = from p in mf.DS.Unit.AsEnumerable()

                    select p;
            foreach (var i in q)
            {
                Unit u = new Unit();
                u.UnitID = i.UnitID;
                u.ShortName = i.ShortName;
                combUnit.Items.Add(u);
            }
            combUnit.DisplayMember = "ShortName";

        }
        //点击列表事件
        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                PeopleID = Convert.ToInt32(listView1.SelectedItems[0].Tag);

                BKDataSet.PeopleRow rw = mf.DS.People.FindByPeopleID(PeopleID);

                if (rw.UnitID != "")
                {
                    foreach (Unit u in combUnit.Items)
                    {
                        if (u.UnitID == rw.UnitID)
                        {
                            combUnit.SelectedItem = u;
                        }
                    }
                }


                txtName.Text = rw.Name;
                if (rw.Sex == "男")
                {
                    rabNan.Checked = true;
                }
                else
                {
                    rabNv.Checked = true;
                }

                txtHomeTel.Text = rw.HomeTel;
                txtPhone1.Text = rw.Phone;
                txtPhone2.Text = rw.Phone2;
                txtQQ1.Text = rw.QQ;
                txtQQ2.Text = rw.QQ2;
                txtCardID.Text = rw.CardId;
                BKDataSet.AddressRow ar = mf.DS.Address.FindByID(Convert.ToInt32(rw.AddressID));
                combTwon.SelectedItem = ar.Town;
                combArea.Text = ar.Area;
            }
        }
        //更新个人信息
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BKDataSet.PeopleRow rw = mf.DS.People.FindByPeopleID(PeopleID);
            rw.Name = txtName.Text.Trim();
            rw.HomeTel = txtHomeTel.Text.Trim();
            rw.Phone = txtPhone1.Text.Trim();
            rw.Phone2 = txtPhone2.Text.Trim();
            rw.QQ = txtQQ1.Text.Trim();
            rw.QQ2 = txtQQ2.Text.Trim();
            rw.CardId = txtCardID.Text.Trim();
            rw.Email = txtEmail.Text.Trim();
            if (rabNan.Checked == true)
            {
                rw.Sex = "男";
            }
            else
            {
                rw.Sex = "女";
            }
            if (combTwon.Text!="" && combArea.Text!="")
            {
                
           
            int flagID = 0;
            var q = from p in mf.DS.Address.AsEnumerable()
                    select p;
            foreach (var i in q)
            {
                if (i.Town == combTwon.Text.Trim() && i.Area == combArea.Text.Trim())
                {
       //todo:             flagID = i.ID;
                }
            }
            if (flagID > 0)
            {
                rw.AddressID = flagID;
            }
            else
            {
                //增加一个新地址的记录
                mf.addressTap.Insert(combTwon.Text.Trim(), combArea.Text.Trim());
                mf.DS.Address.Dispose();
                mf.addressTap.Fill(mf.DS.Address);
                rw.AddressID = mf.DS.Address.AsEnumerable().Select(t => t.Field<int>("ID")).Max();
            }
            }
            else
            {
                rw.AddressID = 1;
            }
           
            rw.UnitID = (combUnit.SelectedItem as Unit).UnitID;

            mf.peopleTap.Update(rw);
            mf.DS.People.Dispose();
            mf.peopleTap.Fill(mf.DS.People);
            LoadPeople();
            ClearTxt();
        }
        //信息清空
        private void ClearTxt()
        {
            txtName.Text = "";
            txtCardID.Text = "";
            txtEmail.Text = "";
            txtHomeTel.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtQQ1.Text = "";
            txtQQ2.Text = "";
            combArea.Text = "";
            combTwon.Text = "";
            combUnit.Text = "";

        }

        //搜索单位
        private void tsTxtSearch_TextChanged(object sender, EventArgs e)
        {
            combUnit.Items.Clear();
            string upper = tstxtSearchUnit.Text.ToUpper();
            var q5 = from p in mf.DS.Unit.AsEnumerable()
                     select p;
            foreach (var i in q5)
            {

                string namecode = PinYin.GetCodstring(i.ShortName);
                if (namecode.StartsWith(upper))
                {
                    Unit un = new Unit();
                    un.UnitID = i.UnitID;
                    un.ShortName = i.ShortName;
                    combUnit.Items.Add(un);
                }

            }
            combUnit.DisplayMember = "ShortName";


        }

        //搜索人员
        private void tstxtSearchPeople_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string upperTxt = tstxtSearchPeople.Text.Trim().ToUpper();

            var q = from p in mf.DS.People.AsEnumerable()

                    select p;
            foreach (var i in q)
            {
                string name = PinYin.GetCodstring(i.Name);
                if (name.StartsWith(upperTxt))
                {
                    ListViewItem lv = new ListViewItem(new string[] { i.Name });
                    lv.Tag = i.PeopleID;
                    listView1.Items.Add(lv);
                }

            }
          
        }
        //增加人员对话框
        private void tsbtnAddPeople_Click(object sender, EventArgs e)
        {
            PeopleAddFrm paf = new PeopleAddFrm(mf);
            paf.ShowDialog();
        }
        //删除
        private void tsbtnDelUnit_Click(object sender, EventArgs e)
        {          
            if (listView1.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(listView1.SelectedItems[0].Tag);
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                   
                    listView1.SelectedItems[0].Remove();
                    mf.DS.People.FindByPeopleID(id).Delete();
                    mf.peopleTap.Update(mf.DS.People);
                    mf.DS.People.Dispose();
                    mf.peopleTap.Fill(mf.DS.People);
                    
                }
            }
            else
            {
                MessageBox.Show("请选择单位！");
                return;
            }
        }






    }
}
