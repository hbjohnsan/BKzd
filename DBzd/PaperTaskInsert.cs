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
    public partial class PaperTaskInsert : Form
    {
        private MainFrm mf;
        public PaperTaskInsert()
        {
            InitializeComponent();
        }
        public PaperTaskInsert(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }
        private void PaperTaskInsert_Load(object sender, EventArgs e)
        {
            for (int i = 2000; i < 2101; i++)
            {
                combYear.Items.Add(i.ToString());

            }
            combYear.SelectedItem = (DateTime.Now.Year + 1).ToString();

        }





        //判断年度任务中是否已经有年度任务数了。
        //private bool HasYear()
        //{
        //    //bool f = true;
        //    //var q = (from p in mf.DS.Paper.AsEnumerable() where p.year == combYear.SelectedItem.ToString().Trim() select p).ToList();
        //    //if (q.Count > 0)
        //    //{
        //    //    return f;
        //    //}
        //    //else
        //    //{
        //    //    f = false;
        //    //}
        //    //return f;

        //}

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            //判断年度任务中是否已经有年度任务数了。
            //if (HasYear())
            //{
            //    MessageBox.Show("已经有该年度的报刊任务了！");
            //    return;
               
            //}
            //else
            //{
            //    foreach (Control c in this.groupBox1.Controls)
            //    {
            //        if (c is NumericUpDown)
            //        {
            //            if (c.Text != "0")
            //            {
            //                // todo:MessageBox.Show(c.Tag.ToString() +"-----"+c.Text);
            //                //执行数据添加
            //               // mf.paperTap.Insert(c.Tag.ToString(), Convert.ToInt32(c.Text), combYear.SelectedItem.ToString());
            //            }

            //        }
            //    }

            //    //mf.papertaskTap.Insert(pid, num, year);
            //    mf.paperTap.Update(mf.DS.Paper);
            //    mf.DS.Paper.Dispose();
            //    mf.paperTap.Fill(mf.DS.Paper);
            //    this.DialogResult = DialogResult.OK;
            //}
        }
    }
}
