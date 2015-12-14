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
    public partial class ReceivablesFrm : DockContent
    {
        private MainFrm mf;
        public ReceivablesFrm()
        {
            InitializeComponent();
        }
        public ReceivablesFrm(MainFrm f)
        {
            InitializeComponent();
            mf = f;
        }

        #region 窗体加载
        //窗体加载
        private void ReceivablesFrm_Load(object sender, EventArgs e)
        {
            //隐藏修改按键
            btnEidtUP.Hide();
            //加载年度
            LoadYear();
            //加载单位类别
            LoadUnitKind();
            //交款单位 通过单位类别已经加载了 类别个数次了！！！初始为1次。
            //  PayUnit();
            CalcHasPayUnit();
        }
        //交款单位
        private void PayUnit()
        {
            var q = from u in mf.DS.Unit.AsEnumerable()
                    where u.IsPay == "是"
                    select u;
            foreach (var i in q)
            {
                Unit u = new Unit();
                u.UnitID = i.UnitID;
                u.ShortName = i.ShortName;
                combJKDW.Items.Add(u);
            }
            combJKDW.DisplayMember = "ShortName";
            combJKDW.SelectedIndex = 0;


        }
        //加载单位类别
        private void LoadUnitKind()
        {
            toolStripComboBox3.Items.Clear();
            var q1 = from k in mf.DS.Unit
                     orderby k.Kind descending
                     group k by k.Kind into g
                     select new
                     {
                         kind = g.Key,
                         g
                     };
            foreach (var i in q1)
            {
                toolStripComboBox3.Items.Add(i.kind);

            }


        }
        //加载年度
        private void LoadYear()
        {
            toolStripComboBox1.Items.Clear();
            var q = from p in mf.DS.PaperTask
                    orderby p.Year descending
                    group p by p.Year into g
                    select new
                    {
                        year = g.Key,
                        g
                    };

            foreach (var it in q)
            {
                toolStripComboBox1.Items.Add(it.year);
            }
            toolStripComboBox1.SelectedIndex = 0;
        }

        #endregion


        #region 工具栏
        //选择单位类别变化时
        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            combJKDW.Items.Clear();
            var q = from p in mf.DS.PaperTask.AsEnumerable()
                    from u in mf.DS.Unit.AsEnumerable()
                    where u.IsPay == "是" && p.Year == toolStripComboBox1.SelectedItem.ToString() && p.UnitId == u.UnitID && u.Kind == toolStripComboBox3.SelectedItem.ToString()
                    select new
                    {
                        UID = p.UnitId,
                        Name = u.ShortName
                    };
            foreach (var i in q)
            {
                Unit u = new Unit();
                u.UnitID = i.UID;
                u.ShortName = i.Name;
                combJKDW.Items.Add(u);
            }
            combJKDW.DisplayMember = "ShortName";
            combJKDW.SelectedIndex = 0;

        }
        //搜索单位
        private void tsTxtSearch_TextChanged(object sender, EventArgs e)
        {
            combJKDW.Items.Clear();
            string upper = tsTxtSearch.Text.ToUpper();
            var q = from u in mf.DS.Unit.AsEnumerable()
                    where u.IsPay == "是"
                    select u;
            foreach (var i in q)
            {
                string namecode = PinYin.GetCodstring(i.ShortName);
                //  if (namecode.Contains(upper))
                if (namecode.StartsWith(upper))
                {
                    Unit u = new Unit();
                    u.UnitID = i.UnitID;
                    u.ShortName = i.ShortName;
                    combJKDW.Items.Add(u);
                }
            }
            combJKDW.DisplayMember = "ShortName";
            combJKDW.SelectedIndex = 0;

        }
        //选择年度变化时
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PayUnit();
        }

        #endregion

        #region 窗体按键

        //实际收款总额变动时，自动人民币大写
        private void txtTruePrice_TextChanged(object sender, EventArgs e)
        {
            //手动输入时要决断为数字
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTruePrice.Text, @"^([0-9]*)\.?[0-9]*$"))
            {
                MessageBox.Show("请输入正确的金额！");
                return;
            }

            labRMB.Text = "人民币(大写):";
            labRMB.Text += RMBCapitalization.RMBAmount(double.Parse(txtTruePrice.Text));



        }

        //选择单位变化时
        private void combJKDW_SelectedIndexChanged(object sender, EventArgs e)
        {
            Unit u = combJKDW.SelectedItem as Unit;
            string unitID = u.UnitID;
            string year = toolStripComboBox1.SelectedItem.ToString();
            //如果该单位的交款状态为已经完成，那么相关按键需要禁止。否则应开启
            var q = from p in mf.DS.PaperTask.AsEnumerable()
                    where p.Year == year && p.UnitId == unitID
                    select p;
            foreach (var i in q)
            {
                txtBaseMoeny.Text = i.BaseMoney.ToString();
                txtCompMoney.Text = i.ComnyMoney.ToString();
                txtTotalMoney.Text = i.TotalMoney.ToString();
                //真实总金额等于初加裁总额
                txtTruePrice.Text = txtTotalMoney.Text;
            }

            /*
             * 三种情况：
             * 1、一次交清的。
             * 2、只交一部分的
             * 3、打欠条算一次交清的。
             * 4、分多次交款的。
             * 5、加载实际任务数。且修改金额时，记录值数据唯一。库中没有记录时，新境，有时修改任务数。
             */
            //判断该单位是否已经完成了任务 IsOver='是' and 这个不有加了，因为有只交一部分的人

            if (mf.DS.Receivables.Select("IsOver='是' and Year='" + year + "' and UnitID='" + unitID + "'").Count() > 0)
            {
                //显示已经完成
                rabYes.Checked = true;
                btnSave.Enabled = txtTruePrice.Enabled = dateTimePicker1.Enabled = false;
                //从交款记录任务表中提取
                LoadHasPay();
                //加载真实任务数

            }
            if (mf.DS.Receivables.Select("Year='" + year + "' and UnitID='" + unitID + "'").Count() > 0)
            {
                //从交款记录任务表中提取
                LoadHasPay();

                //未完成状态
                rabNo.Checked = true;

                btnSave.Enabled = txtTruePrice.Enabled = dateTimePicker1.Enabled = true;
                btnEidtUP.Visible = false;
                txtbz.Text = "";


            }
            else
            {

                //未交款单位
                radNOJiao.Checked = true;
                //未完成状态
                rabNo.Checked = true;

                btnSave.Enabled = txtTruePrice.Enabled = dateTimePicker1.Enabled = true;
                btnEidtUP.Visible = false;
                txtbz.Text = "";
                //已交款总额清0
                labhasTotal.Text = "0";
                //清空交款记录
                listView1.Items.Clear();
                //根据单位ID，自动加载单位分配的任务数量
                LoadPaperTask();
            }


            //TotalHasPayMoney();
            //显示计算总额
            CalcHasPayUnit();
            //从交款记录任务表中提取实际刊数
            LoadHasPayTask();

        }


        //从交款记录任务表中提取
        private void LoadHasPayTask()
        {
            Unit u = combJKDW.SelectedItem as Unit;
            //加载真实金额
            var m = from p in mf.DS.Receivables.AsEnumerable()
                    where p.UnitID == u.UnitID && p.IsOver == "是"
                    select p;
            foreach (var i in m)
            {
                txtTruePrice.Text = i.TrueMoney.ToString();
            }
            txtHasMoeny.Text = txtTruePrice.Text;

            //还需要加载，单位的实际刊数
            var q = from p in mf.DS.TruePaper.AsEnumerable()
                    where p.UnitID == u.UnitID
                    select p;
            foreach (var i in q)
            {
                nUD101.Value = i.P101;
                nUD102.Value = i.P102;
                nUD103.Value = i.P103;
                nUD104.Value = i.P104;
                nUD105.Value = i.P105;
                nUD201.Value = i.P201;
                nUD202.Value = i.P202;
                nUD203.Value = i.P203;
                nUD301.Value = i.P301;
                nUD302.Value = i.P302;
            }
        }

        //加载该单位以前的交款记录
        private void LoadHasPay()
        {
            listView1.Items.Clear();
            double money = 0;
            Unit u = combJKDW.SelectedItem as Unit;
            string year = toolStripComboBox1.SelectedItem.ToString();

            var q = from p in mf.DS.Receivables.AsEnumerable()
                    where p.Year == year && p.UnitID == u.UnitID
                    orderby p.PayTime descending
                    select p;
            foreach (var i in q)
            {
                ListViewItem lv = new ListViewItem(new string[] { i.PayKind, i.TrueMoney.ToString(), i.PayTime.ToShortDateString(),i.IsOver });
                money += i.TrueMoney;
                lv.Tag = i.ID;
                listView1.Items.Add(lv);
            }
            labhasTotal.Text = money.ToString();
            switch (listView1.Items[0].Text)
            {
                case "现金":
                    rabMoney.Checked = true;
                    break;
                case "汇卡":
                    rabCard.Checked = true;
                    break;
                case "转账":
                    rabRemit.Checked = true;
                    break;
                case "欠条":
                    radIOU.Checked = true;
                    break;

            }
            if (listView1.Items[0].SubItems["IsOver"].Text == "是")
            {
                rabYes.Checked = true;
            }
            //如果该单位交过款了，对应显示相当的内容。
            txtTruePrice.Text = labhasTotal.Text;
        }

        //单位的报刊任务数量，从库中自动提取。这样就有了任务数，需要调整时，就有了实际任务数。
        //根据单位ID，自动加载单位分配的任务数量
        private void LoadPaperTask()
        {

            Unit u = combJKDW.SelectedItem as Unit;
            var q = from p in mf.DS.PaperTask.AsEnumerable()
                    where p.UnitId == u.UnitID && p.Year == toolStripComboBox1.SelectedItem.ToString()
                    select p;
            foreach (var i in q)
            {
                nUD101.Value = i.P101;
                nUD102.Value = i.P102;
                nUD103.Value = i.P103;
                nUD104.Value = i.P104;
                nUD105.Value = i.P105;
                nUD201.Value = i.P201;
                nUD202.Value = i.P202;
                nUD203.Value = i.P203;
                nUD301.Value = i.P301;
                nUD302.Value = i.P302;
            }
        }



        //自动取整！
        private void btnUp_Click(object sender, EventArgs e)
        {


            if (txtTruePrice.Text != "")
            {

                if (btnUp.Text == "↑")
                {
                    double trueprice = double.Parse(txtTotalMoney.Text.Trim());
                    txtTruePrice.Text = Math.Ceiling(trueprice).ToString("0");
                    btnUp.Text = "↓";
                }
                else
                {
                    double trueprice = double.Parse(txtTotalMoney.Text.Trim());
                    txtTruePrice.Text = Math.Floor(trueprice).ToString("0");
                    btnUp.Text = "↑";
                }

            }
        }

        #region 保存功能


        //保存：一是把收款金额单笔次记录到库，二是把报刊记录到库
        private void btnSave_Click(object sender, EventArgs e)
        {
            //记录交款到库
            SaveMoenyToDB();
            LoadHasPay();
        }




        //记录真实报刊数到库--新增
        private void SaveMoenyToDB()
        {
            //if (combPeple.Text == "")
            //{
            //    MessageBox.Show("请输入或选择交款人！");
            //    return;
            //}
            Unit u = combJKDW.SelectedItem as Unit;
            BKDataSet.ReceivablesRow rr = mf.DS.Receivables.NewReceivablesRow();
            rr.UnitID = u.UnitID;
            foreach (Control i in gBoxKind.Controls)
            {
                RadioButton r = i as RadioButton;
                if (r.Checked == true)
                {
                    rr.PayKind = r.Text;
                }

            }


            rr.TrueMoney = double.Parse(txtTruePrice.Text.Trim());
            //rr.PayPeoPleID;
            #region 添加人的先不做了。
            // if (combPeple.Text != "")
            // {
            //     int flagID = 0;
            //     var q = from p in mf.DS.People.AsEnumerable()
            //             where p.UnitID == u.UnitID
            //             select p;
            //     foreach (var i in q)
            //     {
            //         if (i.Name == combPeple.Text.Trim() && i.Phone == txtDraweeTel.Text.Trim())
            //         {
            ////todo:             flagID = i.PeopleID;
            //         }
            //     }
            //     if (flagID > 0)
            //     {
            //         rr.PayPeopleID = flagID;
            //     }
            //     else
            //     {
            //         string sex = "";
            //         if (rabNan.Checked == true)
            //         {
            //             sex = "男";
            //         }
            //         else
            //         {
            //             sex = "女";
            //         }
            //         //保存交款人信息到人员库
            //         //增加一个新地址的记录
            //         mf.peopleTap.Insert(u.UnitID, combPeple.Text.Trim(), sex, "", txtDraweeTel.Text.Trim(), "", "", "", "", "", 1);
            //         mf.DS.People.Dispose();
            //         mf.peopleTap.Fill(mf.DS.People);
            //         rr.PayPeopleID = mf.DS.People.AsEnumerable().Select(t => t.Field<int>("PeopleID")).Max();
            //     }

            // } 
            #endregion

            rr.PayTime = dateTimePicker1.Value;
            //rr.IsOver;
            if (rabYes.Checked == true)
            {
                rr.IsOver = "是";
            }
            else
            {
                rr.IsOver = "否";
            }

            rr.BZ = txtbz.Text.Trim();
            rr.Year = toolStripComboBox1.SelectedItem.ToString();

            mf.DS.Receivables.AddReceivablesRow(rr);
            mf.receivablesTap.Update(mf.DS.Receivables);
            mf.DS.Receivables.Dispose();
            mf.receivablesTap.Fill(mf.DS.Receivables);

            //记录真实报刊数到库
            SavePapetNumberTODB();
        }
        //记录真实报刊数量及金额到库
        private void SavePapetNumberTODB()
        {
            Unit u = new Unit();
            u = combJKDW.SelectedItem as Unit;
            BKDataSet.TruePaperRow tr = mf.DS.TruePaper.NewTruePaperRow();
            tr.UnitID = u.UnitID;
            tr.P101 = Convert.ToInt32(nUD101.Value);
            tr.P102 = Convert.ToInt32(nUD102.Value);
            tr.P103 = Convert.ToInt32(nUD103.Value);
            tr.P104 = Convert.ToInt32(nUD104.Value);
            tr.P105 = Convert.ToInt32(nUD105.Value);
            tr.P201 = Convert.ToInt32(nUD201.Value);
            tr.P202 = Convert.ToInt32(nUD202.Value);
            tr.P203 = Convert.ToInt32(nUD203.Value);
            tr.P301 = Convert.ToInt32(nUD301.Value);
            tr.P302 = Convert.ToInt32(nUD302.Value);
            tr.TrueMoney = Convert.ToDouble(txtTruePrice.Text);
            if (rabYes.Checked == true)
            {
                tr.IsOver = "是";
            }
            else
            {
                tr.IsOver = "否";
            }
            tr.Year = toolStripComboBox1.SelectedItem.ToString();

            mf.DS.TruePaper.AddTruePaperRow(tr);
            mf.truepaperTap.Update(mf.DS.TruePaper);
            mf.DS.TruePaper.Dispose();
            mf.truepaperTap.Fill(mf.DS.TruePaper);

            btnSave.Enabled = txtTruePrice.Enabled = dateTimePicker1.Enabled = false;
            //自动下一单位,最大值时不能加
            //if (combJKDW.SelectedIndex == combJKDW.Items.Count - 1)
            //{
            //    btnSave.Enabled = txtDraweeTel.Enabled = combPeple.Enabled = txtTruePrice.Enabled = dateTimePicker1.Enabled = false;
            //}
            //else
            //{
            //    combJKDW.SelectedIndex = combJKDW.SelectedIndex + 1;
            //    btnSave.Enabled = txtDraweeTel.Enabled = combPeple.Enabled = txtTruePrice.Enabled = dateTimePicker1.Enabled = true;
            //}


        }
        #endregion


        #endregion



        //报刊数量变化时
        private void nUD_ValueChanged(object sender, EventArgs e)
        {

            var q = from p in mf.DS.Paper.AsEnumerable()
                    where p.Year == toolStripComboBox1.SelectedItem.ToString()
                    select p;


            double tol = 0;

            #region 循环

            foreach (var f in q)
            {
                switch (f.PaperID)
                {
                    case "101":
                        if (nUD101.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD101.Value);
                        }
                        break;
                    case "102":
                        if (nUD102.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD102.Value);
                        }
                        break;
                    case "103":
                        if (nUD103.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD103.Value);
                        }
                        break;
                    case "104":
                        if (nUD104.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD104.Value);
                        }
                        break;
                    case "105":
                        if (nUD105.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD105.Value);
                        }
                        break;

                    case "201":
                        if (nUD201.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD201.Value);
                        }
                        break;
                    case "202":
                        if (nUD202.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD202.Value);
                        }
                        break;
                    case "203":
                        if (nUD203.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD203.Value);
                        }
                        break;
                    case "301":
                        if (nUD301.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD301.Value);
                        }
                        break;
                    case "302":
                        if (nUD302.Value > 0)
                        {
                            tol += (f.Price - f.SubSidy) * Convert.ToDouble(nUD302.Value);
                        }
                        break;

                }
            }
            #endregion

            labTal.Text = tol.ToString();
        }


        //用于记录临时ID的
        private int RID;

        //列表：判断是新增记录，还是修改记录 需要ID值，这样可以通过ListView1得到，这样可以用双击按功能来实现在修改
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtTruePrice.Enabled = dateTimePicker1.Enabled = true;
            if (listView1.SelectedItems.Count > 0)
            {
                RID = Convert.ToInt32(listView1.SelectedItems[0].Tag.ToString());
                BKDataSet.ReceivablesRow rr = mf.DS.Receivables.FindByID(RID);
                // MessageBox.Show(RID.ToString());
                txtTruePrice.Text = rr.TrueMoney.ToString();

                dateTimePicker1.Text = rr.PayTime.ToShortDateString();
                txtbz.Text = rr.BZ;
                //交款方式
                foreach (Control c in gBoxKind.Controls)
                {
                    RadioButton r = c as RadioButton;
                    if (r.Text == rr.PayKind)
                    {
                        r.Checked = true;
                    }
                }




                btnEidtUP.Show();
                btnSave.Enabled = false;

                //还需要加载，单位的实际刊数
                Unit u = combJKDW.SelectedItem as Unit;
                var q = from p in mf.DS.TruePaper.AsEnumerable()
                        where p.UnitID == u.UnitID
                        select p;
                foreach (var i in q)
                {
                    nUD101.Value = i.P101;
                    nUD102.Value = i.P102;
                    nUD103.Value = i.P103;
                    nUD104.Value = i.P104;
                    nUD105.Value = i.P105;
                    nUD201.Value = i.P201;
                    nUD202.Value = i.P202;
                    nUD203.Value = i.P203;
                    nUD301.Value = i.P301;
                    nUD302.Value = i.P302;
                }
            }
        }

        //修改按键
        private void btnEidtUP_Click(object sender, EventArgs e)
        {
            #region 更新交款记录

            BKDataSet.ReceivablesRow rr = mf.DS.Receivables.FindByID(RID);
            rr.TrueMoney = Convert.ToDouble(txtTruePrice.Text);
            rr.PayTime = dateTimePicker1.Value;
            rr.BZ = txtbz.Text;
            foreach (Control c in gBoxKind.Controls)
            {
                RadioButton r = c as RadioButton;
                if (r.Checked == true)
                {
                    rr.PayKind = r.Text;
                }

            }
            if (rabYes.Checked == true)
            {
                rr.IsOver = "是";
            }
            else
            {
                rr.IsOver = "否";
            }


            mf.receivablesTap.Update(mf.DS.Receivables);
            mf.DS.Receivables.Dispose();
            mf.receivablesTap.Fill(mf.DS.Receivables);

            #endregion

            #region 更新报刊数量
            Unit u = combJKDW.SelectedItem as Unit;
            var qu = from p in mf.DS.TruePaper.AsEnumerable()
                     where p.UnitID == u.UnitID
                     select p;
            foreach (var i in qu)
            {
                i.P101 = Convert.ToInt32(nUD101.Value);
                i.P102 = Convert.ToInt32(nUD102.Value);
                i.P103 = Convert.ToInt32(nUD103.Value);
                i.P104 = Convert.ToInt32(nUD104.Value);
                i.P105 = Convert.ToInt32(nUD105.Value);
                i.P201 = Convert.ToInt32(nUD201.Value);
                i.P202 = Convert.ToInt32(nUD202.Value);
                i.P203 = Convert.ToInt32(nUD203.Value);
                i.P301 = Convert.ToInt32(nUD301.Value);
                i.P302 = Convert.ToInt32(nUD302.Value);
                i.TrueMoney = Convert.ToDouble(labTal.Text);
                if (rabYes.Checked == true)
                {
                    i.IsOver = "是";
                }
                else
                {
                    i.IsOver = "否";
                }
            }

            mf.truepaperTap.Update(mf.DS.TruePaper);
            mf.DS.TruePaper.Dispose();
            mf.truepaperTap.Fill(mf.DS.TruePaper);

            #endregion
            btnEidtUP.Hide();
            btnSave.Enabled = true;
            //从新加载
            LoadHasPay();

            txtTruePrice.Enabled = dateTimePicker1.Enabled = false;

            combJKDW.Focus();
        }
        //删除错误数据
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                RID = Convert.ToInt32(listView1.SelectedItems[0].Tag.ToString());
                mf.DS.Receivables.FindByID(RID).Delete();
                mf.receivablesTap.Update(mf.DS.Receivables);
                mf.DS.Receivables.Dispose();
                mf.receivablesTap.Fill(mf.DS.Receivables);
            }
            Unit u = combJKDW.SelectedItem as Unit;
            listView1.Items.Clear();
            if (mf.DS.Receivables.Select("UnitID='" + u.UnitID + "'").Count() > 0) //判断该单位是否已经交过款，是否完成了任务
            {
                LoadHasPay();
            }
        }
        //统计某单位多次交款的总金额
        private void TotalHasPayMoney()
        {
            if (listView1.Items.Count > 0)
            {
                int money = 0;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    money += Convert.ToInt32(listView1.Items[0].SubItems[1].Text);

                }
                labhasTotal.Text = money.ToString();
            }
        }
        //手动输入实收金额时
        private void txtHasMoeny_TextChanged(object sender, EventArgs e)
        {
            nUD100.Value = nUD50.Value = nUD20.Value = nUD10.Value = nUD5.Value = nUD1.Value = nUD05.Value = nUD01.Value = 0;
            txtBackMoney.Text = "";
            //手动输入时要决断为数字
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtHasMoeny.Text, @"^([0-9]*)\.?[0-9]*$"))
            {
                MessageBox.Show("请输入正确的金额！");
                txtHasMoeny.Text = "";
                return;
            }


            double money = Convert.ToDouble(txtHasMoeny.Text.Trim());
            double backmoeny = money - Convert.ToDouble(txtTruePrice.Text.Trim());
            txtBackMoney.Text = backmoeny.ToString("0.0");

            #region 计算钱币


            while (money > 99.999)
            {
                nUD100.Value = nUD100.Value + 1;
                money -= 100.0;
            }

            while (money > 49.999)
            {
                nUD50.Value++;
                money -= 50.0;
            }
            while (money > 19.999)
            {
                nUD20.Value++;
                money -= 20.0;
            }
            while (money > 9.999)
            {
                nUD10.Value++;
                money -= 10.0;
            }

            while (money > 4.999)
            {
                nUD5.Value++;
                money -= 5.0;
            }

            while (money > .999)
            {
                nUD1.Value++;
                money -= 1.0;
            }

            while (money > .499)
            {
                nUD05.Value++;
                money -= .5;
            }

            while (money > .099)
            {
                nUD01.Value++;
                money -= .1;
            }



            #endregion


        }


        //收款单位用一个新表来做，把所有信息存到一个表里还是方便。第一步，初始化收款到，
        //从上年度复制或是从任务表中复制.
        //可以手工到筛选单位到新年度任务。
        // 复制中，把计划任务金额列去掉，把交款方式，定为现金。把完成状态定为否。年度为新年度。




        //计算已交款单位。
        private void CalcHasPayUnit()
        {
            mf.toolStripStatusLabel1.Text = "";
            //总单位数：
            //  mf.toolStripStatusLabel1.Text += "单位总数：" + mf.DS.Unit.Select("IsPay='是'").Count().ToString();           

            mf.toolStripStatusLabel1.Text += "现金总额：" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "PayKind='现金' and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";

            mf.toolStripStatusLabel1.Text += "    汇卡总额：" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "PayKind='汇卡' and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";

            mf.toolStripStatusLabel1.Text += "    汇邮局账户：" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "PayKind='转账' and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";

            mf.toolStripStatusLabel1.Text += "    欠条：" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "PayKind='欠条' and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";

            mf.toolStripStatusLabel1.Text += "    未交：" + mf.DS.Receivables.Compute("Sum(TrueMoney)", "PayKind='未交' and Year='" + toolStripComboBox1.SelectedItem.ToString() + "'").ToString() + "元";


        }
    }
}
