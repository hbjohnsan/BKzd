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
    public partial class PaperTaskEdit : Form
    {
        private MainFrm mf;
        private int id=0;       
        public PaperTaskEdit()
        {
            InitializeComponent();
        }
        public PaperTaskEdit(MainFrm f, int sid)
        {
            InitializeComponent();
            mf = f;
            id = sid;
           
        }

        private void PaperTaskEdit_Load(object sender, EventArgs e)
        {
            BKDataSet.PaperTaskRow ptr = mf.DS.PaperTask.FindByid(id);
            txtNum.Text = ptr.number.ToString();
            txtYear.Text = ptr.year;
           
        }


        private void btnEditTask_Click(object sender, EventArgs e)
        {
            BKDataSet.PaperTaskRow ptr = mf.DS.PaperTask.FindByid(id);
            ptr.number = Int32.Parse(txtNum.Text.Trim());
            mf.papertaskTap.Update(mf.DS.PaperTask);
            mf.getPaperTaskListView();

            this.DialogResult = DialogResult.OK;
        }





    }
}
