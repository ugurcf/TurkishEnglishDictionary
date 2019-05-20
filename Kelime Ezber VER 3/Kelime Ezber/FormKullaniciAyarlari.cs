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
    public partial class FormKullaniciAyarlari : Form
    {

        
        public FormKullaniciAyarlari()
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

        private void btnKullanıcıDeğiştir_Click(object sender, EventArgs e)
        {
            FormAyarDegistirme ayarDegistirme = new FormAyarDegistirme();
            ayarDegistirme.istek = FormAyarDegistirme.İstek.KullaniciDegistir;
            ayarDegistirme.lblAyarlar.Text = "Kullanıcı Degistir";
            ayarDegistirme.txtAyarTekrarŞifre.Visible = false;
            ayarDegistirme.lblTekrar.Visible = false;
            ayarDegistirme.ShowDialog();
        }

        private void btnKullanıcıSil_Click(object sender, EventArgs e)
        {
            FormAyarDegistirme ayarDegistirme = new FormAyarDegistirme();
            ayarDegistirme.istek = FormAyarDegistirme.İstek.KullaniciSil;
            ayarDegistirme.lblAyarlar.Text = "Kullanıcı Sil";
            ayarDegistirme.txtAyarTekrarŞifre.Visible = false;
            ayarDegistirme.lblTekrar.Visible = false;
            ayarDegistirme.ShowDialog();
        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            FormAyarDegistirme ayarDegistirme = new FormAyarDegistirme();
            ayarDegistirme.istek = FormAyarDegistirme.İstek.KullaniciEkle;
            ayarDegistirme.lblAyarlar.Text = "Kullanıcı Ekle";
            ayarDegistirme.ShowDialog();
        }

      
    }
}
