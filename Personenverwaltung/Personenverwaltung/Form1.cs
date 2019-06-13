using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        private void XMLExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person[]));
            FileStream stream = new FileStream("data.xml", FileMode.Create);

            var personen = new Person[listBoxPersonen.Items.Count];
            for (int i = 0; i < personen.Length; i++)
            {
                personen[i] = (Person)listBoxPersonen.Items[i];
            }

            serializer.Serialize(stream, personen);
            stream.Close();
        }

        private void XMLImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person[]));
            FileStream stream = new FileStream("data.xml", FileMode.Open);

            var deserialisiert = (Person[])serializer.Deserialize(stream);

            // listBoxPersonen.DataSource = deserialisiert;

            var result = MessageBox.Show("Wollen Sie die aktuellen Datensätze überschreiben?", "Inhalt löschen", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
                listBoxPersonen.Items.Clear(); // Löschen 

            foreach (var person in deserialisiert)
            {
                listBoxPersonen.Items.Add(person);
            }


            stream.Close();
        }
    }
}
