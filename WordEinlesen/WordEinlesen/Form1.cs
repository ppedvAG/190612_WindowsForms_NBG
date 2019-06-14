using Word = Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordEinlesen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonWordEinlesen_Click(object sender, EventArgs e)
        {
            // 1) Referenzen auf die Word-Libs hinzufügen

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Word-Dokument | *.docx";
            dlg.ShowDialog();

            // 2) Word-Instanz öffnen
            Word.Application app = new Word.Application();
            // 3) Word-Datei öffnen
            Word.Document doc = app.Documents.Open(dlg.FileName);

            // app.Selection.WholeStory(); // alles im Dokument markieren (wie STRG + A)
            doc.Tables[1].Select(); // die erste Tabelle selektieren
            textBoxTextAusWord.Text = app.Selection.Text;

            app.Quit(false);
        }
    }
}
