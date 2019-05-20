namespace Kelime_Ezber
{
    partial class FormKelimeEkleme
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblKelimeTür = new System.Windows.Forms.Label();
            this.cmbKelimeTürü = new System.Windows.Forms.ComboBox();
            this.lblKelimeİngilizce = new System.Windows.Forms.Label();
            this.txtKelimeİngilizce = new System.Windows.Forms.TextBox();
            this.txtKelimeTürkçe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKelimeTürkçe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKelimeDurumu = new System.Windows.Forms.ComboBox();
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
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(70, 274);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(142, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblKelimeTür
            // 
            this.lblKelimeTür.AutoSize = true;
            this.lblKelimeTür.Location = new System.Drawing.Point(21, 177);
            this.lblKelimeTür.Name = "lblKelimeTür";
            this.lblKelimeTür.Size = new System.Drawing.Size(77, 13);
            this.lblKelimeTür.TabIndex = 12;
            this.lblKelimeTür.Text = "Kelimenin Türü";
            // 
            // cmbKelimeTürü
            // 
            this.cmbKelimeTürü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKelimeTürü.FormattingEnabled = true;
            this.cmbKelimeTürü.Items.AddRange(new object[] {
            "İsim",
            "Sıfat",
            "Fiil",
            "Fiilimsi",
            "Zamir",
            "Zarf",
            "Edat",
            "Bağlaç",
            "Ünlem"});
            this.cmbKelimeTürü.Location = new System.Drawing.Point(144, 176);
            this.cmbKelimeTürü.Name = "cmbKelimeTürü";
            this.cmbKelimeTürü.Size = new System.Drawing.Size(100, 21);
            this.cmbKelimeTürü.TabIndex = 11;
            // 
            // lblKelimeİngilizce
            // 
            this.lblKelimeİngilizce.AutoSize = true;
            this.lblKelimeİngilizce.Location = new System.Drawing.Point(20, 144);
            this.lblKelimeİngilizce.Name = "lblKelimeİngilizce";
            this.lblKelimeİngilizce.Size = new System.Drawing.Size(100, 13);
            this.lblKelimeİngilizce.TabIndex = 10;
            this.lblKelimeİngilizce.Text = "Kelimenin İngilizcesi";
            // 
            // txtKelimeİngilizce
            // 
            this.txtKelimeİngilizce.Location = new System.Drawing.Point(144, 144);
            this.txtKelimeİngilizce.MaxLength = 100;
            this.txtKelimeİngilizce.Name = "txtKelimeİngilizce";
            this.txtKelimeİngilizce.Size = new System.Drawing.Size(100, 20);
            this.txtKelimeİngilizce.TabIndex = 9;
            this.txtKelimeİngilizce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKelimeİngilizce_KeyPress);
            // 
            // txtKelimeTürkçe
            // 
            this.txtKelimeTürkçe.Location = new System.Drawing.Point(144, 112);
            this.txtKelimeTürkçe.MaxLength = 100;
            this.txtKelimeTürkçe.Name = "txtKelimeTürkçe";
            this.txtKelimeTürkçe.Size = new System.Drawing.Size(100, 20);
            this.txtKelimeTürkçe.TabIndex = 8;
            this.txtKelimeTürkçe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKelimeTürkçe_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kelime Ekleme";
            // 
            // lblKelimeTürkçe
            // 
            this.lblKelimeTürkçe.AutoSize = true;
            this.lblKelimeTürkçe.Location = new System.Drawing.Point(20, 115);
            this.lblKelimeTürkçe.Name = "lblKelimeTürkçe";
            this.lblKelimeTürkçe.Size = new System.Drawing.Size(96, 13);
            this.lblKelimeTürkçe.TabIndex = 6;
            this.lblKelimeTürkçe.Text = "Kelimenin Türkçesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kelimenin Durumu";
            // 
            // cmbKelimeDurumu
            // 
            this.cmbKelimeDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKelimeDurumu.FormattingEnabled = true;
            this.cmbKelimeDurumu.Items.AddRange(new object[] {
            "Havuz",
            "Öğrenilecek",
            "Test"});
            this.cmbKelimeDurumu.Location = new System.Drawing.Point(144, 209);
            this.cmbKelimeDurumu.Name = "cmbKelimeDurumu";
            this.cmbKelimeDurumu.Size = new System.Drawing.Size(100, 21);
            this.cmbKelimeDurumu.TabIndex = 26;
            // 
            // FormKelimeEkleme
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(277, 319);
            this.Controls.Add(this.cmbKelimeDurumu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblKelimeTürkçe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKelimeTür);
            this.Controls.Add(this.txtKelimeTürkçe);
            this.Controls.Add(this.cmbKelimeTürü);
            this.Controls.Add(this.txtKelimeİngilizce);
            this.Controls.Add(this.lblKelimeİngilizce);
            this.Name = "FormKelimeEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblKelimeTür;
        private System.Windows.Forms.ComboBox cmbKelimeTürü;
        private System.Windows.Forms.Label lblKelimeİngilizce;
        private System.Windows.Forms.TextBox txtKelimeİngilizce;
        private System.Windows.Forms.TextBox txtKelimeTürkçe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKelimeTürkçe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKelimeDurumu;
    }
}