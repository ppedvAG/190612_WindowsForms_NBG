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
    public partial class Startseite : Form
    {
        public Startseite(Konto user)
        {
            InitializeComponent();

            k1 = user; //new Konto(100);
            labelKontostand.Text = k1.Kontostand.ToString();
        }
        private Konto k1;


        private void ButtonEinzahlen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBetrag.Text))
                return;

            var betrag = Convert.ToDecimal(textBoxBetrag.Text);
            k1.Einzahlen(betrag);

            labelKontostand.Text = k1.Kontostand.ToString();
            listBoxTransaktionen.Items.Add(betrag + " wurde eingezahlt. Neuer Kontostand: " + k1.Kontostand);
        }

        private void ButtonAbheben_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBetrag.Text))
                return;

            k1.Abheben(Convert.ToDecimal(textBoxBetrag.Text));

            labelKontostand.Text = k1.Kontostand.ToString();
            listBoxTransaktionen.Items.Add(textBoxBetrag.Text + " wurde abgehoben. Neuer Kontostand: " + k1.Kontostand);
        }
    }
}
