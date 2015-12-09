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
    public partial class UnitTaskInsert : Form
    {
        private MainFrm mf;
        public UnitTaskInsert()
        {
            InitializeComponent();
        }
        public UnitTaskInsert(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void UnitTaskInsert_Load(object sender, EventArgs e)
        {
            //numericUpDown1
            getCombNoTaskUnit();
            getOtherPaper();
        }
        //显示非重点党刊
        private void getOtherPaper()
        {
            //List<string> pID = (new string[] { "101", "102", "103", "104", "105", "201", "202", "203", "301", "302" }).ToList<string>();
            //List<string> Pid = (from p in mf.DS.Paper select p.paperid).ToList<string>();
            //List<string> NoKan = Pid.Except(pID).ToList<string>();

            //foreach (var i in NoKan)
            //{
            //    var q = from p in mf.DS.Paper.AsEnumerable() where p.paperid == i select p;
            //    foreach (var s in q)
            //    {
            //        Paper p = new Paper();
            //        p.paperid = s.paperid;
            //        p.name = s.name;
            //        combKanWu.Items.Add(p);
            //    }
            //    combKanWu.DisplayMember = "name";
            //    if (combKanWu.Items.Count > 0)
            //    {
            //        combKanWu.SelectedIndex = 0;
            //    }
            //}

        }
        //显示未分配任务单位列表
        private void getCombNoTaskUnit()
        {

            //List<string> u = (from p in mf.DS.Unit.AsEnumerable() where p.Istake == "是" select p.unitid).ToList<string>();
            //List<string> ut = (from t in mf.DS.UnitPaperTask.AsEnumerable() select t.unitid).Distinct().ToList<string>();
            //List<string> NoTasks = u.Except(ut).ToList<string>();
            //foreach (var i in NoTasks)
            //{
            //    var q = from p in mf.DS.Unit.AsEnumerable() where p.unitid == i select p;
            //    foreach (var ss in q)
            //    {
            //        Unit un = new Unit();
            //        un.unitid = ss.unitid;
            //        un.shortname = ss.shortname;
            //        combNoTaskUnit.Items.Add(un);
            //    }
            //    combNoTaskUnit.DisplayMember = "shortname";
            //    if (combNoTaskUnit.Items.Count > 0)
            //    {
            //        combNoTaskUnit.SelectedIndex = 0;
            //    }
            //}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtYear.Text == "")
            {
                MessageBox.Show("年度不能为空！");
                return;                
            }
            Unit u = combNoTaskUnit.SelectedItem as Unit;

            if (nUD101.Value > 0)
            {
                string pid = "101";
                int m = Convert.ToInt32(nUD101.Value);
                upUnitTask(u, pid, m);
            }
            if (nUD102.Value > 0)
            {
                string pid = "102";
                int m = Convert.ToInt32(nUD102.Value);
                upUnitTask(u, pid, m);
            }
            if (nUD103.Value > 0)
            {
                string pid = "104";
                int m = Convert.ToInt32(nUD103.Value);
                upUnitTask(u, pid, m);
            }
            if (nUD104.Value > 0)
            {
                string pid = "104";
                int m = Convert.ToInt32(nUD104.Value);
                upUnitTask(u, pid, m);
            }
            if (nUD105.Value > 0)
            {
                string pid = "105";
                int m = Convert.ToInt32(nUD105.Value);
                upUnitTask(u, pid, m);
            }
            if (nUD201.Value > 0)
            {
                string pid = "201";
                int m = Convert.ToInt32(nUD201.Value);
                upUnitTask(u, pid, m);
            }
            if (nUD202.Value > 0)
            {
                string pid = "202";
                int m = Convert.ToInt32(nUD202.Value);
                upUnitTask(u, pid, m);
            }
            if (nUD203.Value > 0)
            {
                string pid = "203";
                int m = Convert.ToInt32(nUD203.Value);
                upUnitTask(u, pid, m);
            }
            if (nUD301.Value > 0)
            {
                string pid = "301";
                int m = Convert.ToInt32(nUD301.Value);
                upUnitTask(u, pid, m);
            }
            if (nUD302.Value > 0)
            {
                string pid = "302";
                int m = Convert.ToInt32(nUD302.Value);
                upUnitTask(u, pid, m);
            }
            if (nUDOther.Value > 0)
            {
                Paper p = combKanWu.SelectedItem as Paper;
            //todo:    string pid = p.paperid;
                int m = Convert.ToInt32(nUDOther.Value);
        //todo:        upUnitTask(u, pid, m);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void upUnitTask(Unit u, string pid, int n)
        {
           // BKDataSet.UnitPaperTaskRow uptr = mf.DS.UnitPaperTask.NewUnitPaperTaskRow();
           // uptr.unitid = u.unitid;
           // uptr.paperid = pid;
           // uptr.plantnum = n;
           // uptr.year = txtYear.Text.Trim();
           //// uptr.truenum = 0;
           // mf.DS.UnitPaperTask.AddUnitPaperTaskRow(uptr);
           // mf.unitpapertaskTap.Update(mf.DS.UnitPaperTask);
        }

        private void btnGoOn_Click(object sender, EventArgs e)
        {
            if (nUDOther.Value > 0 && txtYear.Text!="")
            {
                Unit u = combNoTaskUnit.SelectedItem as Unit;
                Paper p = combKanWu.SelectedItem as Paper;

              //  BKDataSet.UnitPaperTaskRow uptr = mf.DS.UnitPaperTask.NewUnitPaperTaskRow();
              //  uptr.unitid = u.unitid;
              //  uptr.paperid = p.paperid;
              //  uptr.year = txtYear.Text.Trim();
              //  uptr.plantnum = Convert.ToInt32(nUDOther.Value);
              ////  uptr.truenum = 0;
              
              //  mf.DS.UnitPaperTask.AddUnitPaperTaskRow(uptr);
              //  mf.unitpapertaskTap.Update(mf.DS.UnitPaperTask);

                nUDOther.Value = 0;
            }
            else
            {
                MessageBox.Show("年度或订刊份数不能为空！");
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //combNoTaskUnit.Items.Clear();
            //string upper = txtSearch.Text.ToUpper();
            //var q = from p in mf.DS.Unit.AsEnumerable()
            //        select p;
            //foreach (var ss in q)
            //{
            //    string namecode = PinYin.GetCodstring(ss.shortname);
            //    if (namecode.StartsWith(upper))
            //    {
            //        Unit un = new Unit();
            //        un.unitid = ss.unitid;
            //        un.shortname = ss.shortname;
            //        combNoTaskUnit.Items.Add(un);
            //    }

            //}
            //combNoTaskUnit.DisplayMember = "shortname";
            //if (combNoTaskUnit.Items.Count > 0)
            //{
            //    combNoTaskUnit.SelectedIndex = 0;
            //}

        }
    }
}
