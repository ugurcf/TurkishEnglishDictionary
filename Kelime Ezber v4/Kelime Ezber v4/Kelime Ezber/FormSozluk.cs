using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Ezber
{
    public partial class FormSozluk : Form
    {
        public FormSozluk()
        {
            InitializeComponent();
        }
        Kullanıcı Oturum = SQL.GetInstance().OturumuVer();

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.IlkAcilis(false);
            anaSayfa.ShowDialog();
            this.Close();
        }

        private void BilgiDoldur(string ArananKelime)
        {
            if (ArananKelime == "")
            {
                MessageBox.Show("Bir kelime giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }             
            foreach(Kelime a in Oturum.kelimes)
            {
                if(ArananKelime.ToLower()==a.Turkce.ToLower() || ArananKelime.ToLower()==a.Ingilizce.ToLower())
                {
                    txtTurkcesi.Text = a.Turkce;
                    txtIngilizcesi.Text = a.Ingilizce;
                    txtTuru.Text = a.Turu;
                    txtDurumu.Text = a.Durum;
                    return;
                }
            }
            MessageBox.Show("Kelime bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
          BilgiDoldur(txtAra.Text);         
        }
    }
}
