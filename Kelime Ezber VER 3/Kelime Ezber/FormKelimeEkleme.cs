using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Kelime_Ezber
{
    public partial class FormKelimeEkleme : Form
    {
        static Kullanıcı Oturum = SQL.GetInstance().suankiKullanici;
        public FormKelimeEkleme()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.ShowDialog();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {



            if (txtKelimeTürkçe.Text == "" || txtKelimeİngilizce.Text == "" || cmbKelimeTürü.Text == "" || cmbKelimeDurumu.Text == "")
                MessageBox.Show("Hiçbir yer boş olmamalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtKelimeTürkçe.Text == txtKelimeİngilizce.Text)
                MessageBox.Show("Bir kelimenin Türkçesi ve İngilizcesi aynı olamaz!");
            else
            {
                Kelime.Durumu durum;

                if (cmbKelimeDurumu.Text == "Havuz")
                {
                    durum = Kelime.Durumu.Havuz;
                    Oturum.istatistik.HavuzKelimeGuncelle(1);

                }                    
                else if (cmbKelimeDurumu.Text == "Öğrenilecek")
                {
                    durum = Kelime.Durumu.Ogrenilecek;
                    Oturum.istatistik.OgrenilcekKelimeGuncelle(1);

                }                    
                else if (cmbKelimeDurumu.Text == "Test")
                {
                    durum = Kelime.Durumu.Test;
                    Oturum.istatistik.TestKelimeGuncelle(1);

                }       
                else
                {
                    durum = Kelime.Durumu.Ogrenilen;
                    Oturum.istatistik.OgrenilenKelimeGuncelle(1);
                }


                string türkçe = txtKelimeTürkçe.Text;
                string ingilizce = txtKelimeİngilizce.Text;
                string tür = cmbKelimeTürü.Text;

                Oturum.kelimes[Oturum.istatistik.toplamKelime] = Kelime.KelimeEkle(türkçe, ingilizce, tür, durum);
                Oturum.istatistik.ToplamKelimeGuncelle(); 

                txtKelimeİngilizce.Clear();
                txtKelimeTürkçe.Clear();


                MessageBox.Show("Tebrikler! Bir kelime eklediniz!");
            }   
        }

        private void txtKelimeTürkçe_KeyPress(object sender, KeyPressEventArgs e) //Karakter kısıtlama
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtKelimeİngilizce_KeyPress(object sender, KeyPressEventArgs e) //Karakter kısıtlama
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
