namespace UserControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labledTextBox4 = new UserControl.LabledTextBox();
            this.labledTextBox3 = new UserControl.LabledTextBox();
            this.labledTextBox2 = new UserControl.LabledTextBox();
            this.labledTextBox1 = new UserControl.LabledTextBox();
            this.SuspendLayout();
            // 
            // labledTextBox4
            // 
            this.labledTextBox4.Content = null;
            this.labledTextBox4.Header = "Kontostand";
            this.labledTextBox4.Location = new System.Drawing.Point(12, 128);
            this.labledTextBox4.Name = "labledTextBox4";
            this.labledTextBox4.Size = new System.Drawing.Size(251, 40);
            this.labledTextBox4.TabIndex = 3;
            // 
            // labledTextBox3
            // 
            this.labledTextBox3.Content = null;
            this.labledTextBox3.Header = "Alter:";
            this.labledTextBox3.Location = new System.Drawing.Point(12, 92);
            this.labledTextBox3.Name = "labledTextBox3";
            this.labledTextBox3.Size = new System.Drawing.Size(251, 40);
            this.labledTextBox3.TabIndex = 2;
            // 
            // labledTextBox2
            // 
            this.labledTextBox2.Content = null;
            this.labledTextBox2.Header = "Nachname:";
            this.labledTextBox2.Location = new System.Drawing.Point(12, 59);
            this.labledTextBox2.Name = "labledTextBox2";
            this.labledTextBox2.Size = new System.Drawing.Size(251, 40);
            this.labledTextBox2.TabIndex = 1;
            // 
            // labledTextBox1
            // 
            this.labledTextBox1.Content = null;
            this.labledTextBox1.Header = "Vorname:";
            this.labledTextBox1.Location = new System.Drawing.Point(12, 24);
            this.labledTextBox1.Name = "labledTextBox1";
            this.labledTextBox1.Size = new System.Drawing.Size(251, 40);
            this.labledTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 386);
            this.Controls.Add(this.labledTextBox4);
            this.Controls.Add(this.labledTextBox3);
            this.Controls.Add(this.labledTextBox2);
            this.Controls.Add(this.labledTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LabledTextBox labledTextBox1;
        private LabledTextBox labledTextBox2;
        private LabledTextBox labledTextBox3;
        private LabledTextBox labledTextBox4;
    }
}

