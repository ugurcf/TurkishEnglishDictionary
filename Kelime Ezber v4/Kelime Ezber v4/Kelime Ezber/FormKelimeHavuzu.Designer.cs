﻿namespace Kelime_Ezber
{
    partial class FormKelimeHavuzu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelimeHavuzu));
            this.btnKelimeSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.listOgrenilen = new System.Windows.Forms.ListBox();
            this.listTest = new System.Windows.Forms.ListBox();
            this.listOgrenilcekler = new System.Windows.Forms.ListBox();
            this.listHavuz = new System.Windows.Forms.ListBox();
            this.btnGerilet = new System.Windows.Forms.Button();
            this.btnİlerlet = new System.Windows.Forms.Button();
            this.lblOgrenilen = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblOgrenilcekler = new System.Windows.Forms.Label();
            this.lblHavuzdakiler = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKelimeSil
            // 
            this.btnKelimeSil.Image = ((System.Drawing.Image)(resources.GetObject("btnKelimeSil.Image")));
            this.btnKelimeSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKelimeSil.Location = new System.Drawing.Point(790, 339);
            this.btnKelimeSil.Name = "btnKelimeSil";
            this.btnKelimeSil.Size = new System.Drawing.Size(75, 23);
            this.btnKelimeSil.TabIndex = 25;
            this.btnKelimeSil.Text = "Sil";
            this.btnKelimeSil.UseVisualStyleBackColor = true;
            this.btnKelimeSil.Click += new System.EventHandler(this.btnKelimeSil_Click);
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
            // listOgrenilen
            // 
            this.listOgrenilen.BackColor = System.Drawing.SystemColors.Control;
            this.listOgrenilen.FormattingEnabled = true;
            this.listOgrenilen.Location = new System.Drawing.Point(681, 82);
            this.listOgrenilen.Name = "listOgrenilen";
            this.listOgrenilen.Size = new System.Drawing.Size(184, 225);
            this.listOgrenilen.Sorted = true;
            this.listOgrenilen.TabIndex = 21;
            this.listOgrenilen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listOgrenilen_MouseClick);
            // 
            // listTest
            // 
            this.listTest.BackColor = System.Drawing.SystemColors.Control;
            this.listTest.FormattingEnabled = true;
            this.listTest.Location = new System.Drawing.Point(483, 82);
            this.listTest.Name = "listTest";
            this.listTest.Size = new System.Drawing.Size(184, 225);
            this.listTest.Sorted = true;
            this.listTest.TabIndex = 20;
            this.listTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listTest_MouseClick);
            // 
            // listOgrenilcekler
            // 
            this.listOgrenilcekler.BackColor = System.Drawing.SystemColors.Control;
            this.listOgrenilcekler.FormattingEnabled = true;
            this.listOgrenilcekler.Location = new System.Drawing.Point(277, 82);
            this.listOgrenilcekler.Name = "listOgrenilcekler";
            this.listOgrenilcekler.Size = new System.Drawing.Size(184, 225);
            this.listOgrenilcekler.Sorted = true;
            this.listOgrenilcekler.TabIndex = 19;
            this.listOgrenilcekler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listOgrenilcekler_MouseClick);
            // 
            // listHavuz
            // 
            this.listHavuz.BackColor = System.Drawing.SystemColors.Control;
            this.listHavuz.FormattingEnabled = true;
            this.listHavuz.Location = new System.Drawing.Point(68, 82);
            this.listHavuz.Name = "listHavuz";
            this.listHavuz.Size = new System.Drawing.Size(184, 225);
            this.listHavuz.Sorted = true;
            this.listHavuz.TabIndex = 18;
            this.listHavuz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listHavuz_MouseClick);
            // 
            // btnGerilet
            // 
            this.btnGerilet.Image = ((System.Drawing.Image)(resources.GetObject("btnGerilet.Image")));
            this.btnGerilet.Location = new System.Drawing.Point(386, 324);
            this.btnGerilet.Name = "btnGerilet";
            this.btnGerilet.Size = new System.Drawing.Size(75, 53);
            this.btnGerilet.TabIndex = 15;
            this.btnGerilet.Tag = "dadaw";
            this.btnGerilet.UseVisualStyleBackColor = true;
            this.btnGerilet.Click += new System.EventHandler(this.btnGerilet_Click);
            // 
            // btnİlerlet
            // 
            this.btnİlerlet.Image = ((System.Drawing.Image)(resources.GetObject("btnİlerlet.Image")));
            this.btnİlerlet.Location = new System.Drawing.Point(483, 324);
            this.btnİlerlet.Name = "btnİlerlet";
            this.btnİlerlet.Size = new System.Drawing.Size(75, 53);
            this.btnİlerlet.TabIndex = 14;
            this.btnİlerlet.UseVisualStyleBackColor = true;
            this.btnİlerlet.Click += new System.EventHandler(this.btnİlerlet_Click);
            // 
            // lblOgrenilen
            // 
            this.lblOgrenilen.AutoSize = true;
            this.lblOgrenilen.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrenilen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOgrenilen.Location = new System.Drawing.Point(703, 12);
            this.lblOgrenilen.Name = "lblOgrenilen";
            this.lblOgrenilen.Size = new System.Drawing.Size(135, 37);
            this.lblOgrenilen.TabIndex = 7;
            this.lblOgrenilen.Text = "Ögrenilen";
            this.lblOgrenilen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTest.Location = new System.Drawing.Point(535, 12);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(70, 37);
            this.lblTest.TabIndex = 6;
            this.lblTest.Text = "Test";
            this.lblTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOgrenilcekler
            // 
            this.lblOgrenilcekler.AutoSize = true;
            this.lblOgrenilcekler.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrenilcekler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOgrenilcekler.Location = new System.Drawing.Point(275, 12);
            this.lblOgrenilcekler.Name = "lblOgrenilcekler";
            this.lblOgrenilcekler.Size = new System.Drawing.Size(186, 37);
            this.lblOgrenilcekler.TabIndex = 5;
            this.lblOgrenilcekler.Text = "Ögrenilecekler";
            this.lblOgrenilcekler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHavuzdakiler
            // 
            this.lblHavuzdakiler.AutoSize = true;
            this.lblHavuzdakiler.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHavuzdakiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHavuzdakiler.Location = new System.Drawing.Point(61, 12);
            this.lblHavuzdakiler.Name = "lblHavuzdakiler";
            this.lblHavuzdakiler.Size = new System.Drawing.Size(184, 37);
            this.lblHavuzdakiler.TabIndex = 4;
            this.lblHavuzdakiler.Text = "Havuzdakiler";
            this.lblHavuzdakiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblOgrenilcekler);
            this.panel1.Controls.Add(this.lblHavuzdakiler);
            this.panel1.Controls.Add(this.lblTest);
            this.panel1.Controls.Add(this.lblOgrenilen);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 64);
            this.panel1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(844, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FormKelimeHavuzu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(930, 387);
            this.Controls.Add(this.btnKelimeSil);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.listOgrenilen);
            this.Controls.Add(this.listTest);
            this.Controls.Add(this.listOgrenilcekler);
            this.Controls.Add(this.listHavuz);
            this.Controls.Add(this.btnİlerlet);
            this.Controls.Add(this.btnGerilet);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKelimeHavuzu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Havuzu";
            this.Load += new System.EventHandler(this.FormKelimeHavuzu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKelimeSil;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnGerilet;
        private System.Windows.Forms.Button btnİlerlet;
        private System.Windows.Forms.Label lblOgrenilen;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblOgrenilcekler;
        private System.Windows.Forms.Label lblHavuzdakiler;
        public System.Windows.Forms.ListBox listOgrenilen;
        public System.Windows.Forms.ListBox listTest;
        public System.Windows.Forms.ListBox listOgrenilcekler;
        public System.Windows.Forms.ListBox listHavuz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}