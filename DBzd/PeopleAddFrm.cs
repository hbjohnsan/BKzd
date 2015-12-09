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
    public partial class PeopleAddFrm : Form
    {
        private MainFrm mf;
        public PeopleAddFrm()
        {
            InitializeComponent();
        }
        public PeopleAddFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void LoadUnit()
        {
            combUnit.Items.Clear();
            var q = from p in mf.DS.Unit.AsEnumerable()
                    select p;
            foreach (var i in q)
            {
                Unit u = new Unit();
                //u.unitid = i.UnitID;
                //u.shortname = i.ShortName;
                combUnit.Items.Add(u);
            }
            combUnit.DisplayMember = "ShortName";

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            combUnit.Items.Clear();
            string upper = txtSearch.Text.ToUpper();
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

        private void PeopleAddFrm_Load(object sender, EventArgs e)
        {
            LoadUnit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            BKDataSet.PeopleRow rw = mf.DS.People.NewPeopleRow();
            rw.UnitID = (combUnit.SelectedItem as Unit).UnitID;
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
            if (combTwon.Text != "" && combArea.Text != "")
            {
                int flagID = 0;
                var q = from p in mf.DS.Address.AsEnumerable()
                        select p;
                foreach (var i in q)
                {
                    if (i.Town == combTwon.Text.Trim() && i.Area == combArea.Text.Trim())
                    {
            //todo:            flagID = i.ID;
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
            mf.peopleTap.Insert(rw.UnitID, rw.Name, rw.Sex, rw.HomeTel, rw.Phone, rw.Phone2, rw.QQ, rw.QQ2, rw.Email, rw.CardId, rw.AddressID);
            mf.DS.People.Dispose();
            mf.peopleTap.Fill(mf.DS.People);

            this.DialogResult = DialogResult.OK;
        }

    }
}
