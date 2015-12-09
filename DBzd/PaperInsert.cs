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
    public partial class PaperInsert : Form
    {
        MainFrm mf;
        private string Year = "";
        public PaperInsert()
        {
            InitializeComponent();
        }
        public PaperInsert(MainFrm f, string y)
        {
            InitializeComponent();
            mf = f;
            Year = y;
        }

        private void PaperInsert_Load(object sender, EventArgs e)
        {
            combPaper.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtAllname.Text != "" && txtPaperCode.Text != "")
            {
                //string paperid = "";
                //switch (combPaper.SelectedIndex)
                //{
                //    case 0:
                //        List<string> pidz = (from p in mf.DS.Paper.AsEnumerable() where p.paperid.StartsWith("1") orderby p.paperid descending select p.paperid).ToList<string>();
                //        paperid = (Int32.Parse(pidz.Max()) + 1).ToString();
                //        break;
                //    case 1:
                //        List<string> pids = (from p in mf.DS.Paper.AsEnumerable() where p.paperid.StartsWith("2") orderby p.paperid descending select p.paperid).ToList<string>();
                //        paperid = (Int32.Parse(pids.Max()) + 1).ToString();
                //        break;
                //    case 2:
                //        List<string> pidm = (from p in mf.DS.Paper.AsEnumerable() where p.paperid.StartsWith("3") orderby p.paperid descending select p.paperid).ToList<string>();
                //        paperid = (Int32.Parse(pidm.Max()) + 1).ToString();
                //        break;
                //}
                //string Dangkan = (rabYes.Checked == true) ? "是" : "否";

                //int numb = Convert.ToInt32(txtNumb.Text.Trim());
                //double price = double.Parse(txtPrice.Text.Trim());
                //double subsidy = double.Parse(txtSubsidy.Text.Trim());
                //double totalprice = numb * price;
                //double totalsubsidy = numb * subsidy;

                //这一句到库了
                //mf.paperTap.Insert(paperid, txtPaperCode.Text.Trim(), txtAllname.Text.Trim(), numb, price, subsidy, totalprice, totalsubsidy, Dangkan, Year);
                ////更新一把
                //mf.paperTap.Update(mf.DS.Paper);
                ////消除
                //mf.DS.Paper.Dispose();
                ////重新填充
                //mf.paperTap.Fill(mf.DS.Paper);

                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("相关信息不能为空！");
                return;
            }

        }



    }
}
