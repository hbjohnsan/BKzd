using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DBzd
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginFrm lgfrm = new LoginFrm();
            if (lgfrm.ShowDialog() == DialogResult.OK)//表示当f1的DialogResult等于Ok时主程序才开始运行，所以在Form1中登录成功时要将Dialogresult设为OK
            {
                Application.Run(new MainFrm());
            }
        }
    }
}
