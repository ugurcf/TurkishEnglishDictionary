namespace Kelime_Ezber
{
    partial class FormAyarDegistirme
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
            this.btnAyarDevam = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAyarTekrarŞifre = new System.Windows.Forms.TextBox();
            this.lblTekrar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAyarŞifre = new System.Windows.Forms.TextBox();
            this.txtAyarAd = new System.Windows.Forms.TextBox();
            this.lblAyarlar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(36, 37);
            this.btnGeri.TabIndex = 31;
            this.btnGeri.Text = "↶";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnAyarDevam
            // 
            this.btnAyarDevam.Location = new System.Drawing.Point(106, 223);
            this.btnAyarDevam.Name = "btnAyarDevam";
            this.btnAyarDevam.Size = new System.Drawing.Size(75, 23);
            this.btnAyarDevam.TabIndex = 30;
            this.btnAyarDevam.Text = "Devam";
            this.btnAyarDevam.UseVisualStyleBackColor = true;
            this.btnAyarDevam.Click += new System.EventHandler(this.btnAyarDevam_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Şifre";
            // 
            // txtAyarTekrarŞifre
            // 
            this.txtAyarTekrarŞifre.Location = new System.Drawing.Point(123, 155);
            this.txtAyarTekrarŞifre.MaxLength = 10;
            this.txtAyarTekrarŞifre.Name = "txtAyarTekrarŞifre";
            this.txtAyarTekrarŞifre.PasswordChar = '•';
            this.txtAyarTekrarŞifre.Size = new System.Drawing.Size(100, 20);
            this.txtAyarTekrarŞifre.TabIndex = 28;
            this.txtAyarTekrarŞifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAyarTekrarŞifre_KeyPress);
            // 
            // lblTekrar
            // 
            this.lblTekrar.AutoSize = true;
            this.lblTekrar.Location = new System.Drawing.Point(43, 158);
            this.lblTekrar.Name = "lblTekrar";
            this.lblTekrar.Size = new System.Drawing.Size(68, 13);
            this.lblTekrar.TabIndex = 27;
            this.lblTekrar.Text = "Şifre (Tekrar)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ad";
            // 
            // txtAyarŞifre
            // 
            this.txtAyarŞifre.Location = new System.Drawing.Point(123, 118);
            this.txtAyarŞifre.MaxLength = 10;
            this.txtAyarŞifre.Name = "txtAyarŞifre";
            this.txtAyarŞifre.PasswordChar = '•';
            this.txtAyarŞifre.Size = new System.Drawing.Size(100, 20);
            this.txtAyarŞifre.TabIndex = 25;
            this.txtAyarŞifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAyarŞifre_KeyPress);
            // 
            // txtAyarAd
            // 
            this.txtAyarAd.Location = new System.Drawing.Point(123, 79);
            this.txtAyarAd.MaxLength = 13;
            this.txtAyarAd.Name = "txtAyarAd";
            this.txtAyarAd.Size = new System.Drawing.Size(100, 20);
            this.txtAyarAd.TabIndex = 24;
            this.txtAyarAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAyarAd_KeyPress);
            // 
            // lblAyarlar
            // 
            this.lblAyarlar.AutoSize = true;
            this.lblAyarlar.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyarlar.Location = new System.Drawing.Point(102, 23);
            this.lblAyarlar.Name = "lblAyarlar";
            this.lblAyarlar.Size = new System.Drawing.Size(42, 24);
            this.lblAyarlar.TabIndex = 23;
            this.lblAyarlar.Text = "----";
            // 
            // FormAyarDegistirme
            // 
            this.AcceptButton = this.btnAyarDevam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(281, 278);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnAyarDevam);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblAyarlar);
            this.Controls.Add(this.txtAyarTekrarŞifre);
            this.Controls.Add(this.txtAyarAd);
            this.Controls.Add(this.lblTekrar);
            this.Controls.Add(this.txtAyarŞifre);
            this.Controls.Add(this.label11);
            this.Name = "FormAyarDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayar Değiştirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnAyarDevam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtAyarŞifre;
        public System.Windows.Forms.TextBox txtAyarAd;
        public System.Windows.Forms.TextBox txtAyarTekrarŞifre;
        public System.Windows.Forms.Label lblTekrar;
        public System.Windows.Forms.Label lblAyarlar;
    }
}