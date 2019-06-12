using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindeDieExe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000; // in ms
            timer.Tick += RefreshLabel;

            timer.Start();
        }
        Timer timer = new Timer();

        private void RefreshLabel(object sender, EventArgs e)
        {
            toolStripStatusLabelCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }


        private void SpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Speichern
            MessageBox.Show("Datei wurde gespeichert !");
        }

        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
