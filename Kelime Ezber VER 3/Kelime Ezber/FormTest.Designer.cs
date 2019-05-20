namespace Kelime_Ezber
{
    partial class FormTest
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblGecenSure = new System.Windows.Forms.Label();
            this.lblYanlısSayisiTest = new System.Windows.Forms.Label();
            this.lblDoğruSayisiTest = new System.Windows.Forms.Label();
            this.btnCevapla = new System.Windows.Forms.Button();
            this.rdioSecenek5 = new System.Windows.Forms.RadioButton();
            this.rdioSecenek4 = new System.Windows.Forms.RadioButton();
            this.rdioSecenek3 = new System.Windows.Forms.RadioButton();
            this.rdioSecenek2 = new System.Windows.Forms.RadioButton();
            this.rdioSecenek1 = new System.Windows.Forms.RadioButton();
            this.lblxSoru = new System.Windows.Forms.Label();
            this.lblTestOlma = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.Tasarım4 = new System.Windows.Forms.TextBox();
            this.Tasarım3 = new System.Windows.Forms.TextBox();
            this.Zamanlayıcı = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(36, 37);
            this.btnGeri.TabIndex = 24;
            this.btnGeri.Text = "↶";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblGecenSure
            // 
            this.lblGecenSure.AutoSize = true;
            this.lblGecenSure.Location = new System.Drawing.Point(375, 361);
            this.lblGecenSure.Name = "lblGecenSure";
            this.lblGecenSure.Size = new System.Drawing.Size(65, 13);
            this.lblGecenSure.TabIndex = 21;
            this.lblGecenSure.Text = "Geçen süre:";
            // 
            // lblYanlısSayisiTest
            // 
            this.lblYanlısSayisiTest.AutoSize = true;
            this.lblYanlısSayisiTest.Location = new System.Drawing.Point(24, 361);
            this.lblYanlısSayisiTest.Name = "lblYanlısSayisiTest";
            this.lblYanlısSayisiTest.Size = new System.Drawing.Size(78, 13);
            this.lblYanlısSayisiTest.TabIndex = 20;
            this.lblYanlısSayisiTest.Text = "✗ Yanlış sayısı:";
            // 
            // lblDoğruSayisiTest
            // 
            this.lblDoğruSayisiTest.AutoSize = true;
            this.lblDoğruSayisiTest.Location = new System.Drawing.Point(24, 332);
            this.lblDoğruSayisiTest.Name = "lblDoğruSayisiTest";
            this.lblDoğruSayisiTest.Size = new System.Drawing.Size(78, 13);
            this.lblDoğruSayisiTest.TabIndex = 19;
            this.lblDoğruSayisiTest.Text = "✓ Doğru sayısı:";
            // 
            // btnCevapla
            // 
            this.btnCevapla.Location = new System.Drawing.Point(172, 241);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(169, 23);
            this.btnCevapla.TabIndex = 18;
            this.btnCevapla.Text = "Cevapla";
            this.btnCevapla.UseVisualStyleBackColor = true;
            this.btnCevapla.Click += new System.EventHandler(this.btnCevapla_Click);
            // 
            // rdioSecenek5
            // 
            this.rdioSecenek5.AutoSize = true;
            this.rdioSecenek5.Location = new System.Drawing.Point(391, 180);
            this.rdioSecenek5.Name = "rdioSecenek5";
            this.rdioSecenek5.Size = new System.Drawing.Size(67, 17);
            this.rdioSecenek5.TabIndex = 17;
            this.rdioSecenek5.TabStop = true;
            this.rdioSecenek5.Text = "Constant";
            this.rdioSecenek5.UseVisualStyleBackColor = true;
            this.rdioSecenek5.CheckedChanged += new System.EventHandler(this.rdioSecenek5_CheckedChanged);
            // 
            // rdioSecenek4
            // 
            this.rdioSecenek4.AutoSize = true;
            this.rdioSecenek4.Location = new System.Drawing.Point(300, 180);
            this.rdioSecenek4.Name = "rdioSecenek4";
            this.rdioSecenek4.Size = new System.Drawing.Size(67, 17);
            this.rdioSecenek4.TabIndex = 16;
            this.rdioSecenek4.TabStop = true;
            this.rdioSecenek4.Text = "Constant";
            this.rdioSecenek4.UseVisualStyleBackColor = true;
            this.rdioSecenek4.CheckedChanged += new System.EventHandler(this.rdioSecenek4_CheckedChanged);
            // 
            // rdioSecenek3
            // 
            this.rdioSecenek3.AutoSize = true;
            this.rdioSecenek3.Location = new System.Drawing.Point(209, 180);
            this.rdioSecenek3.Name = "rdioSecenek3";
            this.rdioSecenek3.Size = new System.Drawing.Size(67, 17);
            this.rdioSecenek3.TabIndex = 15;
            this.rdioSecenek3.TabStop = true;
            this.rdioSecenek3.Text = "Constant";
            this.rdioSecenek3.UseVisualStyleBackColor = true;
            this.rdioSecenek3.CheckedChanged += new System.EventHandler(this.rdioSecenek3_CheckedChanged);
            // 
            // rdioSecenek2
            // 
            this.rdioSecenek2.AutoSize = true;
            this.rdioSecenek2.Location = new System.Drawing.Point(118, 180);
            this.rdioSecenek2.Name = "rdioSecenek2";
            this.rdioSecenek2.Size = new System.Drawing.Size(67, 17);
            this.rdioSecenek2.TabIndex = 14;
            this.rdioSecenek2.TabStop = true;
            this.rdioSecenek2.Text = "Constant";
            this.rdioSecenek2.UseVisualStyleBackColor = true;
            this.rdioSecenek2.CheckedChanged += new System.EventHandler(this.rdioSecenek2_CheckedChanged);
            // 
            // rdioSecenek1
            // 
            this.rdioSecenek1.AutoSize = true;
            this.rdioSecenek1.Location = new System.Drawing.Point(27, 180);
            this.rdioSecenek1.Name = "rdioSecenek1";
            this.rdioSecenek1.Size = new System.Drawing.Size(67, 17);
            this.rdioSecenek1.TabIndex = 13;
            this.rdioSecenek1.TabStop = true;
            this.rdioSecenek1.Text = "Constant";
            this.rdioSecenek1.UseVisualStyleBackColor = true;
            this.rdioSecenek1.CheckedChanged += new System.EventHandler(this.rdioSecenek1_CheckedChanged);
            // 
            // lblxSoru
            // 
            this.lblxSoru.AutoSize = true;
            this.lblxSoru.Location = new System.Drawing.Point(421, 30);
            this.lblxSoru.Name = "lblxSoru";
            this.lblxSoru.Size = new System.Drawing.Size(38, 13);
            this.lblxSoru.TabIndex = 11;
            this.lblxSoru.Text = "1.Soru";
            // 
            // lblTestOlma
            // 
            this.lblTestOlma.AutoSize = true;
            this.lblTestOlma.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestOlma.Location = new System.Drawing.Point(225, 6);
            this.lblTestOlma.Name = "lblTestOlma";
            this.lblTestOlma.Size = new System.Drawing.Size(70, 37);
            this.lblTestOlma.TabIndex = 10;
            this.lblTestOlma.Text = "Test";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblSoru.Location = new System.Drawing.Point(184, 101);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(141, 13);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "Kelimesinin İngilizcesi Nedir?";
            // 
            // Tasarım4
            // 
            this.Tasarım4.BackColor = System.Drawing.SystemColors.Highlight;
            this.Tasarım4.Enabled = false;
            this.Tasarım4.Location = new System.Drawing.Point(29, 77);
            this.Tasarım4.Multiline = true;
            this.Tasarım4.Name = "Tasarım4";
            this.Tasarım4.ReadOnly = true;
            this.Tasarım4.Size = new System.Drawing.Size(447, 60);
            this.Tasarım4.TabIndex = 12;
            // 
            // Tasarım3
            // 
            this.Tasarım3.Enabled = false;
            this.Tasarım3.Location = new System.Drawing.Point(12, 55);
            this.Tasarım3.Multiline = true;
            this.Tasarım3.Name = "Tasarım3";
            this.Tasarım3.ReadOnly = true;
            this.Tasarım3.Size = new System.Drawing.Size(483, 229);
            this.Tasarım3.TabIndex = 12;
            // 
            // Zamanlayıcı
            // 
            this.Zamanlayıcı.Interval = 1000;
            this.Zamanlayıcı.Tick += new System.EventHandler(this.Zamanlayıcı_Tick);
            // 
            // FormTest
            // 
            this.AcceptButton = this.btnCevapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(514, 394);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblGecenSure);
            this.Controls.Add(this.lblYanlısSayisiTest);
            this.Controls.Add(this.lblDoğruSayisiTest);
            this.Controls.Add(this.btnCevapla);
            this.Controls.Add(this.lblTestOlma);
            this.Controls.Add(this.rdioSecenek5);
            this.Controls.Add(this.rdioSecenek4);
            this.Controls.Add(this.rdioSecenek1);
            this.Controls.Add(this.rdioSecenek3);
            this.Controls.Add(this.rdioSecenek2);
            this.Controls.Add(this.lblxSoru);
            this.Controls.Add(this.Tasarım4);
            this.Controls.Add(this.Tasarım3);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTest_FormClosing);
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblGecenSure;
        private System.Windows.Forms.Label lblYanlısSayisiTest;
        private System.Windows.Forms.Label lblDoğruSayisiTest;
        private System.Windows.Forms.Button btnCevapla;
        private System.Windows.Forms.RadioButton rdioSecenek5;
        private System.Windows.Forms.RadioButton rdioSecenek4;
        private System.Windows.Forms.RadioButton rdioSecenek3;
        private System.Windows.Forms.RadioButton rdioSecenek2;
        private System.Windows.Forms.RadioButton rdioSecenek1;
        private System.Windows.Forms.Label lblxSoru;
        private System.Windows.Forms.Label lblTestOlma;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.TextBox Tasarım4;
        private System.Windows.Forms.TextBox Tasarım3;
        private System.Windows.Forms.Timer Zamanlayıcı;
    }
}