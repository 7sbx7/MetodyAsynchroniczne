namespace MetodyAsynchroniczne
{
    partial class WykonanieWlasnejMeody
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
            this.Wykonaj_BTN = new System.Windows.Forms.Button();
            this.task1_TB = new System.Windows.Forms.RichTextBox();
            this.task2_TB = new System.Windows.Forms.RichTextBox();
            this.task3_TB = new System.Windows.Forms.RichTextBox();
            this.czasWykonania_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wroc_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Wykonaj_BTN
            // 
            this.Wykonaj_BTN.Location = new System.Drawing.Point(12, 12);
            this.Wykonaj_BTN.Name = "Wykonaj_BTN";
            this.Wykonaj_BTN.Size = new System.Drawing.Size(75, 23);
            this.Wykonaj_BTN.TabIndex = 0;
            this.Wykonaj_BTN.Text = "Wykonaj";
            this.Wykonaj_BTN.UseVisualStyleBackColor = true;
            this.Wykonaj_BTN.Click += new System.EventHandler(this.Wykonaj_BTN_Click);
            // 
            // task1_TB
            // 
            this.task1_TB.Location = new System.Drawing.Point(12, 160);
            this.task1_TB.Name = "task1_TB";
            this.task1_TB.Size = new System.Drawing.Size(212, 278);
            this.task1_TB.TabIndex = 1;
            this.task1_TB.Text = "";
            // 
            // task2_TB
            // 
            this.task2_TB.Location = new System.Drawing.Point(288, 160);
            this.task2_TB.Name = "task2_TB";
            this.task2_TB.Size = new System.Drawing.Size(212, 278);
            this.task2_TB.TabIndex = 1;
            this.task2_TB.Text = "";
            // 
            // task3_TB
            // 
            this.task3_TB.Location = new System.Drawing.Point(566, 160);
            this.task3_TB.Name = "task3_TB";
            this.task3_TB.Size = new System.Drawing.Size(212, 278);
            this.task3_TB.TabIndex = 1;
            this.task3_TB.Text = "";
            // 
            // czasWykonania_TB
            // 
            this.czasWykonania_TB.Location = new System.Drawing.Point(222, 49);
            this.czasWykonania_TB.Name = "czasWykonania_TB";
            this.czasWykonania_TB.Size = new System.Drawing.Size(369, 20);
            this.czasWykonania_TB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Czas wykonania";
            // 
            // wroc_BTN
            // 
            this.wroc_BTN.Location = new System.Drawing.Point(703, 12);
            this.wroc_BTN.Name = "wroc_BTN";
            this.wroc_BTN.Size = new System.Drawing.Size(75, 23);
            this.wroc_BTN.TabIndex = 4;
            this.wroc_BTN.Text = "Wroc";
            this.wroc_BTN.UseVisualStyleBackColor = true;
            this.wroc_BTN.Click += new System.EventHandler(this.wroc_BTN_Click);
            // 
            // WykonanieWlasnejMeody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wroc_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.czasWykonania_TB);
            this.Controls.Add(this.task3_TB);
            this.Controls.Add(this.task2_TB);
            this.Controls.Add(this.task1_TB);
            this.Controls.Add(this.Wykonaj_BTN);
            this.Name = "WykonanieWlasnejMeody";
            this.Text = "WykonanieWlasnejMeody";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Wykonaj_BTN;
        private System.Windows.Forms.RichTextBox task1_TB;
        private System.Windows.Forms.RichTextBox task2_TB;
        private System.Windows.Forms.RichTextBox task3_TB;
        private System.Windows.Forms.TextBox czasWykonania_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wroc_BTN;
    }
}