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

    public partial class PaperEdit : Form
    {
        MainFrm mf;
        Paper paper;
        public PaperEdit()
        {
            InitializeComponent();
        }
        public PaperEdit(MainFrm f, Paper p)
        {
            InitializeComponent();
            mf = f;
            paper = p;

            labID.Text = paper.ID.ToString();
            txtPaperCode.Text = paper.YFDH;
            txtAllname.Text =paper.Name;
            txtNumb.Text = paper.Number.ToString();
            txtPrice.Text =paper.Price.ToString();
            txtSubsidy.Text = paper.SubSidy.ToString();
            txtYear.Text = paper.Year;
            txtCode.Text = paper.PaperID;
            if (paper.IsDanKan == "是")
            {
                rabYes.Checked = true;
            }
            else
            {
                rabNo.Checked = true;
            }

        }

       
        private void btnEditOK_Click(object sender, EventArgs e)
        {
            BKDataSet.PaperRow pr = mf.DS.Paper.FindByID(Int32.Parse(labID.Text));
            pr.PaperID = txtCode.Text.Trim();
            pr.Name = txtAllname.Text.Trim();
            pr.Number = Convert.ToInt32(txtNumb.Text.Trim());
            pr.Price = double.Parse(txtPrice.Text.Trim());
            pr.SubSidy = double.Parse(txtSubsidy.Text.Trim());
            pr.TotalPrice = pr.Number * pr.Price;
            pr.TotalSubSidy = pr.Number * pr.SubSidy;
            pr.Year = txtYear.Text.Trim();
            mf.paperTap.Update(pr);
            //mf.paperTap.Dispose();
            //mf.paperTap.Fill(mf.DS.Paper);
            this.DialogResult = DialogResult.OK;
        }



    }
}
