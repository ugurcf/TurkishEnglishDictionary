using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Kelime_Ezber
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();

            lblAd.Text += " " + SQL.GetInstance().suankiKullanici.Ad;
            SQL.GetInstance().Kullanicilar.Add(SQL.GetInstance().suankiKullanici);
        }
        Kullanıcı Oturum = SQL.GetInstance().suankiKullanici;

        private void btnİstatistikler_Click(object sender, EventArgs e)
        {

            this.Hide();
            Formİstatistik istatistik = new Formİstatistik();
            istatistik.ShowDialog();
            this.Close();
            
        }

        private void btnKelimeHavuzu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelimeHavuzu kelimeHavuzu = new FormKelimeHavuzu();
            kelimeHavuzu.ShowDialog();
            this.Close();
        }

        private void btnKullaniciAyarlari_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKullaniciAyarlari kullaniciAyarlari = new FormKullaniciAyarlari();
            kullaniciAyarlari.ShowDialog();
            this.Close();
        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelimeEkleme kelimeEkleme = new FormKelimeEkleme();
            kelimeEkleme.ShowDialog();
            this.Close();
        }

        private void btnTestOl_Click(object sender, EventArgs e)
        {
            if(Oturum.istatistik.testKelime>9)
            {
                this.Hide();
                FormTest test = new FormTest();
                test.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Test için en az 10 kelimeniz olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void anaSayfa_Load(object sender, EventArgs e) // HATIRLATMA
        {
          if(  Oturum.istatistik.testKelime > 0)
            {
                DateTime ŞimdikiZaman = DateTime.Now;
                foreach(Kelime a in Oturum.kelimes)
                {
                    if (a == null)
                        continue;

                   if (Convert.ToInt32((ŞimdikiZaman - a.EklendiğiTarih).TotalDays)== 182) //6 AY SONRA
                    {
                        MessageBox.Show("Bazı Kelimeler için ilk test vakti!");
                        break;
                    }
                    if (Convert.ToInt32((ŞimdikiZaman - a.EklendiğiTarih).TotalDays) == 30) // 1 AY SONRA
                    {
                        MessageBox.Show("Bazı Kelimeler için ikinci test vakti!");
                        break;
                    }
                    if (Convert.ToInt32((ŞimdikiZaman - a.EklendiğiTarih).TotalDays) == 7) // 1 HAFTA SONRA
                    {
                        MessageBox.Show("Bazı Kelimeler için üçüncü test vakti!");
                        break;
                    }
                    if (Convert.ToInt32((ŞimdikiZaman - a.EklendiğiTarih).TotalDays) == 1) // 1 GÜN SONRA
                    {
                        MessageBox.Show("Bazı Kelimeler için son test vakti!");
                        break;
                    }
                }
            }
               
        }
    }
}
