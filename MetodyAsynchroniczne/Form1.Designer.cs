﻿namespace MetodyAsynchroniczne
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
            this.pobierz_BTN = new System.Windows.Forms.Button();
            this.wynik_TB = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Pobierz2_BTN = new System.Windows.Forms.Button();
            this.link1_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zad4_BTN = new System.Windows.Forms.Button();
            this.wlasna_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pobierz_BTN
            // 
            this.pobierz_BTN.Location = new System.Drawing.Point(16, 63);
            this.pobierz_BTN.Name = "pobierz_BTN";
            this.pobierz_BTN.Size = new System.Drawing.Size(75, 23);
            this.pobierz_BTN.TabIndex = 0;
            this.pobierz_BTN.Text = "Pobierz";
            this.pobierz_BTN.UseVisualStyleBackColor = true;
            this.pobierz_BTN.Click += new System.EventHandler(this.Pobierz_BTN_Click);
            // 
            // wynik_TB
            // 
            this.wynik_TB.Location = new System.Drawing.Point(421, 26);
            this.wynik_TB.Name = "wynik_TB";
            this.wynik_TB.Size = new System.Drawing.Size(367, 583);
            this.wynik_TB.TabIndex = 1;
            this.wynik_TB.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "https://github.com/7sbx7/MetodyAsynchroniczne",
            "https://www.altcontroldelete.pl/artykuly/httpclient-rownolegle-pobieranie-danych-" +
                "z-roznych-zrodel/",
            "http://www.ubercarcare.pl/index.php?id_product=24&id_product_attribute=0&rewrite=" +
                "ambicar-classic-elegance-dyfuzor&controller=product",
            "http://basewin.pl/xpklucze.html",
            "https://docs.microsoft.com/pl-pl/dotnet/framework/wpf/controls/how-to-choose-betw" +
                "een-stackpanel-and-dockpanel"});
            this.listBox1.Location = new System.Drawing.Point(12, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Pobierz2_BTN
            // 
            this.Pobierz2_BTN.Location = new System.Drawing.Point(138, 293);
            this.Pobierz2_BTN.Name = "Pobierz2_BTN";
            this.Pobierz2_BTN.Size = new System.Drawing.Size(75, 23);
            this.Pobierz2_BTN.TabIndex = 3;
            this.Pobierz2_BTN.Text = "Pobierz2";
            this.Pobierz2_BTN.UseVisualStyleBackColor = true;
            this.Pobierz2_BTN.Click += new System.EventHandler(this.Pobierz2_BTN_Click);
            // 
            // link1_TB
            // 
            this.link1_TB.Location = new System.Drawing.Point(12, 37);
            this.link1_TB.Name = "link1_TB";
            this.link1_TB.Size = new System.Drawing.Size(368, 20);
            this.link1_TB.TabIndex = 4;
            this.link1_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wpisz link do zad 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // zad4_BTN
            // 
            this.zad4_BTN.Location = new System.Drawing.Point(12, 129);
            this.zad4_BTN.Name = "zad4_BTN";
            this.zad4_BTN.Size = new System.Drawing.Size(79, 23);
            this.zad4_BTN.TabIndex = 7;
            this.zad4_BTN.Text = "zad 4";
            this.zad4_BTN.UseVisualStyleBackColor = true;
            this.zad4_BTN.Click += new System.EventHandler(this.zad4_BTN_Click);
            // 
            // wlasna_BTN
            // 
            this.wlasna_BTN.Location = new System.Drawing.Point(12, 478);
            this.wlasna_BTN.Name = "wlasna_BTN";
            this.wlasna_BTN.Size = new System.Drawing.Size(124, 23);
            this.wlasna_BTN.TabIndex = 8;
            this.wlasna_BTN.Text = "Wlasna metoda";
            this.wlasna_BTN.UseVisualStyleBackColor = true;
            this.wlasna_BTN.Click += new System.EventHandler(this.wlasna_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.wlasna_BTN);
            this.Controls.Add(this.zad4_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link1_TB);
            this.Controls.Add(this.Pobierz2_BTN);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.wynik_TB);
            this.Controls.Add(this.pobierz_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pobierz_BTN;
        private System.Windows.Forms.RichTextBox wynik_TB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Pobierz2_BTN;
        private System.Windows.Forms.TextBox link1_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zad4_BTN;
        private System.Windows.Forms.Button wlasna_BTN;
    }
}

