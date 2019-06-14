using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var allUsers = Properties.Resources.AllowedUsers.Split(',');
            //if (!allUsers.Contains(Environment.UserName))
            //{
            //    MessageBox.Show("Die Applikation darf von Ihnen leider nicht verwendet werden");
            //    return;
            //}

            // Culture bei Programmstart festlegen
            // Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-AT");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
