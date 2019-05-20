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
    public partial class FormAyarDegistirme : Form
    {
        public FormAyarDegistirme()
        {
            InitializeComponent();
        }
        static Kullanıcı Oturum = SQL.GetInstance().suankiKullanici;

        public enum İstek { KullaniciDegistir=1,
                           KullaniciSil,
                           KullaniciEkle};
        public İstek istek;
     
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnAyarDevam_Click(object sender, EventArgs e)
        {
            if(istek==İstek.KullaniciDegistir)
            {
                Kullanıcı YeniOturum = SQL.GetInstance().KullaniciAra(txtAyarAd.Text, txtAyarŞifre.Text);
                if (YeniOturum == null)
                    MessageBox.Show("Böyle bir kullanici bulunamadi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Oturum = YeniOturum;
                    MessageBox.Show("Kullanıcı değiştirildi");
                }
                    
            }
            else if(istek==İstek.KullaniciEkle)
            {

                if(txtAyarŞifre.Text==txtAyarTekrarŞifre.Text)
                {
                    Kullanıcı kullanıcı = new Kullanıcı(txtAyarAd.Text, txtAyarŞifre.Text);
                    Oturum = kullanıcı;
                    SQL.GetInstance().Kullanicilar.Add(kullanıcı);
                    txtAyarAd.Clear();
                    txtAyarŞifre.Clear();
                    txtAyarTekrarŞifre.Clear();
                   
                    MessageBox.Show("Yeni kullanıcı oluşturuldu!");
                }
                else
                    MessageBox.Show("Şifreler Uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  //kullanıcı sil
            {
                Kullanıcı x = SQL.GetInstance().KullaniciAra(txtAyarAd.Text, txtAyarŞifre.Text);
                if (x == null)
                    MessageBox.Show("Böyle bir kullanici bulunamadi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Kullanıcı.KullanıcıSil(SQL.GetInstance().KullaniciAra(txtAyarAd.Text, txtAyarŞifre.Text));
                    SQL.GetInstance().Kullanicilar.Remove(SQL.GetInstance().KullaniciAra(txtAyarAd.Text, txtAyarŞifre.Text));
                    MessageBox.Show("Kullanıcı silindi");
                }
                    
            }
            
        }

        private void txtAyarAd_KeyPress(object sender, KeyPressEventArgs e) //Karakter kısıtlama
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)) 
                e.Handled = true;
        }

        private void txtAyarŞifre_KeyPress(object sender, KeyPressEventArgs e)  //Karakter kısıtlama
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtAyarTekrarŞifre_KeyPress(object sender, KeyPressEventArgs e)  //Karakter kısıtlama
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
