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
    public partial class UnitInsertFrm : Form
    {
        MainFrm mf;
        public UnitInsertFrm()
        {
            InitializeComponent();
        }
        public UnitInsertFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void UnitInsertFrm_Load(object sender, EventArgs e)
        {

            var q = from p in mf.DS.Unit.AsEnumerable()
                    orderby p.UnitID
                    select p;
            foreach (var i in q)
            {
                combFatherCode.Items.Add(i.UnitID);
                combcode.Items.Add(i.UnitID);
            }
            combFatherCode.SelectedIndex = 0;
            combkind.SelectedIndex = 0;
        }
        //根据类别找单位代码
        private void ChangUnitSelect(string str)
        {
            combFatherCode.Items.Clear();
            var q = from p in mf.DS.Unit.AsEnumerable()
                    where p.UnitID.Contains(str)
                    orderby p.UnitID

                    select p;
            foreach (var i in q)
            {
                combFatherCode.Items.Add(i.UnitID);
              
            }
            combFatherCode.SelectedIndex = 0;
          
        }



        private void getMaxID(string k)
        {
            combcode.Items.Clear();
            //取得最大id
            List<string> MaxID = (from p in combFatherCode.Items.Cast<string>() where p.Contains(k) select p).ToList<string>();
            //截取后3位加1合成
            int idadd = Int32.Parse(MaxID.Max().Substring(MaxID.Max().Length - 3, 3)) + 1;
            string strid = "";
            if (idadd < 10) { strid = "00" + idadd.ToString(); }
            if (idadd > 9 && idadd < 100) { strid = "0" + idadd.ToString(); }
            string code = MaxID.Max().Substring(0, MaxID.Max().Length - 3) + strid.ToString();
            combcode.Text = code;
        }
        //说明单位类型     
        //局:j   县直:z    乡镇\街道:t     企业:e    学校:s    协会:a    银行:b    医院:h
        private void combkind_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectChangeKind();
        }
        //变化时
        private void SelectChangeKind()
        {
            switch (combkind.Text)
            {
                case "乡镇":
                    ChangUnitSelect("t");
                    getMaxID("t");
                    break;
                case "街道":
                    ChangUnitSelect("t");
                    getMaxID("t");
                    break;
                case "局":
                    ChangUnitSelect("j");
                    getMaxID("j");
                    break;
                case "县直":
                    ChangUnitSelect("z");
                    getMaxID("z");
                    break;
                case "企业":
                    ChangUnitSelect("e");
                    getMaxID("e");
                    break;
                case "学校":
                    ChangUnitSelect("s");
                    getMaxID("s");
                    break;
                case "协会":
                    ChangUnitSelect("a");
                    getMaxID("a");
                    break;
                case "银行":
                    ChangUnitSelect("b");
                    getMaxID("b");
                    break;
                case "医院":
                    ChangUnitSelect("h");
                    getMaxID("h");
                    break;
                default:
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            

            if (txtallname.Text == "")
            {
                MessageBox.Show("单位名称不能为空");
                return;
            }
            BKDataSet.UnitRow ur = mf.DS.Unit.NewUnitRow();
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
            if (rabPayYes.Checked==true)
            {
                ur.IsPay = "是";
            }
            else
            {
                ur.IsPay = "否";
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
                //todo:        flagID = i.ID;
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


            mf.DS.Unit.AddUnitRow(ur);
            mf.unitTap.Update(mf.DS.Unit);
            //mf.DS.Unit.Dispose();
            //mf.unitTap.Fill(mf.DS.Unit);
            SelectChangeKind();
            mf.ReloadUnitFrmListView1();

            txtallname.Text = "";
           
        }
    }
}
