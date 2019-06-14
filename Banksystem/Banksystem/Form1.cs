using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banksystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "user" && textBoxPasswort.Text == "passwort")
            {
                Startseite s2 = new Startseite();
                s2.ShowDialog();
            }
            else
                MessageBox.Show("Username oder Passwort falsch...");
        }
    }
}
