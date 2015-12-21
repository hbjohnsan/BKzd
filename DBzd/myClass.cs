using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DBzd
{
    public class UnitPaperTask
    {
        public int id { get; set; }
        public string unitid { get; set; }
        public string paperid { get; set; }
        public int plantnum { get; set; }
        public int truenum { get; set; }
        public string year { get; set; }
    }

    public class UnitTaskMoney
    {
        public int id { get; set; }
        public string unitid { get; set; }
        public double plantprices { get; set; }
        public double compprices { get; set; }
        public double totallprices { get; set; }
        public string year { get; set; }
    }
    public class Unit
    {
        public int ID { get; set; }
        public string UnitID { get; set; }
        public string UnitParantTaskID { get; set; }
        public string AllName { get; set; }
        public string ShortName { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Kind { get; set; }
        public string Istake { get; set; }
        public int AddressID { get; set; }
        public string IsPay { get; set; }
        public Unit() { }
        public Unit(string unitid,string allname,string shortname,string tel,string fax,string kind,string istake,int addressid,string ispay)
        {
            this.UnitID = unitid;
            this.AllName = allname;
            this.ShortName = shortname;
            this.Tel = tel;
            this.Fax = fax;
            this.Kind = kind;
            this.Istake = istake;
            this.AddressID = addressid;
            this.IsPay = ispay;
        }

    }
    public class Paper
    {
        public int ID { get; set; }
        public string PaperID { get; set; }
        public string YFDH { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public double Price { get; set; }
        public double SubSidy { get; set; }
        public double TotalPrice { get; set; }
        public double TotalSubSidy { get; set; }        
        public string IsDanKan { get; set; }
        public string Year { get; set; }
        public Paper() { }
        public Paper(int id,string paperid,string yfdh,string name,int number,double price,double subsidy,double totalprice,double totalsubsidy,string isdankan,string year) {
            this.ID = id;
            this.PaperID = paperid;
            this.YFDH = yfdh;
            this.Name = name;
            this.Number = number;
            this.Price = price;
            this.SubSidy = subsidy;
            this.TotalPrice = totalprice;
            this.TotalSubSidy = totalsubsidy;
            this.IsDanKan = isdankan;
            this.Year = year;
        }



    }
    public class PaperTask
    {
        public int id { get; set; }
        public string paperid { get; set; }
        public int number { get; set; }
        public double price { get; set; }
        public double totalmoney { get; set; }
        public double subsidy { get; set; }
        public double totalsubsidymoney { get; set; }
        public string year { get; set; }
    }
    public class Fees
    {
        public int id { get; set; }
        public string unitid { get; set; }
        public double plantprrice { get; set; }
        public double tureprice { get; set; }
        public string drawee { get; set; }
        public string draweetel { get; set; }
        public string paykind { get; set; }
        public DateTime paytime { get; set; }
        public string payee { get; set; }
        public string bank { get; set; }
        public string getpayaccount { get; set; }
        public string getpaysb { get; set; }
        public DateTime getpaytime { get; set; }
        public string year { get; set; }
        public string flay { get; set; }
        public string bz { get; set; }
    }
    public class People
    {
        public int PeopleID { get; set; }
        public string UnitID { get; set; }     
        public string Name { get; set; }
        public string Sex { get; set; }
        public string HomeTel { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string QQ { get; set; }
        public string QQ2 { get; set; }
        public string Email { get; set; }
        public string CardId { get; set; }
        public int AddressID { get; set; }

    }
    public class UnitPost
    {
        public int id { get; set; }
        public string unitid { get; set; }
        public string unitPostID { get; set; }
        public string unitPost { get; set; }
        public string unitPostTel { get; set; }
        public int personeID { get; set; }
        public string year { get; set; }
    }

    public static class SQLiteHelper
    {
        private static string datasource = ConfigurationManager.ConnectionStrings["DBzd.Properties.Settings.baokanConnectionString"].ConnectionString.ToString();
        public static int TransExecuteNonQuery(DataTable dt,string commandText, SQLiteParameter[] commandParameters)
        {

             //加入了详细的任务列表
                using (SQLiteConnection conn = new SQLiteConnection(datasource))
                {
                    int result = 0;
                    conn.Open();
                    using (System.Data.SQLite.SQLiteTransaction trans = conn.BeginTransaction())
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(conn))
                        {
                            cmd.Transaction = trans;
                            cmd.CommandText = commandText;
                            cmd.Parameters.AddRange(commandParameters);                            
                            
                            try
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    result = cmd.ExecuteNonQuery();
                                }
                               

                                trans.Commit();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                trans.Rollback();

                            }
                        }
                    }
                    return result;
                }
        }
    }
     
    //系统配置类
    [Serializable()]
    public class configBK
    {
        /// <summary>
        /// 计划任务总金额
        /// </summary>
        public double PlantTotalMoney { get; set; }
        /// <summary>
        /// 计划补贴总金额
        /// </summary>
        public double SubsidyTotalMoney { get; set; }
        /// <summary>
        /// 乡镇任务总金额
        /// </summary>
        public double TownTotalMoney { get; set; }
        /// <summary>
        /// 县直任务总金额
        /// </summary>
        public double UnitToalMoney { get; set; }
        /// <summary>
        /// 年度
        /// </summary>
        public string YEAR { get; set; }
    }


   
}
