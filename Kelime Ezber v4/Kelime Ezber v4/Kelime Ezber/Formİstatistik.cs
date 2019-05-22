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
        static Kullanıcı Oturum = SQL.GetInstance().OturumuVer();
        private int dakika;
        private int saniye;
        private int toplamSaniye = Oturum.istatistik.toplamZaman;

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
            anaSayfa.IlkAcilis(false);
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

        private void cmbZamanAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOgrenilenAy.Text = LabelZamanDoldur(cmbZamanAy.Text);

            if (cmbZamanAy.Text == "Ocak")
                lblOgrenilenAy.Text += KelimeZamanlariAy(1);
            if (cmbZamanAy.Text == "Şubat")
                lblOgrenilenAy.Text += KelimeZamanlariAy(2);
            if (cmbZamanAy.Text == "Mart")
                lblOgrenilenAy.Text += KelimeZamanlariAy(3);
            if (cmbZamanAy.Text == "Nisan")
                lblOgrenilenAy.Text += KelimeZamanlariAy(4);
            if (cmbZamanAy.Text == "Mayıs")
                lblOgrenilenAy.Text += KelimeZamanlariAy(5);
            if (cmbZamanAy.Text == "Haziran")
                lblOgrenilenAy.Text += KelimeZamanlariAy(6);
            if (cmbZamanAy.Text == "Temmuz")
                lblOgrenilenAy.Text += KelimeZamanlariAy(7);
            if (cmbZamanAy.Text == "Ağustos")
                lblOgrenilenAy.Text += KelimeZamanlariAy(8);
            if (cmbZamanAy.Text == "Eylül")
                lblOgrenilenAy.Text += KelimeZamanlariAy(9);
            if (cmbZamanAy.Text == "Ekim")
                lblOgrenilenAy.Text += KelimeZamanlariAy(10);
            if (cmbZamanAy.Text == "Kasım")
                lblOgrenilenAy.Text += KelimeZamanlariAy(11);
            if (cmbZamanAy.Text == "Aralık")
                lblOgrenilenAy.Text += KelimeZamanlariAy(12);
        }

        private void cmbZamanYil_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOgrenilenYil.Text = cmbZamanYil.Text + " yılında öğrenilen kelime sayisi: " + KelimeZamanlariYil(Convert.ToInt32(cmbZamanYil.Text));
        }

        private int KelimeZamanlariAy(int ay)
        {
            int KelimeOgrenmeZamani = 0;
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
            int KelimeOgrenmeZamani = 0;
            foreach (Kelime a in Oturum.kelimes)
            {
                if (a == null)
                    continue;

                if (a.OgrenildigiYil == Yil)
                    KelimeOgrenmeZamani++;
            }
            return KelimeOgrenmeZamani;
        }

        private string LabelZamanDoldur(string Ay)
        {
          return Ay + " ayında öğrenilen kelime sayisi: ";
        }       
    }
}
