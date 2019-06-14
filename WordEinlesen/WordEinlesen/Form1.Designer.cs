namespace WordEinlesen
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
            this.textBoxTextAusWord = new System.Windows.Forms.TextBox();
            this.buttonWordEinlesen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTextAusWord
            // 
            this.textBoxTextAusWord.Location = new System.Drawing.Point(12, 12);
            this.textBoxTextAusWord.Multiline = true;
            this.textBoxTextAusWord.Name = "textBoxTextAusWord";
            this.textBoxTextAusWord.Size = new System.Drawing.Size(320, 107);
            this.textBoxTextAusWord.TabIndex = 0;
            // 
            // buttonWordEinlesen
            // 
            this.buttonWordEinlesen.Location = new System.Drawing.Point(12, 125);
            this.buttonWordEinlesen.Name = "buttonWordEinlesen";
            this.buttonWordEinlesen.Size = new System.Drawing.Size(320, 23);
            this.buttonWordEinlesen.TabIndex = 1;
            this.buttonWordEinlesen.Text = "Word einlesen";
            this.buttonWordEinlesen.UseVisualStyleBackColor = true;
            this.buttonWordEinlesen.Click += new System.EventHandler(this.ButtonWordEinlesen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 166);
            this.Controls.Add(this.buttonWordEinlesen);
            this.Controls.Add(this.textBoxTextAusWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTextAusWord;
        private System.Windows.Forms.Button buttonWordEinlesen;
    }
}

