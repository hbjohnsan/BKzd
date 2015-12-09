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
    public partial class UnitEidtFrm : Form
    {
        private MainFrm mf;
        private string unitid;
        public UnitEidtFrm()
        {
            InitializeComponent();
        }
        public UnitEidtFrm(MainFrm f, string id)
        {
            InitializeComponent();
            mf = f;
            unitid = id;
        }
        //窗口加载
        private void UnitEidtFrm_Load(object sender, EventArgs e)
        {
            var q = from p in mf.DS.Unit.AsEnumerable()
                    select p.UnitID;
            foreach (var i in q)
            {
                combcode.Items.Add(i);
            }
            var q1 = from p in mf.DS.Unit.AsEnumerable()
                     select p.Kind;
            foreach (var i in q1.Distinct())
            {
                combkind.Items.Add(i);
            }

            // combcode.SelectedText = unitid;
            showbyId();
        }
        //
        private void showbyId()
        {
            var q = from p in mf.DS.Unit.AsEnumerable()
                    where p.UnitID == unitid
                    select p;
            foreach (var i in q)
            {
                combcode.Text = unitid;
                txtallname.Text = i.AllName;
                txtshorname.Text = i.ShortName;
                combkind.Text = i.Kind;
                txtTel.Text = i.Tel;
                txtFax.Text = i.Fax;
                rabYes.Checked = (i.Istake.Equals("是")) ? true : false;
                rabNo.Checked = (i.Istake.Equals("否")) ? true : false;
                rabtnPayYes.Checked = (i.IsPay.Equals("是")) ? true : false;
                rabtnPayNo.Checked = (i.IsPay.Equals("否")) ? true : false;
                if (!DBNull.Value.Equals(i.AddressID))
                {
                    BKDataSet.AddressRow ar = mf.DS.Address.FindByID(Convert.ToInt32(i.AddressID));
                    combArea.Text = ar.Area;
                    combTwon.Text = ar.Town;
                }
               
            }
        }

        private void combcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = from p in mf.DS.Unit.AsEnumerable()
                    where p.UnitID == combcode.SelectedItem.ToString().Trim()
                    select p;
            foreach (var i in q)
            {
                txtallname.Text = i.AllName;
                txtshorname.Text = i.ShortName;
                combkind.Text = i.Kind;
                txtTel.Text = i.Tel;
                txtFax.Text = i.Fax;
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

            BKDataSet.UnitRow ur = mf.DS.Unit.FindByUnitID(combcode.SelectedItem.ToString());
            ur.UnitID = combcode.Text.Trim();
            ur.AllName = txtallname.Text.Trim();
            ur.ShortName = txtshorname.Text.Trim();
            ur.Tel = txtTel.Text.Trim();
            ur.Fax = txtFax.Text.Trim();
            ur.Kind = combkind.Text.Trim();
            if (rabYes.Checked == true)
            {
                ur.Istake = "是";
            }
            else
            {
                ur.Istake = "否";
            }
            if (rabtnPayYes.Checked == true)
            {
                ur.IsPay = "是";
            }
            else
            {
                ur.IsPay = "否";
            }
            //地址
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
                    ur.AddressID = flagID;
                }
                else
                {
                    //增加一个新地址的记录
                    mf.addressTap.Insert(combTwon.Text.Trim(), combArea.Text.Trim());
                    mf.DS.Address.Dispose();
                    mf.addressTap.Fill(mf.DS.Address);
                    ur.AddressID = mf.DS.Address.AsEnumerable().Select(t => t.Field<int>("ID")).Max();
                }
            }
            

            mf.unitTap.Update(mf.DS.Unit);
            mf.DS.Unit.Dispose();
            mf.unitTap.Fill(mf.DS.Unit);
            mf.ReloadUnitFrmListView1();
            if (combcode.Items.Count > 0)
            {
                combcode.SelectedIndex = combcode.SelectedIndex + 1;
            }
            else
            {
                txtTel.Text = "";
                txtFax.Text = "";
            }


        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            txtFax.Text = txtTel.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.OK;
        }


    }
}
