using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBzd
{
    public partial class UnitPostEdit : Form
    {
        MainFrm mf;
        private int UnitPostID;
        private int PeopleID;
        public UnitPostEdit()
        {
            InitializeComponent();
        }
        public UnitPostEdit(MainFrm f, int uid)
        {
            InitializeComponent();
            mf = f;
            UnitPostID = uid;
        }

        private void UnitPostEdit_Load(object sender, EventArgs e)
        {

            var q = from p in mf.DS.UnitPost.AsEnumerable()
                    from u in mf.DS.Unit.AsEnumerable()                   
                    where p.ID == UnitPostID && p.UnitID == u.UnitID// && p.PeopleID==pe.PeopleID
                    select new
                    {
                        id = u.UnitID,
                        shortname = u.ShortName,
                        postid = p.UnitPostID,
                        post = p.UnitPost,
                        tel = p.UnitPostTel,
                    //    peopleName=pe.Name,
                        year = p.Year

                    };
            foreach (var i in q)
            {              
                txtPostID.Text = i.postid;
                txtPost.Text = i.post;
                txtTel.Text = i.tel;
                txtYear.Text = i.year;
                txtUnitID.Text = i.id;
              //  txtPeople.Text = i.peopleName;
            }

           
            LoadPeople(txtUnitID.Text);
        }

        private void LoadPeople(string uID)
        {

            var q = from p in mf.DS.People.AsEnumerable()
                    where p.UnitID == uID
                    select p;
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { i.Name, i.Phone, i.HomeTel, i.Sex });
                lv.Tag = i.PeopleID;
                listView1.Items.Add(lv);
            }
        }
        //加载单位列表
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            BKDataSet.UnitPostRow rw = mf.DS.UnitPost.FindByID(UnitPostID);
            rw.UnitID = txtUnitID.Text.Trim();
            rw.UnitPost = txtPost.Text.Trim();
            rw.UnitPostID = txtPostID.Text.Trim();
            rw.UnitPostTel = txtTel.Text.Trim();
            rw.Year = txtYear.Text.Trim();
            if (txtPeople.Text != "")
            {
                rw.PeopleID = PeopleID;
            }


            mf.unitpostTap.Update(mf.DS.UnitPost);
            mf.DS.UnitPost.Dispose();
            mf.unitpostTap.Fill(mf.DS.UnitPost);

            this.DialogResult = DialogResult.OK;

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                PeopleID = Convert.ToInt32(listView1.SelectedItems[0].Tag.ToString());
                txtPeople.Text = listView1.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void txtSearchPeople_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string upperTxt = txtSearchPeople.Text.Trim().ToUpper();

            var q = from p in mf.DS.People.AsEnumerable()
                    select p;
            foreach (var i in q)
            {
                string name = PinYin.GetCodstring(i.Name);
                if (name.StartsWith(upperTxt))
                {
                    ListViewItem lv = new ListViewItem(new string[] { i.Name, i.Phone, i.HomeTel, i.Sex });
                    lv.Tag = i.PeopleID;
                    listView1.Items.Add(lv);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var q = from p in mf.DS.People.AsEnumerable()                 
                    select p;
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { i.Name, i.Phone, i.HomeTel, i.Sex });
                lv.Tag = i.PeopleID;
                listView1.Items.Add(lv);
            }
        }
    }
}
