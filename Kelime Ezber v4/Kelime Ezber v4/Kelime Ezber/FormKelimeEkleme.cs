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
        Kullanıcı Oturum = SQL.GetInstance().OturumuVer();
        public FormKelimeEkleme()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.IlkAcilis(false);
            anaSayfa.ShowDialog();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string durum = cmbKelimeDurumu.Text;

                if (durum == "Havuz")
                    Oturum.istatistik.HavuzKelimeGuncelle(1);
                if (durum == "Öğrenilecek")
                    Oturum.istatistik.OgrenilenKelimeGuncelle(1);
                if (durum == "Test")
                    Oturum.istatistik.TestKelimeGuncelle(1);

                string türkçe = txtKelimeTürkçe.Text;
                string ingilizce = txtKelimeİngilizce.Text;
                string tür = cmbKelimeTürü.Text;

                Oturum.kelimes[Oturum.istatistik.toplamKelime] = Kelime.YeniKelimeEkle(türkçe, ingilizce, tür, durum);
                SQL.GetInstance().VeriKelimeEkle(türkçe, ingilizce, tür, durum);
                Oturum.istatistik.ToplamKelimeGuncelle();

                txtKelimeİngilizce.Clear();
                txtKelimeTürkçe.Clear();

                MessageBox.Show("Tebrikler! Bir kelime eklediniz!");
            }
            catch
            {
                if (Oturum.istatistik.toplamKelime == 500)
                    MessageBox.Show("Kelime kapasiteniz kalmadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtKelimeTürkçe.Text == "" || txtKelimeİngilizce.Text == "" || cmbKelimeTürü.Text == "" || cmbKelimeDurumu.Text == "")
                    MessageBox.Show("Hiçbir yer boş olmamalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtKelimeTürkçe.Text == txtKelimeİngilizce.Text)
                    MessageBox.Show("Bir kelimenin Türkçesi ve İngilizcesi aynı olamaz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
