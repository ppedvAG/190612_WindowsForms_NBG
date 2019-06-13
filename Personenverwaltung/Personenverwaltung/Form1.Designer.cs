namespace Personenverwaltung
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonEinfügen = new System.Windows.Forms.Button();
            this.checkBoxGeschlecht = new System.Windows.Forms.CheckBox();
            this.numericUpDownAlter = new System.Windows.Forms.NumericUpDown();
            this.textBoxKontostand = new System.Windows.Forms.MaskedTextBox();
            this.labelKontostand = new System.Windows.Forms.Label();
            this.labelAlter = new System.Windows.Forms.Label();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.labelNachname = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.labelVorname = new System.Windows.Forms.Label();
            this.listBoxPersonen = new System.Windows.Forms.ListBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLExportToolStripMenuItem,
            this.xMLImportToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // xMLExportToolStripMenuItem
            // 
            this.xMLExportToolStripMenuItem.Name = "xMLExportToolStripMenuItem";
            this.xMLExportToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.xMLExportToolStripMenuItem.Text = "XML Export";
            this.xMLExportToolStripMenuItem.Click += new System.EventHandler(this.XMLExportToolStripMenuItem_Click);
            // 
            // xMLImportToolStripMenuItem
            // 
            this.xMLImportToolStripMenuItem.Name = "xMLImportToolStripMenuItem";
            this.xMLImportToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.xMLImportToolStripMenuItem.Text = "XML Import";
            this.xMLImportToolStripMenuItem.Click += new System.EventHandler(this.XMLImportToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxEmail);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonEinfügen);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxGeschlecht);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownAlter);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxKontostand);
            this.splitContainer1.Panel1.Controls.Add(this.labelKontostand);
            this.splitContainer1.Panel1.Controls.Add(this.labelAlter);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNachname);
            this.splitContainer1.Panel1.Controls.Add(this.labelNachname);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxVorname);
            this.splitContainer1.Panel1.Controls.Add(this.labelVorname);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxPersonen);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonEinfügen
            // 
            this.buttonEinfügen.Location = new System.Drawing.Point(16, 154);
            this.buttonEinfügen.Name = "buttonEinfügen";
            this.buttonEinfügen.Size = new System.Drawing.Size(220, 23);
            this.buttonEinfügen.TabIndex = 11;
            this.buttonEinfügen.Text = "Einfügen";
            this.buttonEinfügen.UseVisualStyleBackColor = true;
            this.buttonEinfügen.Click += new System.EventHandler(this.ButtonEinfügen_Click);
            // 
            // checkBoxGeschlecht
            // 
            this.checkBoxGeschlecht.AutoSize = true;
            this.checkBoxGeschlecht.Location = new System.Drawing.Point(156, 131);
            this.checkBoxGeschlecht.Name = "checkBoxGeschlecht";
            this.checkBoxGeschlecht.Size = new System.Drawing.Size(80, 17);
            this.checkBoxGeschlecht.TabIndex = 10;
            this.checkBoxGeschlecht.Text = "Geschlecht";
            this.checkBoxGeschlecht.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAlter
            // 
            this.numericUpDownAlter.Location = new System.Drawing.Point(81, 80);
            this.numericUpDownAlter.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownAlter.Name = "numericUpDownAlter";
            this.numericUpDownAlter.Size = new System.Drawing.Size(155, 20);
            this.numericUpDownAlter.TabIndex = 9;
            // 
            // textBoxKontostand
            // 
            this.textBoxKontostand.Location = new System.Drawing.Point(81, 105);
            this.textBoxKontostand.Mask = "00000";
            this.textBoxKontostand.Name = "textBoxKontostand";
            this.textBoxKontostand.Size = new System.Drawing.Size(155, 20);
            this.textBoxKontostand.TabIndex = 7;
            // 
            // labelKontostand
            // 
            this.labelKontostand.AutoSize = true;
            this.labelKontostand.Location = new System.Drawing.Point(12, 108);
            this.labelKontostand.Name = "labelKontostand";
            this.labelKontostand.Size = new System.Drawing.Size(64, 13);
            this.labelKontostand.TabIndex = 6;
            this.labelKontostand.Text = "Kontostand:";
            // 
            // labelAlter
            // 
            this.labelAlter.AutoSize = true;
            this.labelAlter.Location = new System.Drawing.Point(12, 82);
            this.labelAlter.Name = "labelAlter";
            this.labelAlter.Size = new System.Drawing.Size(31, 13);
            this.labelAlter.TabIndex = 4;
            this.labelAlter.Text = "Alter:";
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(81, 53);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(155, 20);
            this.textBoxNachname.TabIndex = 3;
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Location = new System.Drawing.Point(13, 56);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(62, 13);
            this.labelNachname.TabIndex = 2;
            this.labelNachname.Text = "Nachname:";
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(81, 27);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(155, 20);
            this.textBoxVorname.TabIndex = 1;
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Location = new System.Drawing.Point(12, 30);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(52, 13);
            this.labelVorname.TabIndex = 0;
            this.labelVorname.Text = "Vorname:";
            // 
            // listBoxPersonen
            // 
            this.listBoxPersonen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPersonen.FormattingEnabled = true;
            this.listBoxPersonen.Location = new System.Drawing.Point(0, 0);
            this.listBoxPersonen.Name = "listBoxPersonen";
            this.listBoxPersonen.Size = new System.Drawing.Size(530, 426);
            this.listBoxPersonen.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(81, 202);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(155, 20);
            this.textBoxEmail.TabIndex = 13;
            this.textBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmail_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "EMail:";
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Personenverwaltung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonEinfügen;
        private System.Windows.Forms.CheckBox checkBoxGeschlecht;
        private System.Windows.Forms.NumericUpDown numericUpDownAlter;
        private System.Windows.Forms.MaskedTextBox textBoxKontostand;
        private System.Windows.Forms.Label labelKontostand;
        private System.Windows.Forms.Label labelAlter;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.ListBox listBoxPersonen;
        private System.Windows.Forms.ToolStripMenuItem xMLExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLImportToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
    }
}

