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

        private void ButtonSuchen_Click(object sender, EventArgs e)
        {
            // Reset:
            toolStripProgressBar.Value = 0;

            // System.IO // seit UWP: Windows.Storage

            // 1) Stammverzeichnis, ab dem gesucht wird
            string path1 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

            var path1Directories =  Directory.GetDirectories(path1, "*", SearchOption.AllDirectories);
            var path2Directories =  Directory.GetDirectories(path2, "*", SearchOption.AllDirectories);

            var allDirectories = new string[path1Directories.Length + path2Directories.Length];

            Array.Copy(path1Directories, allDirectories, path1Directories.Length);
            Array.Copy(path2Directories,0, allDirectories,path1Directories.Length, path2Directories.Length);

            toolStripProgressBar.Maximum = allDirectories.Length;

            foreach (var directory in allDirectories)
            {
                foreach (var file in Directory.GetFiles(directory))
                {
                    if (Path.GetFileName(file).StartsWith(textBoxSuchtext.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        listBoxErgebnisse.Items.Add(file);
                        listBoxErgebnisse.SelectedIndex = listBoxErgebnisse.Items.Count - 1;
                        listBoxErgebnisse.SelectedIndex = -1;
                        this.Refresh();
                    }
                }
                toolStripProgressBar.Value++;
            }

            // textBoxSuchtext.Text
        }

        private void ÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var zweitesFenster = new ZweitesFenster(42);

            // zweitesFenster.Show();
            zweitesFenster.ShowDialog();
            MessageBox.Show(zweitesFenster.Ergebnis);
        }
    }
}
