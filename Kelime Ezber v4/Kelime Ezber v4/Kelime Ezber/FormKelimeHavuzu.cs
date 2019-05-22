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
    public partial class FormKelimeHavuzu : Form
    {
        Kullanıcı Oturum = SQL.GetInstance().OturumuVer();
        ListBox listBox;
        public FormKelimeHavuzu()
        {
            InitializeComponent();
        }
        enum Seçilen
        { Havuz=1,
          Ogrenilcekler,
          Test,
          Ogrenilen,
          Secilmedi
        };

        Seçilen seçilen = Seçilen.Secilmedi;

        private void btnGeri_Click(object sender, EventArgs e)
        {
            İstatistikYenidenSay();
            this.Hide();
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.IlkAcilis(false);
            anaSayfa.ShowDialog();
            this.Close();
        }

        private void listHavuz_MouseClick(object sender, MouseEventArgs e)
        {
            listOgrenilcekler.ClearSelected();
            listOgrenilen.ClearSelected();
            listTest.ClearSelected();
            seçilen = Seçilen.Havuz;
            listBox = listHavuz;
           
        }

        private void listOgrenilcekler_MouseClick(object sender, MouseEventArgs e)
        {
            listHavuz.ClearSelected();
            listOgrenilen.ClearSelected();
            listTest.ClearSelected();
            seçilen = Seçilen.Ogrenilcekler;
            listBox = listOgrenilcekler;
        }

        private void listTest_MouseClick(object sender, MouseEventArgs e)
        {
            listHavuz.ClearSelected();
            listOgrenilen.ClearSelected();
            listOgrenilcekler.ClearSelected();
            seçilen = Seçilen.Test;
            listBox = listTest;
        }

        private void listOgrenilen_MouseClick(object sender, MouseEventArgs e)
        {
            listHavuz.ClearSelected();
            listOgrenilcekler.ClearSelected();
            listTest.ClearSelected();
            seçilen = Seçilen.Ogrenilen;
            listBox = listOgrenilen;
        }

        private void btnKelimeSil_Click(object sender, EventArgs e)
        {         
            if(listBox==null)
              MessageBox.Show("Hiçbir kelime seçmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else
            {
                int sira = 0;

                foreach (Kelime a in Oturum.kelimes)
                {
                    if (KelimeVer(listBox) == a)
                    {
                        Oturum.kelimes[sira] = null;
                        SQL.GetInstance().VeriKelimeSil(a.Turkce, Oturum);
                        break;
                    }
                    sira++;
                }

                listBox.Items.Remove(listBox.SelectedItem);
                İstatistikYenidenSay();
                MessageBox.Show("Kelime silindi!");
                Application.Restart();
                
                
            }                    
        }

        private int KelimeIndisiVer()
        {
            string kelimeTurk = listBox.SelectedItem.ToString();

            int i = 0;
            foreach(Kelime a in Oturum.kelimes)
            {
                if (a.Turkce == "-1")
                    break;

                if(a==null)
                {
                    i++;
                    continue;
                }

                if (kelimeTurk == a.Turkce)
                return i;

                i++;
            }

            return -1;
        }

        private Kelime KelimeVer(ListBox listBox)
        {
            Kelime kelime = Oturum.kelimes[0];

            for (int i = 0; i <= Oturum.kelimes.Length - 1; i++)
            {
                kelime = Oturum.kelimes[i];

                if (kelime == null)
                    continue;

                if (kelime.Turkce == "-1")
                    break;
              
                if (listBox.SelectedItem.ToString() == kelime.Turkce)
                    return kelime;
            }
            return kelime;
        }

        private void btnİlerlet_Click(object sender, EventArgs e)
        {
            if (seçilen == Seçilen.Secilmedi)
            {
                MessageBox.Show("Bir kelime seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (seçilen == Seçilen.Havuz)
            {

                Oturum.kelimes[KelimeIndisiVer()].Durum = "Öğrenilecek";
                SQL.GetInstance().VeriKelimeGuncelle(Oturum.kelimes[KelimeIndisiVer()]);

                listOgrenilcekler.Items.Add(listHavuz.SelectedItem);
                listHavuz.Items.Remove(listHavuz.SelectedItem);

            }
            else if (seçilen == Seçilen.Ogrenilcekler)
            {
                Oturum.kelimes[KelimeIndisiVer()].Durum = "Test";
                SQL.GetInstance().VeriKelimeGuncelle(Oturum.kelimes[KelimeIndisiVer()]);
                listTest.Items.Add(listOgrenilcekler.SelectedItem);
                listOgrenilcekler.Items.Remove(listOgrenilcekler.SelectedItem);
            }
            else if (seçilen == Seçilen.Test)
            {
                MessageBox.Show("Bir kelimeyi sadece test yoluyla öğrenilene taşıyabilirsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (seçilen == Seçilen.Ogrenilen)
                MessageBox.Show("Daha fazla ilerletemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Yenile();

        }

        private void btnGerilet_Click(object sender, EventArgs e)
        {

            if (seçilen == Seçilen.Secilmedi)
            {
                MessageBox.Show("Bir kelime seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (seçilen == Seçilen.Havuz)
                MessageBox.Show("Daha fazla geriletemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (seçilen == Seçilen.Ogrenilcekler)
            {
                Oturum.kelimes[KelimeIndisiVer()].Durum = "Havuz";
                SQL.GetInstance().VeriKelimeGuncelle(Oturum.kelimes[KelimeIndisiVer()]);
                listHavuz.Items.Add(listOgrenilcekler.SelectedItem);
                listOgrenilcekler.Items.Remove(listOgrenilcekler.SelectedItem);
            }
            else if (seçilen == Seçilen.Test)
            {
                Oturum.kelimes[KelimeIndisiVer()].Durum = "Öğrenilecek";
                SQL.GetInstance().VeriKelimeGuncelle(Oturum.kelimes[KelimeIndisiVer()]);
                listOgrenilcekler.Items.Add(listTest.SelectedItem);
                listTest.Items.Remove(listTest.SelectedItem);
            }
            else if (seçilen == Seçilen.Ogrenilen)
            {
                MessageBox.Show("Öğrenilen kelime geriletilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Yenile();
        }

        private void FormKelimeHavuzu_Load(object sender, EventArgs e)
        {          
            foreach (Kelime a in Oturum.kelimes)
            {
                if (a == null || a.Durum == "-1")
                    continue;

                if (a.Durum == "Havuz")
                    listHavuz.Items.Add(a.Turkce);
                else if (a.Durum == "Öğrenilecek")
                    listOgrenilcekler.Items.Add(a.Turkce);
                else if (a.Durum == "Test")
                    listTest.Items.Add(a.Turkce);
                else if (a.Durum == "Ögrenilen")
                    listOgrenilen.Items.Add(a.Turkce);
            }              
        }

        private void İstatistikYenidenSay()
        {
            Oturum.istatistik.havuzKelime = listHavuz.Items.Count;
            Oturum.istatistik.ogrenilcekKelime = listOgrenilcekler.Items.Count;
            Oturum.istatistik.testKelime = listTest.Items.Count;
            Oturum.istatistik.ogrenilenKelime = listOgrenilen.Items.Count;
            Oturum.istatistik.ToplamKelimeGuncelle();
            SQL.GetInstance().VeriİstatistikGuncelle(Oturum);
        }

        private void Yenile()
        {
            listHavuz.Refresh();
            listOgrenilcekler.Refresh();
            listTest.Refresh();
            listOgrenilen.Refresh();
            seçilen = Seçilen.Secilmedi;
        }
    }
}
