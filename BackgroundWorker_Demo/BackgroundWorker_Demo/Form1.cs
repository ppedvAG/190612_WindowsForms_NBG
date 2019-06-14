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

namespace BackgroundWorker_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initialisieurngslogik
            // Alternative: Form1.Load 
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += Timer_Logik;

            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;

            worker.WorkerReportsProgress = true; // "Aktiviert" das Report-Progress feature mit ProgressChanged
            // worker.ProgressChanged += Worker_ProgressChanged;
        }

        // private Variablen, die von den Methoden weiter unten genutzt werden
        private BackgroundWorker worker;
        private System.Windows.Forms.Timer timer;

        private void Timer_Logik(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo Welt");
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                worker.ReportProgress(i);
                // progressBarWert.Value = i; // Zugriff auf ein Steuerelement
                // Fehler: Workerthread darf nicht auf Objekte vom UI-Thread zugreifen (in diesem Fall die ProgressBar)
            }
        }
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarWert.Value = e.ProgressPercentage;
        }
        private void ButtonEinfügen_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync(); // worker starten
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                worker.ProgressChanged += Worker_ProgressChanged;
            else
                worker.ProgressChanged -= Worker_ProgressChanged;
        }
        private void ButtonTimer_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}