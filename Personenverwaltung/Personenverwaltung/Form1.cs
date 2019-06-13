using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personenverwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEinfügen_Click(object sender, EventArgs e)
        {
            // 1) Daten validieren
            // 2) Person erstellen
            // 3) Person in die Liste einfügen (ListBoxPersonen.Items.Add(p1);)

            if (string.IsNullOrWhiteSpace(textBoxVorname.Text))
            {
                MessageBox.Show("Bitte geben Sie einen Vornamen ein.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxNachname.Text))
            {
                MessageBox.Show("Bitte geben Sie einen Nachnamen ein.");
                return;
            }

            decimal kontostand;
            try
            {
                kontostand = Convert.ToDecimal(textBoxKontostand.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bitte geben Sie nur Zahlen ein");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Der Kontostand ist zu groß oder zu klein");
                return;
            }

            Person p = new Person();
            p.Vorname = textBoxVorname.Text;
            p.Nachname = textBoxNachname.Text;
            p.Alter = Convert.ToByte(numericUpDownAlter.Value);
            p.Kontostand = kontostand;
            p.Geschlecht = checkBoxGeschlecht.Checked;

            listBoxPersonen.Items.Add(p);
        }
    }
}
