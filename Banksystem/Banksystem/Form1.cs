using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banksystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            verfügbarenKonten = new List<Konto>();
            verfügbarenKonten.Add(new Konto(10000) { Username = "Tom Ate", Passwort = "abcde" });
            verfügbarenKonten.Add(new Konto(-20) { Username = "Anna Nass", Passwort = "12345" });
            verfügbarenKonten.Add(new Konto(0) { Username = "Peter Silie", Passwort = "qwertz" });
        }
        List<Konto> verfügbarenKonten;

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(verfügbarenKonten.Any(konto => konto.Username == textBoxUsername.Text))
            {
                if (verfügbarenKonten.Any(konto => konto.Passwort == textBoxPasswort.Text))
                {
                    Startseite s2 = new Startseite(verfügbarenKonten.First(konto => konto.Username == textBoxUsername.Text));
                    this.Visible = false;
                    s2.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Das Passwort ist leider falsch");
                }
            }
            else
            {
                MessageBox.Show("Der User ist leider nicht vorhanden");
            }
        }
    }
}
