namespace Kelime_Ezber
{
    partial class FormSozluk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSozluk));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblİstatistikler = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtIngilizcesi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTuru = new System.Windows.Forms.TextBox();
            this.txtDurumu = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTurkcesi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblİstatistikler);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 77);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(405, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 84);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblİstatistikler
            // 
            this.lblİstatistikler.AutoSize = true;
            this.lblİstatistikler.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblİstatistikler.Location = new System.Drawing.Point(200, 14);
            this.lblİstatistikler.Name = "lblİstatistikler";
            this.lblİstatistikler.Size = new System.Drawing.Size(99, 37);
            this.lblİstatistikler.TabIndex = 0;
            this.lblİstatistikler.Text = "Sözlük";
            // 
            // btnGeri
            // 
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(12, 13);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(36, 37);
            this.btnGeri.TabIndex = 24;
            this.btnGeri.Text = "↶";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(194, 100);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(121, 20);
            this.txtAra.TabIndex = 35;
            // 
            // txtIngilizcesi
            // 
            this.txtIngilizcesi.Location = new System.Drawing.Point(194, 186);
            this.txtIngilizcesi.Name = "txtIngilizcesi";
            this.txtIngilizcesi.ReadOnly = true;
            this.txtIngilizcesi.Size = new System.Drawing.Size(121, 20);
            this.txtIngilizcesi.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kelime girin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "İngilizcesi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Durumu:";
            // 
            // txtTuru
            // 
            this.txtTuru.Location = new System.Drawing.Point(194, 229);
            this.txtTuru.Name = "txtTuru";
            this.txtTuru.ReadOnly = true;
            this.txtTuru.Size = new System.Drawing.Size(121, 20);
            this.txtTuru.TabIndex = 41;
            // 
            // txtDurumu
            // 
            this.txtDurumu.Location = new System.Drawing.Point(194, 273);
            this.txtDurumu.Name = "txtDurumu";
            this.txtDurumu.ReadOnly = true;
            this.txtDurumu.Size = new System.Drawing.Size(121, 20);
            this.txtDurumu.TabIndex = 42;
            // 
            // btnAra
            // 
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.Location = new System.Drawing.Point(194, 323);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(121, 23);
            this.btnAra.TabIndex = 43;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Türkçesi:";
            // 
            // txtTurkcesi
            // 
            this.txtTurkcesi.Location = new System.Drawing.Point(194, 149);
            this.txtTurkcesi.Name = "txtTurkcesi";
            this.txtTurkcesi.ReadOnly = true;
            this.txtTurkcesi.Size = new System.Drawing.Size(121, 20);
            this.txtTurkcesi.TabIndex = 45;
            // 
            // FormSozluk
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(490, 376);
            this.Controls.Add(this.txtTurkcesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtDurumu);
            this.Controls.Add(this.txtTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngilizcesi);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSozluk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSozluk";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblİstatistikler;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TextBox txtIngilizcesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTuru;
        private System.Windows.Forms.TextBox txtDurumu;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTurkcesi;
    }
}