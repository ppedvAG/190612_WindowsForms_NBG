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
    public partial class ZweitesFenster : Form
    {
        public ZweitesFenster(int zahl1)
        {
            InitializeComponent();
            this.zahl1 = zahl1;
        }
        private int zahl1;

        private void ButtonZwei_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zahl1.ToString());
            
        }

        public string Ergebnis
        {
            get
            {
                return textBoxErgebnis.Text;
            }
        }
    }
}
