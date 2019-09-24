using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CefSharp.WinForms;
using CefSharp;


namespace AutoSingIn
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {

            //WriteConfigSupport write = new WriteConfigSupport("cookie", "cookie", "cookie");
            //Test.SaveConfig("cookie", "cookie");
            //string state = write.State;
            //ReadConfigSupport read = new ReadConfigSupport("cookie", ConfigChoice.cookie);
            //string[] s = read.Account;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
