using System;
using System.Data;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Microsoft.Win32;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Net;
using System.Threading;
namespace DBzd
{
    public partial class MainFrm : Form
    {
        // public configBK configbk;

        public BKDataSet DS;
     
       
        public BKDataSetTableAdapters.UnitTableAdapter unitTap;
        public BKDataSetTableAdapters.UnitPostTableAdapter unitpostTap;

        public BKDataSetTableAdapters.PaperTableAdapter paperTap;
        public BKDataSetTableAdapters.PaperTaskTableAdapter paperTaskTap;
       

        public BKDataSetTableAdapters.FeesTableAdapter feesTap;

        public BKDataSetTableAdapters.PeopleTableAdapter peopleTap;
        public BKDataSetTableAdapters.PosterTableAdapter posterTap;
      

        public BKDataSetTableAdapters.ReceivablesTableAdapter receivablesTap;
   
        public BKDataSetTableAdapters.AddressTableAdapter addressTap;

        public BKDataSetTableAdapters.TruePaperTableAdapter truepaperTap;



        private UnitFrm unitfm;
        private TaskFrm unittaskfm;
        private PeopleFrm peoplefm;
        private PaperFrm paperfm;
        private FeesFrm feesfm;
        private EditNewTask editNewTaskfm;
        private IOUFrm ioufm;
        private ReplyFrm replyfm;
        private ReceivablesFrm recfm;
        private ToolsPaperNum toolsPaperNum;
        private CountFrm conutfm;





        public MainFrm()
        {

            InitializeComponent();

            DS = new BKDataSet();
            unitTap = new BKDataSetTableAdapters.UnitTableAdapter();
            unitpostTap = new BKDataSetTableAdapters.UnitPostTableAdapter();
            paperTap = new BKDataSetTableAdapters.PaperTableAdapter();
           
            paperTaskTap = new BKDataSetTableAdapters.PaperTaskTableAdapter();
            peopleTap = new BKDataSetTableAdapters.PeopleTableAdapter();
           
            posterTap = new BKDataSetTableAdapters.PosterTableAdapter();
          
            receivablesTap = new BKDataSetTableAdapters.ReceivablesTableAdapter();
            feesTap = new BKDataSetTableAdapters.FeesTableAdapter();
        
            addressTap = new BKDataSetTableAdapters.AddressTableAdapter();
            truepaperTap =new BKDataSetTableAdapters.TruePaperTableAdapter();

            unitTap.Fill(DS.Unit);
            unitpostTap.Fill(DS.UnitPost);
            paperTap.Fill(DS.Paper);
            paperTaskTap.Fill(DS.PaperTask);
         
            peopleTap.Fill(DS.People);
          
            posterTap.Fill(DS.Poster);
          
            receivablesTap.Fill(DS.Receivables);
            feesTap.Fill(DS.Fees);
            addressTap.Fill(DS.Address);
          
            truepaperTap.Fill(DS.TruePaper);
        }


        private void MainFrm_Load(object sender, EventArgs e)
        {

            //feesfm = new FeesFrm(this);
            //feesfm.Show(dockPanel1, DockState.Document);

            unitfm = new UnitFrm(this);
            unitfm.Show(dockPanel1, DockState.Document);

            this.toolStripStatusLabel3.Text = "系统当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.timer1.Interval = 1000;
            this.timer1.Start();

        }


        //todo:   1、在main中定义总工具栏，各分窗口再加入？

        #region 菜单项
        private void 单位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unitfm == null || unitfm.IsDisposed)
            {
                unitfm = new UnitFrm(this);
                unitfm.Show(dockPanel1, DockState.Document);
            }

            unitfm.Activate();

        }

        public void 报刊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (paperfm == null || paperfm.IsDisposed)
            {
                paperfm = new PaperFrm(this);
                paperfm.Show(dockPanel1, DockState.Document);
            }
            paperfm.Activate();
        }


        public void 分配任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unittaskfm == null || unittaskfm.IsDisposed)
            {
                unittaskfm = new TaskFrm(this);
                unittaskfm.Show(dockPanel1, DockState.Document);
            }
            unittaskfm.Activate();

        }
        private void 重新设计的任务表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editNewTaskfm == null || editNewTaskfm.IsDisposed)
            {
                editNewTaskfm = new EditNewTask(this);
                editNewTaskfm.Show(dockPanel1, DockState.Document);
            }
            editNewTaskfm.Activate();
        }

        private void 人员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (peoplefm == null || peoplefm.IsDisposed)
            {
                peoplefm = new PeopleFrm(this);
                peoplefm.Show(dockPanel1, DockState.Document);
            }
            peoplefm.Activate();
        }

        private void 收费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (feesfm == null || feesfm.IsDisposed)
            {
                feesfm = new FeesFrm(this);
                feesfm.Show(dockPanel1, DockState.Document);
            }
            feesfm.Activate();
        }

        private void 欠条ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ioufm == null || ioufm.IsDisposed)
            {
                ioufm = new IOUFrm(this);
                ioufm.Show(dockPanel1, DockState.Document);
            }
            ioufm.Activate();
        }
        private void 批复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (replyfm == null || replyfm.IsDisposed)
            {
                replyfm = new ReplyFrm(this);
                replyfm.Show(dockPanel1, DockState.Document);
            }
            replyfm.Activate();
        }

        private void 收费AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recfm == null || recfm.IsDisposed)
            {
                recfm = new ReceivablesFrm(this);
                recfm.Show(dockPanel1, DockState.Document);
                // recfm.Show(dockPanel1, DockState.Float);

            }
            recfm.Activate();
        }
        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolsPaperNum == null || toolsPaperNum.IsDisposed)
            {
                toolsPaperNum = new ToolsPaperNum(this);
                toolsPaperNum.Show(dockPanel1, DockState.Float);

            }
            toolsPaperNum.Activate();
        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conutfm == null || conutfm.IsDisposed)
            {
                conutfm = new CountFrm(this);
               // conutfm.Show(dockPanel1, DockState.Float);
                conutfm.Show(dockPanel1, DockState.Document);
            }
            conutfm.Activate();
        }
        #endregion

        #region 公用调用方法
        public void ReloadUnitFrmListView1()
        {
            unitfm.listviewUnitRelaod();
        }
        //public void ReloadListViewPost()
        //{
        //    unitfm.listviewPostRelaod();
        //}
        //public void ReloadListViewPersone()
        //{
        //    unitfm.listviewPersoneRelaod();
        //}

        public void ReloadPaperListView()
        {
            paperfm.getPaperListView();
        }



        //批量增加新年度 分配给县直单位任务
        public void AddTaskByXianZhi(string Oldyear, string NewYear)
        {

        }
        //批量增加新年度 分配给下级单位的现金任务
        public void AddTaskByMoney(string Old, string NYear)
        {

        }
        #endregion

        //时钟
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = "系统当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        





    }
}
