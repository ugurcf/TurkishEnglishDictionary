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
    public partial class Formİstatistik : Form
    {
        static Kullanıcı Oturum = SQL.GetInstance().suankiKullanici;
        private int dakika;
        private int saniye;
        private int toplamSaniye = Oturum.istatistik.toplamZaman;
        private int KelimeOgrenmeZamani=0;

        private void ZamaniAyarla()
        {
           while(toplamSaniye > 60)
            {
                dakika++;
                saniye -= 60;
                toplamSaniye -= 60;
            }
            saniye = toplamSaniye;
        }



        public Formİstatistik()
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

        private void Formİstatistik_Load(object sender, EventArgs e)
        {
            ZamaniAyarla();

            lblHavuzSayisi.Text += " " + Oturum.istatistik.havuzKelime;
            lblOgenilceklerSayi.Text += " " + Oturum.istatistik.ogrenilcekKelime;
            lblTestKelimeSayisi.Text += " " + Oturum.istatistik.testKelime;
            lblOgrenilenSayisi.Text += " " + Oturum.istatistik.ogrenilenKelime;
            lblDogru.Text += " " + Oturum.istatistik.toplamDogru;
            lblYanlis.Text += " " + Oturum.istatistik.toplamYanlis;
            lblTestSayii.Text += " " + Oturum.istatistik.girilenTest;
            lblZaman.Text += " " + dakika + ":" + saniye;
            lblToplamSkor.Text += " " + Oturum.istatistik.toplamSkor;
        }

        private void cmbZaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbZaman.Text == "Ocak")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariYil(1);
            else if (cmbZaman.Text == "Şubat")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariYil(2);
            else if (cmbZaman.Text == "Mart")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariYil(3);
            else if (cmbZaman.Text == "Nisan")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariYil(4);
            else if (cmbZaman.Text == "Mayıs")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariAy(5);
            else if (cmbZaman.Text == "Haziran")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariAy(6);
            else if (cmbZaman.Text == "Temmuz")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariAy(7);
            else if (cmbZaman.Text == "Ağustos")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariAy(8);
            else if (cmbZaman.Text == "Eylül")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariAy(9);
            else if (cmbZaman.Text == "Ekim")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariAy(10);
            else if (cmbZaman.Text == "Kasım")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariAy(11);
            else if (cmbZaman.Text == "Aralık")
                lblZamanOgrenilen.Text = cmbZaman.Text + " ayında öğrenilen kelime sayisi: " + KelimeZamanlariAy(12);
            else
                lblZamanOgrenilen.Text = cmbZaman.Text + " yılında öğrenilen kelime sayisi: " + KelimeZamanlariYil(Convert.ToInt32(cmbZaman.Text));
        }


        private int KelimeZamanlariAy(int ay)
        {
            foreach (Kelime a in Oturum.kelimes)
            {
                if (a == null)
                    continue;

                if (a.OgrenildigiAy == ay)
                    KelimeOgrenmeZamani++;
            }
           return KelimeOgrenmeZamani;
        }

        private int KelimeZamanlariYil(int Yil)
        {
            foreach (Kelime a in Oturum.kelimes)
            {
                if (a == null)
                    continue;

                if (a.OgrenildigiYil == Yil)
                    KelimeOgrenmeZamani++;
            }
            return KelimeOgrenmeZamani;
        }
    }
}
