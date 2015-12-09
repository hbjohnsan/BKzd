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
    public partial class EditNewTask : DockContent
    {
        private MainFrm mf;
        public EditNewTask()
        {
            InitializeComponent();
        }

        public EditNewTask(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        private void EditNewTask_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mf.DS.PaperTask;
        }

        //填充
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            //先要循环gridview
            for (int f = 0; f < dataGridView1.Rows.Count - 1; f++)
            {
                //MessageBox.Show(dataGridView1.Rows[f].Cells[1].Value.ToString().Trim());

                //var q = from p in mf.DS.UnitPaperTask.AsEnumerable()

                //        select p;
                ////用单位任务表填充gridview               
                //foreach (var i in q)
                //{
                //    //判断
                //    #region 判断


                //    if (i.unitid == dataGridView1.Rows[f].Cells[1].Value.ToString().Trim() && i.year == dataGridView1.Rows[f].Cells["Year"].Value.ToString())
                //    {
                //        #region 第一种填充方法

                //        switch (i.paperid)
                //        {
                //            case "101":
                //                dataGridView1.Rows[f].Cells[2].Value = i.plantnum;
                //                break;
                //            case "102":
                //                dataGridView1.Rows[f].Cells[3].Value = i.plantnum;
                //                break;
                //            case "103":
                //                dataGridView1.Rows[f].Cells[4].Value = i.plantnum;
                //                break;
                //            case "104":
                //                dataGridView1.Rows[f].Cells[5].Value = i.plantnum;
                //                break;
                //            case "105":
                //                dataGridView1.Rows[f].Cells[6].Value = i.plantnum;
                //                break;
                //            case "201":
                //                dataGridView1.Rows[f].Cells[7].Value = i.plantnum;
                //                break;
                //            case "202":
                //                dataGridView1.Rows[f].Cells[8].Value = i.plantnum;
                //                break;
                //            case "203":
                //                dataGridView1.Rows[f].Cells[9].Value = i.plantnum;
                //                break;
                //            case "301":
                //                dataGridView1.Rows[f].Cells[10].Value = i.plantnum;
                //                break;
                //            case "302":
                //                dataGridView1.Rows[f].Cells[11].Value = i.plantnum;
                //                break;

                //            default:

                //                break;
                //        }

                //        #endregion


                //        #region 第二种方法
                //        //MessageBox.Show("对了");
                //        //因为有303，106的数据。无法实现第个方法了。
                //        //if (i.paperid == dataGridView1.Rows[f].Cells[i.paperid].Value)
                //        //{
                //        //    dataGridView1.Rows[f].Cells[i.paperid].Value = i.plantnum;
                //        //}
                //        #endregion
                //    }
                //    #endregion
                //}



            }


        }
        //直接到库
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //var q = from p in mf.DS.PaperTask.AsEnumerable()
            //        select p;
            //for (int i = 0; i < mf.DS.PaperTask.Rows.Count; i++)
            //{
            //    foreach (var f in q)
            //    {
            //        if (f.unitid == mf.DS.PaperTask.Rows[i][1].ToString() && f.year == mf.DS.PaperTask.Rows[i]["Year"].ToString())
            //        {
            //            switch (f.paperid)
            //            {
            //                case "101":
            //                    mf.DS.PaperTask.Rows[i]["101"] = f.plantnum;
            //                    break;
            //                case "102":
            //                    mf.DS.PaperTask.Rows[i]["102"] = f.plantnum;
            //                    break;
            //                case "103":
            //                    mf.DS.PaperTask.Rows[i]["103"] = f.plantnum;
            //                    break;
            //                case "104":
            //                    mf.DS.PaperTask.Rows[i]["104"] = f.plantnum;
            //                    break;
            //                case "105":
            //                    mf.DS.PaperTask.Rows[i]["105"] = f.plantnum;
            //                    break;
            //                case "201":
            //                    mf.DS.PaperTask.Rows[i]["201"] = f.plantnum;
            //                    break;
            //                case "202":
            //                    mf.DS.PaperTask.Rows[i]["202"] = f.plantnum;
            //                    break;
            //                case "203":
            //                    mf.DS.PaperTask.Rows[i]["203"] = f.plantnum;
            //                    break;
            //                case "301":
            //                    mf.DS.PaperTask.Rows[i]["301"] = f.plantnum;
            //                    break;
            //                case "302":
            //                    mf.DS.PaperTask.Rows[i]["302"] = f.plantnum;
            //                    break;

            //                default:
            //                    break;
            //            }
            //        }
            //    }
            //}

            //mf.paperTaskTap.Update(mf.DS.PaperTask);
            //mf.DS.PaperTask.Dispose();
            //mf.paperTaskTap.Fill(mf.DS.PaperTask);

        }
        //更新镇及金额
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //var q = from p in mf.DS.UnitMoneyTask.AsEnumerable()
            //        select p;
            //for (int i = 0; i < mf.DS.PaperTask.Rows.Count; i++)
            //{
            //    foreach (var f in q)
            //    {
            //        if (f.unitid == mf.DS.PaperTask.Rows[i][1].ToString() && f.year == mf.DS.PaperTask.Rows[i]["Year"].ToString())
            //        {
            //            mf.DS.PaperTask.Rows[i]["BaseMoney"] = f.baseMoney;
            //            mf.DS.PaperTask.Rows[i]["ComnyMoney"] = f.ComnyMoney;
            //            mf.DS.PaperTask.Rows[i]["TotalMoney"] = f.ComnyMoney;
            //        }
            //    }

            //}
            //mf.paperTaskTap.Update(mf.DS.PaperTask);
            //mf.DS.PaperTask.Dispose();
            //mf.paperTaskTap.Fill(mf.DS.PaperTask);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //var q = from p in mf.DS.Paper.AsEnumerable()
            //        select p;

            //for (int i = 0; i < mf.DS.PaperTask.Rows.Count; i++)
            //{
            //    double tol = 0;
            //    #region 循环


            //    foreach (var f in q)
            //    {
            //        if (mf.DS.PaperTask.Rows[i]["Year"].ToString() == f.year)
            //        {
            //            switch (f.paperid)
            //            {
            //                case "101":
            //                    if (mf.DS.PaperTask.Rows[i]["101"] != DBNull.Value)
            //                    {
            //                        tol += (f.price - f.subsidy) * Convert.ToInt32(mf.DS.PaperTask.Rows[i]["101"].ToString());
            //                    }

            //                    break;
            //                case "102":
            //                    if (mf.DS.PaperTask.Rows[i]["102"] != DBNull.Value)
            //                    {
            //                        tol += (f.price - f.subsidy) * Convert.ToInt32(mf.DS.PaperTask.Rows[i]["102"].ToString());
            //                    }
            //                    break;
            //                case "103":
            //                    if (mf.DS.PaperTask.Rows[i]["103"] != DBNull.Value)
            //                    {
            //                        tol += (f.price - f.subsidy) * Convert.ToInt32(mf.DS.PaperTask.Rows[i]["103"].ToString());
            //                    }
            //                    break;
            //                case "104":
            //                    if (mf.DS.PaperTask.Rows[i]["104"] != DBNull.Value)
            //                    {
            //                        tol += (f.price - f.subsidy) * Convert.ToInt32(mf.DS.PaperTask.Rows[i]["104"].ToString());
            //                    }
            //                    break;
            //                case "105":
            //                    if (mf.DS.PaperTask.Rows[i]["105"] != DBNull.Value)
            //                    {
            //                        tol += (f.price - f.subsidy) * Convert.ToInt32(mf.DS.PaperTask.Rows[i]["105"].ToString());
            //                    }
            //                    break;

            //                case "201":
            //                    if (mf.DS.PaperTask.Rows[i]["201"] != DBNull.Value)
            //                    {
            //                        tol += (f.price - f.subsidy) * Convert.ToInt32(mf.DS.PaperTask.Rows[i]["201"].ToString());
            //                    }
            //                    break;
            //                case "202":
            //                    if (mf.DS.PaperTask.Rows[i]["202"] != DBNull.Value)
            //                    {
            //                        tol += (f.price - f.subsidy) * Convert.ToInt32(mf.DS.PaperTask.Rows[i]["202"].ToString());
            //                    }

            //                    break;
            //                case "203":
            //                    if (mf.DS.PaperTask.Rows[i]["203"] != DBNull.Value)
            //                    {
            //                        tol += (f.price - f.subsidy) * Convert.ToInt32(mf.DS.PaperTask.Rows[i]["203"].ToString());
            //                    }
            //                    break;
            //                case "301":
            //                    if (mf.DS.PaperTask.Rows[i]["301"] != DBNull.Value)
            //                    {
            //                        tol += (f.price - f.subsidy) * Convert.ToInt32(mf.DS.PaperTask.Rows[i]["301"].ToString());
            //                    }
            //                    break;
            //                case "302":
            //                    if (mf.DS.PaperTask.Rows[i]["302"] != DBNull.Value)
            //                    {
            //                        tol += (f.price - f.subsidy) * Convert.ToInt32(mf.DS.PaperTask.Rows[i]["302"].ToString());
            //                    }
            //                    break;
            //                default:
            //                    break;
            //            }
            //        }
            //    }
            //    #endregion

            //    if (mf.DS.PaperTask.Rows[i]["ComnyMoney"] != DBNull.Value)
            //    {
            //        mf.DS.PaperTask.Rows[i]["TotalMoney"] = tol + Convert.ToDouble(mf.DS.PaperTask.Rows[i]["ComnyMoney"].ToString());
            //    }
            //    else if (mf.DS.PaperTask.Rows[i]["BaseMoney"] != DBNull.Value)
            //    {

            //        mf.DS.PaperTask.Rows[i]["TotalMoney"] = tol + Convert.ToDouble(mf.DS.PaperTask.Rows[i]["BaseMoney"].ToString());
            //    }
            //    else
            //    {
            //        mf.DS.PaperTask.Rows[i]["TotalMoney"] = tol;
            //    }


            //}  //
            //mf.paperTaskTap.Update(mf.DS.PaperTask);
            //mf.DS.PaperTask.Dispose();
            //mf.paperTaskTap.Fill(mf.DS.PaperTask);
        }
        //变Null为0
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mf.DS.PaperTask.Rows.Count; i++)
            {
                for (int j = 0; j < mf.DS.PaperTask.Columns.Count; j++)
                {
                    if (mf.DS.PaperTask.Rows[i][j] == DBNull.Value)
                    {
                        mf.DS.PaperTask.Rows[i][j] = 0;
                    }
                }
            }

            mf.paperTaskTap.Update(mf.DS.PaperTask);
            mf.DS.PaperTask.Dispose();
            mf.paperTaskTap.Fill(mf.DS.PaperTask);

        }


    }
}

