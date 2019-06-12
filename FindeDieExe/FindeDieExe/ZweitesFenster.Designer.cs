namespace FindeDieExe
{
    partial class ZweitesFenster
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
            this.buttonZwei = new System.Windows.Forms.Button();
            this.textBoxErgebnis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonZwei
            // 
            this.buttonZwei.Location = new System.Drawing.Point(197, 125);
            this.buttonZwei.Name = "buttonZwei";
            this.buttonZwei.Size = new System.Drawing.Size(301, 146);
            this.buttonZwei.TabIndex = 0;
            this.buttonZwei.Text = "Nummer 2";
            this.buttonZwei.UseVisualStyleBackColor = true;
            this.buttonZwei.Click += new System.EventHandler(this.ButtonZwei_Click);
            // 
            // textBoxErgebnis
            // 
            this.textBoxErgebnis.Location = new System.Drawing.Point(210, 277);
            this.textBoxErgebnis.Name = "textBoxErgebnis";
            this.textBoxErgebnis.Size = new System.Drawing.Size(288, 20);
            this.textBoxErgebnis.TabIndex = 1;
            // 
            // ZweitesFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxErgebnis);
            this.Controls.Add(this.buttonZwei);
            this.Name = "ZweitesFenster";
            this.Text = "ZweitesFenster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZwei;
        private System.Windows.Forms.TextBox textBoxErgebnis;
    }
}