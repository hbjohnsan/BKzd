using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace DBzd
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            #region 第一次配置文件
           // configData();
            #endregion
        }

        private static void configData()
        {
            //判断软件环境配置文件是否存在，不存在创新赋值
            if (!File.Exists("config.dat"))
            {
                configBK cf = new configBK();
                cf.YEAR = DateTime.Now.Year.ToString();
                cf.PlantTotalMoney = 0;
                cf.SubsidyTotalMoney = 0;
                cf.TownTotalMoney = 0;
                cf.UnitToalMoney = 0;

                FileStream fs = new FileStream("config.dat", FileMode.Create);
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, cf);
                }
                catch (SerializationException ei)
                {

                    MessageBox.Show(ei.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
