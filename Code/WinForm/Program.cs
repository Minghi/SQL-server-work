using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinForm
{
    static class Program
    {
        public static bool isLogin;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            isLogin = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            /*
            FormLogin login=new FormLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMainNew());
            }
            */
        }
    }
}
