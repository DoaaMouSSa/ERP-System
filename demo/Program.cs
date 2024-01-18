using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo.PL;

namespace demo
{
    internal static class Program
    {
        public static string user_name;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PL.Authentication.frm_Login());
            //Application.Run(new PL.Dashboard.frm_Main());
            //Application.Run(new PL.Accounts.frm_accounts());
            //Application.Run(new PL.Journal.frm_journal());
            Application.Run(new PL.Currency.frm_Currency());

        }
    }
}
