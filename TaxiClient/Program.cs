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
            if (lf.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else if (lf.ShowDialog() == DialogResult.No)
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
            if (rf.ShowDialog() == DialogResult.OK)
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
