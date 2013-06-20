using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm();
        }

        static void LoginForm()
        {
            Authentication.LoginForm lf = new Authentication.LoginForm();
            DialogResult dr = lf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else if (dr == DialogResult.No)
            {
                RegisterForm();
            }
            else
            {
                Application.Exit();
            }
        }

        static void RegisterForm()
        {
            Authentication.RegisterForm rf = new Authentication.RegisterForm();
            DialogResult dr = rf.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                LoginForm();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
