using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ci = new System.Globalization.CultureInfo("en");
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("UserControl.Properties.Resources", typeof(Form1).Assembly);
            label1.Text = rm.GetString("Greeting",ci);
        }
    }
}
