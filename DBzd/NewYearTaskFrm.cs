using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DBzd
{
    public partial class NewYearTaskFrm : DockContent
    {
        private MainFrm mf;
        public NewYearTaskFrm()
        {
            InitializeComponent();
        }
        public NewYearTaskFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        //判断输入的字符是否为数字
        public bool BolNum(string temp)
        {
            for (int i = 0; i < temp.Length; i++)
            {
                byte tempByte = Convert.ToByte(temp[i]);
                if ((tempByte < 48) || (tempByte > 57))
                {
                    return false;
                }

            }
            return true;
        }

      

        //初始化年度下拉列表
        private void NewYearTaskFrm_Load(object sender, EventArgs e)
        {

            for (int i = 2000; i < 2101; i++)
            {
                cboxOldYear.Items.Add(i.ToString());
                cboxNewYear.Items.Add(i.ToString());

            }
            cboxOldYear.SelectedItem = DateTime.Now.Year.ToString();
            cboxNewYear.SelectedIndex = cboxOldYear.SelectedIndex + 1;

        }


        #region 鼠标进入
        private void btnAddPaper_MouseEnter(object sender, EventArgs e)
        {
            mf.报刊ToolStripMenuItem_Click(sender, e);
        }
        

        private void btnSharePaper_MouseEnter(object sender, EventArgs e)
        {
            mf.分配任务ToolStripMenuItem_Click(sender, e);
        }
        private void btnShareMoney_MouseEnter(object sender, EventArgs e)
        {
            mf.分配金额ToolStripMenuItem_Click(sender, e);
        }

        #endregion


        #region 四个判断
        //1、判断报刊表中是否已经有新年度的报刊
        private bool HasPaper()
        {
            bool f = true;
            var q = (from p in mf.DS.Paper.AsEnumerable() where p.year == cboxNewYear.SelectedItem.ToString() select p).ToList(); ;
            if (q.Count > 0)
            {
                return f;
            }
            else
            {
                f = false;
            }
            return f;
        }
        //2、判断是否有该年度的的任务
        private bool HasTask()
        {
            bool f = true;
            var q = (from p in mf.DS.Paper.AsEnumerable() where p.year == cboxNewYear.SelectedItem.ToString() select p).ToList();
            if (q.Count > 0)
            {
                return f;

            }
            else
            {
                f = false;
            }
            return f;
        }
        //3、判断是否有该年度的－－县直分配数
        private bool HasShared()
        {
            bool f = true;
            var q = (from p in mf.DS.UnitPaperTask.AsEnumerable() where p.year == cboxNewYear.SelectedItem.ToString() select p).ToList();
            if (q.Count > 0)
            {
                return f;
            }
            else
            {
                f = false;
            }
            return f;
        }
        //4、判断是否分配了现金任务金额
        private bool HasSharedMoney()
        {
            bool f = true;
            var q = (from p in mf.DS.UnitMoneyTask.AsEnumerable() where p.year == cboxNewYear.SelectedItem.ToString() select p).ToList();
            if (q.Count>0)
            {
                return f;
            }
            else
            {
                f = false;
            }
            return f;
        }
        #endregion






    }
}
