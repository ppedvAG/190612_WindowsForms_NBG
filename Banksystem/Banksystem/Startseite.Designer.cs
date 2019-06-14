namespace Banksystem
{
    partial class Startseite
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelKontostand = new System.Windows.Forms.Label();
            this.textBoxBetrag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEinzahlen = new System.Windows.Forms.Button();
            this.buttonAbheben = new System.Windows.Forms.Button();
            this.listBoxTransaktionen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktueller Kontostand:";
            // 
            // labelKontostand
            // 
            this.labelKontostand.AutoSize = true;
            this.labelKontostand.Location = new System.Drawing.Point(146, 34);
            this.labelKontostand.Name = "labelKontostand";
            this.labelKontostand.Size = new System.Drawing.Size(19, 13);
            this.labelKontostand.TabIndex = 1;
            this.labelKontostand.Text = "0€";
            // 
            // textBoxBetrag
            // 
            this.textBoxBetrag.Location = new System.Drawing.Point(79, 60);
            this.textBoxBetrag.Name = "textBoxBetrag";
            this.textBoxBetrag.Size = new System.Drawing.Size(112, 20);
            this.textBoxBetrag.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Betrag:";
            // 
            // buttonEinzahlen
            // 
            this.buttonEinzahlen.Location = new System.Drawing.Point(32, 94);
            this.buttonEinzahlen.Name = "buttonEinzahlen";
            this.buttonEinzahlen.Size = new System.Drawing.Size(75, 23);
            this.buttonEinzahlen.TabIndex = 4;
            this.buttonEinzahlen.Text = "Einzahlen";
            this.buttonEinzahlen.UseVisualStyleBackColor = true;
            this.buttonEinzahlen.Click += new System.EventHandler(this.ButtonEinzahlen_Click);
            // 
            // buttonAbheben
            // 
            this.buttonAbheben.Location = new System.Drawing.Point(116, 94);
            this.buttonAbheben.Name = "buttonAbheben";
            this.buttonAbheben.Size = new System.Drawing.Size(75, 23);
            this.buttonAbheben.TabIndex = 5;
            this.buttonAbheben.Text = "Abheben";
            this.buttonAbheben.UseVisualStyleBackColor = true;
            this.buttonAbheben.Click += new System.EventHandler(this.ButtonAbheben_Click);
            // 
            // listBoxTransaktionen
            // 
            this.listBoxTransaktionen.FormattingEnabled = true;
            this.listBoxTransaktionen.Location = new System.Drawing.Point(213, 34);
            this.listBoxTransaktionen.Name = "listBoxTransaktionen";
            this.listBoxTransaktionen.Size = new System.Drawing.Size(451, 199);
            this.listBoxTransaktionen.TabIndex = 6;
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 267);
            this.Controls.Add(this.listBoxTransaktionen);
            this.Controls.Add(this.buttonAbheben);
            this.Controls.Add(this.buttonEinzahlen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBetrag);
            this.Controls.Add(this.labelKontostand);
            this.Controls.Add(this.label1);
            this.Name = "Startseite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startseite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKontostand;
        private System.Windows.Forms.TextBox textBoxBetrag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEinzahlen;
        private System.Windows.Forms.Button buttonAbheben;
        private System.Windows.Forms.ListBox listBoxTransaktionen;
    }
}