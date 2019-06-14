using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            int zahl1 = Convert.ToInt32(textBoxZahl1.Text);
            int zahl2 = Convert.ToInt32(textBoxZahl2.Text);

            textBoxErgebnis.Text = (zahl1 + zahl2).ToString();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            int zahl1 = Convert.ToInt32(textBoxZahl1.Text);
            int zahl2 = Convert.ToInt32(textBoxZahl2.Text);

            textBoxErgebnis.Text = (zahl1 - zahl2).ToString();
        }
    }
}
