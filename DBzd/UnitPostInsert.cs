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
    public partial class UnitPostInsert : Form
    {
        MainFrm mf;
        private string unitid;
        public UnitPostInsert()
        {
            InitializeComponent();
        }
        public UnitPostInsert(MainFrm f, string id)
        {
            InitializeComponent();
            mf = f;
            unitid = id;
        }

        private void UnitPostInsert_Load(object sender, EventArgs e)
        {
            txtUnitID.Text = unitid;
            var q = from p in mf.DS.Unit.AsEnumerable()
                    where p.UnitID == unitid
                    select p;
            foreach (var i in q)
            {
                txtUnitName.Text = i.ShortName;
            }

            //显示单位职务ID
            getUnitPostID();
        }

        private void getUnitPostID()
        {
            //List<string> up = (from p in mf.DS.UnitPost.AsEnumerable() where p.unitPostID.Contains(unitid) select p.unitPostID).ToList();

            //if (up.Count() > 0)
            //{
            //    int idadd = Int32.Parse(up.Max().Substring(up.Max().Length - 3, 3)) + 1;
            //    string strid = "";
            //    if (idadd < 10) { strid = "00" + idadd.ToString(); }
            //    if (idadd > 9 && idadd < 100) { strid = "0" + idadd.ToString(); }
            //    string code = up.Max().Substring(0, up.Max().Length - 3) + strid.ToString();
            //    txtPostID.Text = code;
            //    txtPostID.Enabled = false;
            //}
            //else
            //{
            //    txtPostID.Text = unitid+"p001";
            //    txtPostID.Enabled = false;
            //}
            //txtYear.Text = DateTime.Now.Year.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUnitID.Text == txtPostID.Text)
            {
                MessageBox.Show("职务ID不能与单位ID相同！");
                return;
            }
            if (txtPost.Text=="")
            {
                return;
            }
            else
            {
                //BKDataSet.UnitPostRow ur = mf.DS.UnitPost.NewUnitPostRow(); 
                //ur.unitid=unitid;
                //ur.unitPost=txtPost.Text;
                //ur.unitPostID=txtPostID.Text;;
                //ur.unitPostTel=txtTel.Text;
                //ur.year=txtTel.Text;
                //mf.DS.UnitPost.AddUnitPostRow(ur);
                //mf.unitpostTap.Update(mf.DS.UnitPost);
                //mf.DS.Unit.Dispose();
                //mf.unitpostTap.Fill(mf.DS.UnitPost);
                //mf.ReloadListViewPost();
                //getUnitPostID();
                //txtPost.Text = txtTel.Text = "";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPost.Text!="")
            {
                btnAdd_Click(sender, e);
            }
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
