namespace Kelime_Ezber
{
    partial class FormKullaniciAyarlari
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnKullanıcıSil = new System.Windows.Forms.Button();
            this.btnKullanıcıEkle = new System.Windows.Forms.Button();
            this.btnKullanıcıDeğiştir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(36, 37);
            this.btnGeri.TabIndex = 23;
            this.btnGeri.Text = "↶";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 37);
            this.label10.TabIndex = 22;
            this.label10.Text = "Kullanıcı Ayarları";
            // 
            // btnKullanıcıSil
            // 
            this.btnKullanıcıSil.Location = new System.Drawing.Point(156, 148);
            this.btnKullanıcıSil.Name = "btnKullanıcıSil";
            this.btnKullanıcıSil.Size = new System.Drawing.Size(98, 23);
            this.btnKullanıcıSil.TabIndex = 2;
            this.btnKullanıcıSil.Text = "Kullanıcı Sil";
            this.btnKullanıcıSil.UseVisualStyleBackColor = true;
            this.btnKullanıcıSil.Click += new System.EventHandler(this.btnKullanıcıSil_Click);
            // 
            // btnKullanıcıEkle
            // 
            this.btnKullanıcıEkle.Location = new System.Drawing.Point(156, 111);
            this.btnKullanıcıEkle.Name = "btnKullanıcıEkle";
            this.btnKullanıcıEkle.Size = new System.Drawing.Size(98, 23);
            this.btnKullanıcıEkle.TabIndex = 1;
            this.btnKullanıcıEkle.Text = "Kullanıcı Ekle";
            this.btnKullanıcıEkle.UseVisualStyleBackColor = true;
            this.btnKullanıcıEkle.Click += new System.EventHandler(this.btnKullanıcıEkle_Click);
            // 
            // btnKullanıcıDeğiştir
            // 
            this.btnKullanıcıDeğiştir.Location = new System.Drawing.Point(156, 67);
            this.btnKullanıcıDeğiştir.Name = "btnKullanıcıDeğiştir";
            this.btnKullanıcıDeğiştir.Size = new System.Drawing.Size(98, 23);
            this.btnKullanıcıDeğiştir.TabIndex = 0;
            this.btnKullanıcıDeğiştir.Text = "Kullanıcı Değiştir";
            this.btnKullanıcıDeğiştir.UseVisualStyleBackColor = true;
            this.btnKullanıcıDeğiştir.Click += new System.EventHandler(this.btnKullanıcıDeğiştir_Click);
            // 
            // FormKullaniciAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(408, 209);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnKullanıcıSil);
            this.Controls.Add(this.btnKullanıcıDeğiştir);
            this.Controls.Add(this.btnKullanıcıEkle);
            this.Name = "FormKullaniciAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ayarları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKullanıcıSil;
        private System.Windows.Forms.Button btnKullanıcıEkle;
        private System.Windows.Forms.Button btnKullanıcıDeğiştir;
    }
}