using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Configuration;
using System.Data.Common;
using System.Data.SQLite;

namespace DBzd
{
    public partial class TaskFrm : DockContent
    {
        private MainFrm mf;
        public TaskFrm()
        {
            InitializeComponent();
        }
        public TaskFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }


        private void UnitTaskFrm_Load(object sender, EventArgs e)
        {
            //增加年度列表
            AddToolYear();
            AddToolNewYear();
            //显示有任务的单位列表
            ShowUnitTask();
            //显示总任务数量及分配后各娄报刊剩余数量
            ShowHasNum();

        }


        //显示有任务的单位列表
        private void ShowUnitTask()
        {
            listViewUnit.Items.Clear();
            var q = from p in mf.DS.Unit.AsEnumerable()
                    where p.Istake == "是"
                    select p;
            foreach (var i in q)
            {

                ListViewItem lvi = new ListViewItem(new string[] { "", i.ShortName });
                lvi.Tag = i.UnitID;
                listViewUnit.Items.Add(lvi);
            }
            //显示序号
            for (int i = 0; i < listViewUnit.Items.Count; i++)
            {
                listViewUnit.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }


        /// <summary>
        /// 增加年度
        /// </summary>
        private void AddToolYear()
        {
            #region 年度下拉列表
            tscombYear.Items.Clear();
            var q = from p in mf.DS.PaperTask.AsEnumerable()
                    orderby p.Year descending
                    select p.Year;
            foreach (var y in q.Distinct())
            {
                tscombYear.Items.Add(y);
            }
            tscombYear.SelectedIndex = 0;
            #endregion
        }




        #region 工具栏
        //删除
        private void tsbtnSub_Click(object sender, EventArgs e)
        {
            if (listViewUnit.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("确认删除？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //todo:删除
                }
            }
            else
            {
                MessageBox.Show("请选择单位");
                return;
            }
        }
        //编辑
        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            if (listViewUnit.SelectedItems.Count > 0)
            {
                //todo:修改
            }
            else
            {
                MessageBox.Show("请选择单位");
                return;
            }
        }
        //搜索工具栏
        private void tsbTxtSearch_TextChanged(object sender, EventArgs e)
        {
            string upper = tsbTxtSearch.Text.ToUpper();
            listViewUnit.Items.Clear();
            var q = from p in mf.DS.Unit.AsEnumerable()
                    where p.Istake == "是"
                    select p;
            foreach (var i in q)
            {
                string namecode = PinYin.GetCodstring(i.ShortName);
                if (namecode.StartsWith(upper))
                {
                    ListViewItem lvi = new ListViewItem(new string[] { "", i.ShortName });
                    lvi.Tag = i.UnitID;
                    listViewUnit.Items.Add(lvi);
                }
            }


            //显示序号
            for (int i = 0; i < listViewUnit.Items.Count; i++)
            {
                listViewUnit.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }
        //年度下拉列表
        private void tscombYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHasNum();
            ShowMoney();
        }
        //指增加新年度
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //判断新增的年度是否已经存在
            if (HasYear())
            {
                MessageBox.Show("该年度分配给各单位的任务已经存在！");
                return;
            }
            else
            {

                #region 解决方法三采用事务处理

                string oldYear = tscombYear.SelectedItem.ToString();
                string newYear = tscombNewYear.SelectedItem.ToString();
                string datasource = ConfigurationManager.ConnectionStrings["DBzd.Properties.Settings.baokanConnectionString"].ConnectionString.ToString();
                var qUnitTask = from p in mf.DS.PaperTask.AsEnumerable() where p.Year == oldYear select p;

                //加入了详细的任务列表
                using (SQLiteConnection conn = new SQLiteConnection(datasource))
                {
                    conn.Open();
                    using (System.Data.SQLite.SQLiteTransaction trans = conn.BeginTransaction())
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.Transaction = trans;
                            try
                            {
                                foreach (var i in qUnitTask)
                                {
                                    cmd.CommandText = @"INSERT INTO PaperTask(UnitId,P101,P102,P103,P104,P105,P201,P202,P203,P301,P302,ComnyMoney,BaseMoney,TotalMoney,Year) VALUES('" + i.UnitId + "','" + i.P101 + "','"
                                        + i.P102 + "','" + i.P103 + "','" + i.P104 + "','" + i.P105 + "','" + i.P201 + "','" + i.P202 + "','"
                                        + i.P203 + "','" + i.P301 + "','" + i.P302 + "','" + i.ComnyMoney + "','" + i.BaseMoney + "','" + i.TotalMoney + "','" + newYear + "')";
                                    cmd.ExecuteNonQuery();
                                }

                                trans.Commit();
                                MessageBox.Show(newYear + "年度单位报刊任务数添加成功！");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                trans.Rollback();

                            }
                        }
                    }
                }




                #endregion

                mf.DS.PaperTask.Dispose();

                mf.paperTaskTap.Fill(mf.DS.PaperTask);


                AddToolYear();
            }
        }

        //删除新增的年度
        private void toolStripLab_Del_Click(object sender, EventArgs e)
        {
            string newYear = tscombNewYear.SelectedItem.ToString();
            string CommandText1 = "DELETE FROM PaperTask where year=@year";
            SQLiteParameter[] paras = new SQLiteParameter[]{
                new SQLiteParameter("@year",newYear)

            };
            //使用SQLiteHelper
            SQLiteHelper.TransExecuteNonQuery(mf.DS.PaperTask, CommandText1, paras);
            MessageBox.Show(newYear + "年度报刊数量任务已经删除！");


            mf.DS.PaperTask.Dispose();
            mf.paperTaskTap.Fill(mf.DS.PaperTask);

            AddToolYear();
        }
        #endregion

        //单击单位列表时
        private void listViewUnit_Click(object sender, EventArgs e)
        {
            if (listViewUnit.SelectedItems.Count > 0)
            {
                listViewUnit.SelectedItems[0].BackColor = Color.Red;
                #region 显示报刊数量
                string unitid = listViewUnit.SelectedItems[0].Tag.ToString();
                string year = tscombYear.SelectedItem.ToString().Trim();
                //判断该单位是不是已经分配了任务，如果是从复制上年度的规则中分配的，那么就显示如下，如果不是，那么所有报刊数据应为0
                if (mf.DS.PaperTask.Select("Year='" + year + "' and UnitID='" + unitid + "'").Count() > 0)
                {
                    BKDataSet.PaperTaskRow pr = (from p in mf.DS.PaperTask.AsEnumerable() where p.Year == year && p.UnitId == unitid select p).SingleOrDefault();
                    labUnitID.Text = unitid;
                    labUnit.Text = mf.DS.Unit.FindByUnitID(unitid).ShortName;
                    nUD101.Value = pr.P101;
                    nUD102.Value = pr.P102;
                    nUD103.Value = pr.P103;
                    nUD104.Value = pr.P104;
                    nUD105.Value = pr.P105;
                    nUD201.Value = pr.P201;
                    nUD202.Value = pr.P202;
                    nUD203.Value = pr.P203;
                    nUD301.Value = pr.P301;
                    nUD302.Value = pr.P302;
                    txtComnyMoney.Text = pr.ComnyMoney.ToString();
                    txtPaperMoney.Text = pr.BaseMoney.ToString();
                    labTotalMoney.Text = pr.TotalMoney.ToString();
                }
                else
                {
                    labUnitID.Text = unitid;
                    labUnit.Text = mf.DS.Unit.FindByUnitID(unitid).ShortName;
                    nUD101.Value = nUD102.Value = nUD103.Value = nUD104.Value = nUD105.Value = nUD201.Value = nUD202.Value = nUD203.Value = nUD301.Value = nUD302.Value = 0;
                    txtComnyMoney.Text = txtPaperMoney.Text = labTotalMoney.Text = "0";
                }


                #endregion


            }
        }

        //显示总任务数量及分配后各娄报刊剩余数量
        private void ShowHasNum()
        {
            listViewTask.Items.Clear();
            var q = from p in mf.DS.Paper.AsEnumerable()
                    where p.Year == tscombYear.SelectedItem.ToString().Trim() && p.IsDanKan == "是"
                    orderby p.PaperID ascending
                    select p;

            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { "", i.PaperID, i.Name, i.Number.ToString(), "", "" });
                lv.Tag = i.PaperID;
                listViewTask.Items.Add(lv);

            }
            //显示行号
            for (int i = 0; i < listViewTask.Items.Count; i++)
            {
                listViewTask.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
            //根据id查出分配任务表中所以本年度为报刊paper表的总数

            for (int i = 0; i < listViewTask.Items.Count; i++)
            {
                double num = 0;
                switch (listViewTask.Items[i].SubItems[1].Text)
                {
                    case "101":
                        num = (from p in mf.DS.PaperTask.AsEnumerable() select p.P101).Sum();
                        listViewTask.Items[i].SubItems[4].Text = num.ToString();
                        listViewTask.Items[i].SubItems[5].Text = (Convert.ToDouble(listViewTask.Items[i].SubItems[3].Text.Trim()) - num).ToString();
                        break;

                    case "102":
                        num = (from p in mf.DS.PaperTask.AsEnumerable() select p.P102).Sum();
                        listViewTask.Items[i].SubItems[4].Text = num.ToString();
                        listViewTask.Items[i].SubItems[5].Text = (Convert.ToDouble(listViewTask.Items[i].SubItems[3].Text.Trim()) - num).ToString();
                        break;
                    case "103":
                        num = (from p in mf.DS.PaperTask.AsEnumerable() select p.P103).Sum();
                        listViewTask.Items[i].SubItems[4].Text = num.ToString();
                        listViewTask.Items[i].SubItems[5].Text = (Convert.ToDouble(listViewTask.Items[i].SubItems[3].Text.Trim()) - num).ToString();
                        break;
                    case "104":
                        num = (from p in mf.DS.PaperTask.AsEnumerable() select p.P104).Sum();
                        listViewTask.Items[i].SubItems[4].Text = num.ToString();
                        listViewTask.Items[i].SubItems[5].Text = (Convert.ToDouble(listViewTask.Items[i].SubItems[3].Text.Trim()) - num).ToString();
                        break;
                    case "105":
                        num = (from p in mf.DS.PaperTask.AsEnumerable() select p.P105).Sum();
                        listViewTask.Items[i].SubItems[4].Text = num.ToString();
                        listViewTask.Items[i].SubItems[5].Text = (Convert.ToDouble(listViewTask.Items[i].SubItems[3].Text.Trim()) - num).ToString();
                        break;
                    case "201":
                        num = (from p in mf.DS.PaperTask.AsEnumerable() select p.P201).Sum();
                        listViewTask.Items[i].SubItems[4].Text = num.ToString();
                        listViewTask.Items[i].SubItems[5].Text = (Convert.ToDouble(listViewTask.Items[i].SubItems[3].Text.Trim()) - num).ToString();
                        break;
                    case "202":
                        num = (from p in mf.DS.PaperTask.AsEnumerable() select p.P202).Sum();
                        listViewTask.Items[i].SubItems[4].Text = num.ToString();
                        listViewTask.Items[i].SubItems[5].Text = (Convert.ToDouble(listViewTask.Items[i].SubItems[3].Text.Trim()) - num).ToString();
                        break;
                    case "203":
                        num = (from p in mf.DS.PaperTask.AsEnumerable() select p.P203).Sum();
                        listViewTask.Items[i].SubItems[4].Text = num.ToString();
                        listViewTask.Items[i].SubItems[5].Text = (Convert.ToDouble(listViewTask.Items[i].SubItems[3].Text.Trim()) - num).ToString();
                        break;
                    case "301":
                        num = (from p in mf.DS.PaperTask.AsEnumerable() select p.P301).Sum();
                        listViewTask.Items[i].SubItems[4].Text = num.ToString();
                        listViewTask.Items[i].SubItems[5].Text = (Convert.ToDouble(listViewTask.Items[i].SubItems[3].Text.Trim()) - num).ToString();
                        break;
                    case "302":
                        num = (from p in mf.DS.PaperTask.AsEnumerable() select p.P302).Sum();
                        listViewTask.Items[i].SubItems[4].Text = num.ToString();
                        listViewTask.Items[i].SubItems[5].Text = (Convert.ToDouble(listViewTask.Items[i].SubItems[3].Text.Trim()) - num).ToString();
                        break;

                    default:
                        break;
                }


            }


        }

        //计算各类总金额的总额。
        private void ShowMoney()
        {
            //double UpMoney, BuTeiMoney, HasHareMoney, ComnyMoney;
            //UpMoney = BuTeiMoney = HasHareMoney = ComnyMoney = 0;
            //for (int i = 0; i < listViewTask.Items.Count; i++)
            //{
            //    var q = from p in mf.DS.Paper.AsEnumerable()
            //            where p.year == tscombYear.SelectedItem.ToString()
            //            select p;
            //    foreach (var item in q)
            //    {
            //        UpMoney += item.totalPrice;
            //        BuTeiMoney += item.totalSubsidy;
            //        HasHareMoney += item.price * Convert.ToDouble(listViewTask.Items[i].SubItems[4].Text);

            //    }

            //}
            ////上级给的总任务钱数
            //labUpMoney.Text = UpMoney.ToString();
            ////本级补贴的钱数
            //labBuTeiMoney.Text = BuTeiMoney.ToString();
            ////已经分配了的钱数
            //labHasShareMoney.Text = HasHareMoney.ToString();
            ////计算分配给企业任务的金额总数
            //var qw = from p in mf.DS.UnitMoneyTask
            //         where p.year == tscombYear.SelectedItem.ToString()
            //         select p;
            //foreach (var i in qw)
            //{
            //  ComnyMoney +=  i.totalMoney;
            //}
            //labComnyMoeny.Text = ComnyMoney.ToString();
            ////差值
            //labCaE.Text = (HasHareMoney + BuTeiMoney + ComnyMoney - UpMoney).ToString();
        }




        #region 功能
        //批量新增各单位年度任务是否已经存在“该新年度”
        private bool HasYear()
        {
            bool f = true;
            var q = (from p in mf.DS.PaperTask.AsEnumerable() where p.Year == tscombNewYear.SelectedItem.ToString() select p.Year).ToList();
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

        //增加新年度列表
        private void AddToolNewYear()
        {
            for (int i = 2000; i < 2101; i++)
            {
                tscombNewYear.Items.Add(i.ToString());
            }
            tscombNewYear.SelectedItem = (Convert.ToInt32(tscombYear.SelectedItem) + 1).ToString();
        }
        #endregion

        //todo:编辑
        private void btnEditTask_Click(object sender, EventArgs e)
        {
            string unitid = listViewUnit.SelectedItems[0].Tag.ToString();
            string year = tscombYear.SelectedItem.ToString().Trim();
            if (mf.DS.PaperTask.Select("Year='" + year + "' and UnitID='" + unitid + "'").Count() > 0)
            {
                BKDataSet.PaperTaskRow pr = (from p in mf.DS.PaperTask.AsEnumerable() where p.Year == year && p.UnitId == labUnitID.Text select p).SingleOrDefault();
                pr.P101 = Convert.ToInt32(nUD101.Value);
                pr.P102 = Convert.ToInt32(nUD102.Value);
                pr.P103 = Convert.ToInt32(nUD103.Value);
                pr.P104 = Convert.ToInt32(nUD104.Value);
                pr.P105 = Convert.ToInt32(nUD105.Value);
                pr.P201 = Convert.ToInt32(nUD201.Value);
                pr.P202 = Convert.ToInt32(nUD202.Value);
                pr.P203 = Convert.ToInt32(nUD203.Value);
                pr.P301 = Convert.ToInt32(nUD301.Value);
                pr.P302 = Convert.ToInt32(nUD302.Value);
                pr.ComnyMoney = Convert.ToDouble(txtComnyMoney.Text.Trim());
                pr.BaseMoney = Convert.ToDouble(txtPaperMoney.Text);
                pr.TotalMoney = Convert.ToDouble(labTotalMoney.Text);
                mf.paperTaskTap.Update(pr);
                //mf.DS.Paper.Dispose();
                //mf.paperTap.Fill(mf.DS.Paper);
            }
            else//新增单位任务
            {

                mf.DS.PaperTask.AddPaperTaskRow(unitid, Convert.ToInt32(nUD101.Value), Convert.ToInt32(nUD102.Value),
                    Convert.ToInt32(nUD103.Value),
                    Convert.ToInt32(nUD104.Value),
                    Convert.ToInt32(nUD105.Value),
                    Convert.ToInt32(nUD201.Value),
                    Convert.ToInt32(nUD202.Value),
                    Convert.ToInt32(nUD203.Value),
                    Convert.ToInt32(nUD301.Value),
                    Convert.ToInt32(nUD302.Value),
                    Convert.ToDouble(txtComnyMoney.Text.Trim()),
                    Convert.ToDouble(txtPaperMoney.Text),
                    Convert.ToDouble(labTotalMoney.Text), year);
                mf.paperTaskTap.Update(mf.DS.PaperTask);
                //mf.DS.Paper.Dispose();
                //mf.paperTap.Fill(mf.DS.Paper);
            }


        }
        //报刊数量变化计算总额
        private void ValueChanged(object sender, EventArgs e)
        {
            double tol = 0;
            //string unitid = listViewUnit.SelectedItems[0].Tag.ToString();
            //string year = tscombYear.SelectedItem.ToString().Trim();
            //BKDataSet.PaperTaskRow pr = (from p in mf.DS.PaperTask.AsEnumerable() where p.Year == year && p.UnitId == unitid select p).SingleOrDefault();
            //NumericUpDown nud = sender as NumericUpDown;
            //string pid = nud.Name.Substring(3, 3);
            var q = from p in mf.DS.Paper.AsEnumerable()
                    where p.Year == tscombYear.SelectedItem.ToString().Trim()//&& p.PaperID==pid
                    select p;

            #region 循环
            foreach (var f in q)
            {
                switch (f.PaperID)
                {
                    case "101":

                        tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD101.Value);

                        break;
                    case "102":

                        tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD102.Value);

                        break;
                    case "103":

                        tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD103.Value);

                        break;
                    case "104":

                        tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD104.Value);

                        break;
                    case "105":

                        tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD105.Value);

                        break;

                    case "201":

                        tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD201.Value);

                        break;
                    case "202":

                        tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD202.Value);

                        break;
                    case "203":

                        tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD203.Value);

                        break;
                    case "301":

                        tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD301.Value);

                        break;
                    case "302":

                        tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD302.Value);

                        break;

                }
            }
            #endregion

            txtPaperMoney.Text = tol.ToString();
            labTotalMoney.Text = (tol + Convert.ToDouble(txtComnyMoney.Text)).ToString("0.0");

        }

        private void txtComnyMoney_TextChanged(object sender, EventArgs e)
        {
            labTotalMoney.Text = (Convert.ToDouble(txtPaperMoney.Text) + Convert.ToDouble(txtComnyMoney.Text)).ToString("0.0");
        }

        private void txtPaperMoney_TextChanged(object sender, EventArgs e)
        {
            labTotalMoney.Text = (Convert.ToDouble(txtPaperMoney.Text) + Convert.ToDouble(txtComnyMoney.Text)).ToString("0.0");
        }



    }
}
