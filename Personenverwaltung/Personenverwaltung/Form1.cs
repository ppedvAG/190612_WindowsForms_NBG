using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            var dlg = new SaveFileDialog();
            dlg.Title = "Specherort für die XML-Datei";
            dlg.Filter = "XML | *.xml";

            var dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.Cancel)
                return;

            XmlSerializer serializer = new XmlSerializer(typeof(Person[]));
            FileStream stream = new FileStream(dlg.FileName, FileMode.Create);

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
            // FolderBrowserDialog dlg = new FolderBrowserDialog();

            var dlg = new OpenFileDialog();
            dlg.Title = "XML Datei für den Import auswählen";
            dlg.Filter = "XML | *.xml";

            var dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.Cancel)
                return;

            XmlSerializer serializer = new XmlSerializer(typeof(Person[]));
            FileStream stream = new FileStream(dlg.FileName, FileMode.Open);

            var deserialisiert = (Person[])serializer.Deserialize(stream);

            // listBoxPersonen.DataSource = deserialisiert;

            var result = MessageBox.Show("Wollen Sie die aktuellen Datensätze überschreiben?", "Inhalt löschen", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                listBoxPersonen.Items.Clear(); // Löschen 

            foreach (var person in deserialisiert)
            {
                listBoxPersonen.Items.Add(person);
            }


            stream.Close();
        }

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            // 1) ErrorProvider in das Formular hineinziehen
            // 2) Im gewünschten Element das Validating-Event nutzen
            // String mit @ davor (zb @"Hallo Welt") verhindert, dass backslash wie zb "\n" als Steuerzeichen gewertet wird

            if(Regex.IsMatch(textBoxEmail.Text, @"[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]{2,4}") == false)
            {
                errorProviderEmail.SetError(textBoxEmail, "Email ungültig");
            }
            else
            {
                errorProviderEmail.SetError(textBoxEmail, "");
            }
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            // 3) Validierung antriggern
            ValidateChildren();
        }
    }
}
