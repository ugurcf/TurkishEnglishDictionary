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

        bool KullaniciDegistirilidi = false;
        public FormAyarDegistirme()
        {
            InitializeComponent();
        }
        static Kullanıcı Oturum = SQL.GetInstance().OturumuVer();

        public enum İstek { KullaniciDegistir=1,
                           KullaniciSil,
                           KullaniciEkle};

        public İstek istek;
     
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.IlkAcilis(KullaniciDegistirilidi);
            anaSayfa.ShowDialog();          
            this.Close();
        }

        private void btnAyarDevam_Click(object sender, EventArgs e)
        {
            string ad = txtAyarAd.Text;
            string şifre = txtAyarŞifre.Text;
            string tekrarŞifre = txtAyarTekrarŞifre.Text;

            if(istek==İstek.KullaniciDegistir)
            {
                Kullanıcı YeniOturum = SQL.GetInstance().KullaniciAra(ad, şifre);
                try
                {
                    SQL.GetInstance().VeriKullaniciOturumDegistir(Oturum);
                    SQL.GetInstance().VeriKullaniciOturumDegistir(YeniOturum);

                    Oturum = YeniOturum;
                    KullaniciDegistirilidi = true;

                    MessageBox.Show("Kullanıcı değiştirildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                catch
                {
                    if (YeniOturum == null)
                        MessageBox.Show("Böyle bir kullanici bulunamadi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
            }
            else if(istek==İstek.KullaniciEkle)
            {
                if (txtAyarŞifre.TextLength<5)
                {
                    MessageBox.Show("Şifreniz en az 6 karakter uzunluğunda olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (SQL.GetInstance().KullaniciAdEşsizligi(txtAyarAd.Text) == false)
                {
                    MessageBox.Show("İstediğiniz ad başka biri tarafından kullanılıyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                    
               else if (şifre==tekrarŞifre)
               {
                    Kullanıcı kullanıcı = new Kullanıcı(ad, şifre);
                    SQL.GetInstance().Kullanicilar.Add(kullanıcı);
                    txtAyarTekrarŞifre.Clear();
                    SQL.GetInstance().VeriKullaniciEkle(ad,şifre);

                    txtAyarAd.Clear();
                    txtAyarŞifre.Clear();

                    MessageBox.Show("Yeni kullanıcı oluşturuldu!");
               }
                else
                    MessageBox.Show("Şifreler Uyuşmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if  (istek == İstek.KullaniciSil)
            {
                Kullanıcı x = SQL.GetInstance().KullaniciAra(ad, şifre);

                if (x == null)
                    MessageBox.Show("Böyle bir kullanici bulunamadi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (x != Oturum)
                {
                    MessageBox.Show("Kendi hesabınız dışında başka hesap silemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult diyalog = MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo);
                    if (diyalog == DialogResult.Yes)
                    {
                        Kullanıcı.KullanıcıSil(SQL.GetInstance().KullaniciAra(ad, şifre));
                        SQL.GetInstance().Kullanicilar.Remove(SQL.GetInstance().KullaniciAra(ad, şifre));
                        SQL.GetInstance().VeriKullaniciSil(ad, şifre);
                        MessageBox.Show("Kullanıcı silindi");
                        Application.Exit();
                    }
                    else if (diyalog == DialogResult.No)
                        return;
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
