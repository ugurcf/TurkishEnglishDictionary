namespace Kelime_Ezber
{
    partial class Formİstatistik
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
            this.lblToplamSkor = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblTestSayii = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.lblHavuzSayisi = new System.Windows.Forms.Label();
            this.lblOgrenilenSayisi = new System.Windows.Forms.Label();
            this.lblTestKelimeSayisi = new System.Windows.Forms.Label();
            this.lblOgenilceklerSayi = new System.Windows.Forms.Label();
            this.lblİstatistikler = new System.Windows.Forms.Label();
            this.cmbZaman = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblZamanOgrenilen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblToplamSkor
            // 
            this.lblToplamSkor.AutoSize = true;
            this.lblToplamSkor.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamSkor.Location = new System.Drawing.Point(244, 287);
            this.lblToplamSkor.Name = "lblToplamSkor";
            this.lblToplamSkor.Size = new System.Drawing.Size(110, 16);
            this.lblToplamSkor.TabIndex = 25;
            this.lblToplamSkor.Text = "Toplam Skor:";
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
            // lblTestSayii
            // 
            this.lblTestSayii.AutoSize = true;
            this.lblTestSayii.Location = new System.Drawing.Point(9, 234);
            this.lblTestSayii.Name = "lblTestSayii";
            this.lblTestSayii.Size = new System.Drawing.Size(93, 13);
            this.lblTestSayii.TabIndex = 10;
            this.lblTestSayii.Text = "Girilen Test Sayısı:";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(8, 203);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(107, 13);
            this.lblYanlis.TabIndex = 9;
            this.lblYanlis.Text = "Toplam yanlış cevap:";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(8, 174);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(108, 13);
            this.lblDogru.TabIndex = 8;
            this.lblDogru.Text = "Toplam doğru cevap:";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(8, 266);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(129, 13);
            this.lblZaman.TabIndex = 7;
            this.lblZaman.Text = "Testte geçirdiğiniz zaman:";
            // 
            // lblHavuzSayisi
            // 
            this.lblHavuzSayisi.AutoSize = true;
            this.lblHavuzSayisi.Location = new System.Drawing.Point(8, 76);
            this.lblHavuzSayisi.Name = "lblHavuzSayisi";
            this.lblHavuzSayisi.Size = new System.Drawing.Size(122, 13);
            this.lblHavuzSayisi.TabIndex = 6;
            this.lblHavuzSayisi.Text = "Havuzdaki kelime sayısı:";
            // 
            // lblOgrenilenSayisi
            // 
            this.lblOgrenilenSayisi.AutoSize = true;
            this.lblOgrenilenSayisi.Location = new System.Drawing.Point(9, 127);
            this.lblOgrenilenSayisi.Name = "lblOgrenilenSayisi";
            this.lblOgrenilenSayisi.Size = new System.Drawing.Size(116, 13);
            this.lblOgrenilenSayisi.TabIndex = 5;
            this.lblOgrenilenSayisi.Text = "Öğrenilen kelime sayısı:";
            // 
            // lblTestKelimeSayisi
            // 
            this.lblTestKelimeSayisi.AutoSize = true;
            this.lblTestKelimeSayisi.Location = new System.Drawing.Point(9, 151);
            this.lblTestKelimeSayisi.Name = "lblTestKelimeSayisi";
            this.lblTestKelimeSayisi.Size = new System.Drawing.Size(109, 13);
            this.lblTestKelimeSayisi.TabIndex = 3;
            this.lblTestKelimeSayisi.Text = "Testteki kelime sayısı:";
            // 
            // lblOgenilceklerSayi
            // 
            this.lblOgenilceklerSayi.AutoSize = true;
            this.lblOgenilceklerSayi.Location = new System.Drawing.Point(8, 101);
            this.lblOgenilceklerSayi.Name = "lblOgenilceklerSayi";
            this.lblOgenilceklerSayi.Size = new System.Drawing.Size(128, 13);
            this.lblOgenilceklerSayi.TabIndex = 1;
            this.lblOgenilceklerSayi.Text = "Öğrenilecek kelime sayısı:";
            // 
            // lblİstatistikler
            // 
            this.lblİstatistikler.AutoSize = true;
            this.lblİstatistikler.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblİstatistikler.Location = new System.Drawing.Point(194, 13);
            this.lblİstatistikler.Name = "lblİstatistikler";
            this.lblİstatistikler.Size = new System.Drawing.Size(149, 37);
            this.lblİstatistikler.TabIndex = 0;
            this.lblİstatistikler.Text = "İstatistikler";
            // 
            // cmbZaman
            // 
            this.cmbZaman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZaman.FormattingEnabled = true;
            this.cmbZaman.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            ""});
            this.cmbZaman.Location = new System.Drawing.Point(306, 98);
            this.cmbZaman.Name = "cmbZaman";
            this.cmbZaman.Size = new System.Drawing.Size(121, 21);
            this.cmbZaman.TabIndex = 26;
            this.cmbZaman.SelectedIndexChanged += new System.EventHandler(this.cmbZaman_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Bir zaman seçin";
            // 
            // lblZamanOgrenilen
            // 
            this.lblZamanOgrenilen.AutoSize = true;
            this.lblZamanOgrenilen.Location = new System.Drawing.Point(287, 151);
            this.lblZamanOgrenilen.Name = "lblZamanOgrenilen";
            this.lblZamanOgrenilen.Size = new System.Drawing.Size(0, 13);
            this.lblZamanOgrenilen.TabIndex = 28;
            // 
            // Formİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(491, 330);
            this.Controls.Add(this.lblZamanOgrenilen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbZaman);
            this.Controls.Add(this.lblToplamSkor);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblTestSayii);
            this.Controls.Add(this.lblİstatistikler);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblOgenilceklerSayi);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblTestKelimeSayisi);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblOgrenilenSayisi);
            this.Controls.Add(this.lblHavuzSayisi);
            this.Name = "Formİstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.Formİstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToplamSkor;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblTestSayii;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label lblHavuzSayisi;
        private System.Windows.Forms.Label lblOgrenilenSayisi;
        private System.Windows.Forms.Label lblTestKelimeSayisi;
        private System.Windows.Forms.Label lblOgenilceklerSayi;
        private System.Windows.Forms.Label lblİstatistikler;
        private System.Windows.Forms.ComboBox cmbZaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblZamanOgrenilen;
    }
}