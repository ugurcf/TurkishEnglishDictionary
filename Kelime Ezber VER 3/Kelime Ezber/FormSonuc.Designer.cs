namespace Kelime_Ezber
{
    partial class FormSonuc
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
            this.lblSkorr = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblYanlisCarpi = new System.Windows.Forms.Label();
            this.lblDogruTik = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnDevam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSkorr
            // 
            this.lblSkorr.AutoSize = true;
            this.lblSkorr.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkorr.ForeColor = System.Drawing.Color.Black;
            this.lblSkorr.Location = new System.Drawing.Point(223, 264);
            this.lblSkorr.Name = "lblSkorr";
            this.lblSkorr.Size = new System.Drawing.Size(80, 39);
            this.lblSkorr.TabIndex = 17;
            this.lblSkorr.Text = "999";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Skor:";
            // 
            // lblYanlisCarpi
            // 
            this.lblYanlisCarpi.AutoSize = true;
            this.lblYanlisCarpi.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYanlisCarpi.ForeColor = System.Drawing.Color.Red;
            this.lblYanlisCarpi.Location = new System.Drawing.Point(223, 168);
            this.lblYanlisCarpi.Name = "lblYanlisCarpi";
            this.lblYanlisCarpi.Size = new System.Drawing.Size(69, 39);
            this.lblYanlisCarpi.TabIndex = 15;
            this.lblYanlisCarpi.Text = "4 ✗";
            // 
            // lblDogruTik
            // 
            this.lblDogruTik.AutoSize = true;
            this.lblDogruTik.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogruTik.ForeColor = System.Drawing.Color.Green;
            this.lblDogruTik.Location = new System.Drawing.Point(223, 98);
            this.lblDogruTik.Name = "lblDogruTik";
            this.lblDogruTik.Size = new System.Drawing.Size(67, 39);
            this.lblDogruTik.TabIndex = 14;
            this.lblDogruTik.Text = "4 ✓";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(129, 20);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(89, 37);
            this.lblSonuc.TabIndex = 13;
            this.lblSonuc.Text = "Sonuc";
            // 
            // btnDevam
            // 
            this.btnDevam.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDevam.Location = new System.Drawing.Point(125, 332);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(75, 23);
            this.btnDevam.TabIndex = 12;
            this.btnDevam.Text = "Devam";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = " Toplam yanlış sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Toplam doğru sayısı :";
            // 
            // FormSonuc
            // 
            this.AcceptButton = this.btnDevam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDevam;
            this.ClientSize = new System.Drawing.Size(334, 382);
            this.Controls.Add(this.lblSkorr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblYanlisCarpi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDogruTik);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.lblSonuc);
            this.Name = "FormSonuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonuç";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblDogruTik;
        public System.Windows.Forms.Label lblYanlisCarpi;
        public System.Windows.Forms.Label lblSkorr;
    }
}