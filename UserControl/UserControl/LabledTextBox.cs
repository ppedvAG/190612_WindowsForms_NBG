using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl
{
    public partial class LabledTextBox : System.Windows.Forms.UserControl
    {
        public LabledTextBox()
        {
            InitializeComponent();
        }

        public string Header { get; set; }
        public string Content { get; set; }

        private void LabledTextBox_Load(object sender, EventArgs e)
        {
            labelHeader.Text = Header;
            textBoxContent.Text = Content;
        }
    }
}
