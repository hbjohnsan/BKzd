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
    public partial class UnitTaskMoneyFrm : DockContent
    {
        private MainFrm mf;
        private string year;
        public UnitTaskMoneyFrm()
        {
            InitializeComponent();
        }

        public UnitTaskMoneyFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void UnitTaskMoneyFrm_Load(object sender, EventArgs e)
        {
            Addyear();
            // ReLoadListViewUnitTaskMoney();
            NoMoneyUnit();
           
        }

        private void Addyear()
        {
            List<string> year = (from p in mf.DS.UnitMoneyTask.AsEnumerable() orderby p.year descending select p.year).ToList<string>();
            foreach (var i in year.Distinct())
            {
                tscombYear.Items.Add(i);
            }
            tscombYear.SelectedIndex = 0;
        }

        private void NoMoneyUnit()
        {
            List<string> u = (from p in mf.DS.Unit.AsEnumerable() where p.Istake == "是" select p.unitid).ToList<string>();
            List<string> ut = (from t in mf.DS.UnitMoneyTask.AsEnumerable() select t.unitid).Distinct().ToList<string>();
            List<string> NoTasks = u.Except(ut).ToList<string>();
            foreach (var i in NoTasks)
            {
                var q = from p in mf.DS.Unit.AsEnumerable() where p.unitid == i select p;
                foreach (var ss in q)
                {
                    ListViewItem lv = new ListViewItem(new string[] { ss.shortname });
                    lv.Tag = ss.unitid;
                    listViewNotMoney.Items.Add(lv);
                }

            }
        }

        private void ReLoadListViewUnitTaskMoney()
        {
            //todo:通过有任务的单位计算出单位计划金额。无计划任务，而有计划金额的查计划金额

            labTownM.Text = labXianXM.Text = "";
            listViewUnitPlantMoney.Items.Clear();
            //第一步，listview加单位，
            var q = from u in mf.DS.Unit
                    join c in mf.DS.UnitMoneyTask on u.unitid equals c.unitid
                    where u.Istake == "是"
                    select new
                    {   
                        unitid=u.unitid,
                        shortname=u.shortname,
                       compprices= c.totalprices,
                    };

            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { i.shortname, "", i.compprices.ToString(), "" });
                lv.Tag = i.unitid;
                listViewUnitPlantMoney.Items.Add(lv);
            }
            //第二步，加任务总金额，
            foreach (ListViewItem lv in listViewUnitPlantMoney.Items)
            {
                string unid = lv.Tag.ToString();
                lv.SubItems[1].Text = CalcUnitTotalMoney(unid).ToString();
                //lv.SubItems[2].Text = SelectUnitCompyMoney(unid).ToString();  //查询企业任务金额
               
                //lv.SubItems[3].Text = (double.Parse(lv.SubItems[1].Text) + double.Parse(lv.SubItems[2].Text)).ToString();
            }
            //第三步，计算总额
            //foreach (var i in q)
            //{
            //    if (i.kind == "镇")
            //    {
            //        mf.configbk.TownTotalMoney += i.pT;

            //    }
            //    else
            //    {
            //        mf.configbk.UnitToalMoney += i.pT;
            //    }
            //    ListViewItem lv = new ListViewItem(new string[] { i.unit, i.pMoney.ToString(), i.pQy.ToString(), i.pT.ToString() });
            //    lv.Tag = i.id;
            //    listViewUnitPlantMoney.Items.Add(lv);
            //}
            //labTownM.Text = mf.configbk.TownTotalMoney.ToString();
            //labXianXM.Text = mf.configbk.UnitToalMoney.ToString();
        }
        //有计划任务的单位，计算单位计划任务总金额。无计划任务但有计划金额的，查计划金额
        private double CalcUnitTotalMoney(string uid)
        {
            year = tscombYear.SelectedItem.ToString().Trim();
            double totalmoney = 0;
            //需要判断单位是否有计划任务；
            List<string> y = (from p in mf.DS.UnitPaperTask.AsEnumerable() where p.unitid == uid && p.year == year select p.unitid).ToList();
            if (y.Count > 0)
            {
                DataTable dt = (from p in mf.DS.UnitPaperTask.AsEnumerable() where p.unitid == uid && p.year == year select p).CopyToDataTable();

                foreach (DataRow dr in dt.Rows)
                {
                    int num = Int32.Parse(dr[3].ToString());
                    var price = (from p in mf.DS.Paper.AsEnumerable() where p.year == year && p.paperid == dr[2].ToString() select new { pr = p.price - p.subsidy }).SingleOrDefault();
                    totalmoney += price.pr * num;
                }
                return totalmoney;
            }
            else//查计划单位
            {
                //需判断是否有计划金额
                List<string> u = (from p in mf.DS.UnitMoneyTask.AsEnumerable() where p.unitid == uid && p.year == year select p.unitid).ToList();
                if (u.Count > 0)
                {
                    totalmoney = (from p in mf.DS.UnitMoneyTask.AsEnumerable() where p.unitid == uid && p.year == year select p.totalprices).SingleOrDefault();
                }

            }
            return totalmoney;
        }

        //查询企业任务金额。
        private double SelectUnitCompyMoney(string uid)
        {
            year = tscombYear.SelectedItem.ToString().Trim();
            double Compymoney = 0;
            //需要判断单位是否有计划企业任务；
            var q = (from p in mf.DS.UnitMoneyTask.AsEnumerable() where p.unitid == uid && p.year == year select p.totalprices);
            foreach (var i in q)
            {
                Compymoney = i;
            }
            return Compymoney;
        }
        private void tscombYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReLoadListViewUnitTaskMoney();
        }

        private void tsTxtSearch_TextChanged(object sender, EventArgs e)
        {
            //    listViewUnitPlantMoney.Items.Clear();
            //    string upper = tsTxtSearch.Text.ToUpper();
            //    mf.configbk.TownTotalMoney = mf.configbk.UnitToalMoney = 0;
            //    labTownM.Text = labXianXM.Text = "";
            //    string year = tscombYear.SelectedItem.ToString().Trim();
            //    listViewUnitPlantMoney.Items.Clear();
            //    var q = from p in mf.DS.UnitTaskMoney.AsEnumerable()
            //            from u in mf.DS.Unit.AsEnumerable()
            //            where p.unitid == u.unitid && u.Istake == "是" && p.year == year
            //            select new
            //            {
            //                id = p.id,
            //                unit = u.shortname,
            //                pMoney = p.plantprices,
            //                pQy = p.compprices,
            //                pT = p.totallprices,
            //                kind = u.kind

            //            };
            //    foreach (var i in q)
            //    {
            //        string namecode = PinYin.GetCodstring(i.unit);
            //        if (namecode.StartsWith(upper))
            //        {
            //            if (i.kind == "镇")
            //            {
            //                mf.configbk.TownTotalMoney += i.pT;

            //            }
            //            else
            //            {
            //                mf.configbk.UnitToalMoney += i.pT;
            //            }
            //            ListViewItem lv = new ListViewItem(new string[] { i.unit, i.pMoney.ToString(), i.pQy.ToString(), i.pT.ToString() });
            //            lv.Tag = i.id;
            //            listViewUnitPlantMoney.Items.Add(lv);
            //        }
            //    }
            //    labTownM.Text = mf.configbk.TownTotalMoney.ToString();
            //    labXianXM.Text = mf.configbk.UnitToalMoney.ToString();


        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            string unitid = "130223z010";
            CalcUnitTotalMoney(unitid);
        }
    }
}

