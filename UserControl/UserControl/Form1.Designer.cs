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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labledTextBox4 = new UserControl.LabledTextBox();
            this.labledTextBox3 = new UserControl.LabledTextBox();
            this.labledTextBox2 = new UserControl.LabledTextBox();
            this.labledTextBox1 = new UserControl.LabledTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labledTextBox4
            // 
            this.labledTextBox4.Content = null;
            this.labledTextBox4.Header = "Kontostand";
            resources.ApplyResources(this.labledTextBox4, "labledTextBox4");
            this.labledTextBox4.Name = "labledTextBox4";
            // 
            // labledTextBox3
            // 
            this.labledTextBox3.Content = null;
            this.labledTextBox3.Header = "Alter:";
            resources.ApplyResources(this.labledTextBox3, "labledTextBox3");
            this.labledTextBox3.Name = "labledTextBox3";
            // 
            // labledTextBox2
            // 
            this.labledTextBox2.Content = null;
            this.labledTextBox2.Header = "Nachname:";
            resources.ApplyResources(this.labledTextBox2, "labledTextBox2");
            this.labledTextBox2.Name = "labledTextBox2";
            // 
            // labledTextBox1
            // 
            this.labledTextBox1.Content = null;
            this.labledTextBox1.Header = "Vorname:";
            resources.ApplyResources(this.labledTextBox1, "labledTextBox1");
            this.labledTextBox1.Name = "labledTextBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labledTextBox4);
            this.Controls.Add(this.labledTextBox3);
            this.Controls.Add(this.labledTextBox2);
            this.Controls.Add(this.labledTextBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabledTextBox labledTextBox1;
        private LabledTextBox labledTextBox2;
        private LabledTextBox labledTextBox3;
        private LabledTextBox labledTextBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

