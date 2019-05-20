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
        static Kullanıcı Oturum = SQL.GetInstance().suankiKullanici;
        public FormKelimeHavuzu()
        {
            InitializeComponent();
        }
        enum Seçilen
        { Havuz=1,
          Ogrenilcekler,
          Test,
          Ogrenilen,
          Secilmedi};



        Seçilen seçilen = Seçilen.Secilmedi;

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YenidenSay();
            this.Hide();
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.ShowDialog();
            this.Close();
        }


        private void listHavuz_MouseClick(object sender, MouseEventArgs e)
        {
            listOgrenilcekler.ClearSelected();
            listOgrenilen.ClearSelected();
            listTest.ClearSelected();
            seçilen = Seçilen.Havuz;
           
        }

        private void listOgrenilcekler_MouseClick(object sender, MouseEventArgs e)
        {
            listHavuz.ClearSelected();
            listOgrenilen.ClearSelected();
            listTest.ClearSelected();
            seçilen = Seçilen.Ogrenilcekler;
        }

        private void listTest_MouseClick(object sender, MouseEventArgs e)
        {
            listHavuz.ClearSelected();
            listOgrenilen.ClearSelected();
            listOgrenilcekler.ClearSelected();
            seçilen = Seçilen.Test;
        }

        private void listOgrenilen_MouseClick(object sender, MouseEventArgs e)
        {
            listHavuz.ClearSelected();
            listOgrenilcekler.ClearSelected();
            listTest.ClearSelected();
            seçilen = Seçilen.Ogrenilen;

        }

        private void btnKelimeSil_Click(object sender, EventArgs e)
        {
            ListBox listBox;
            int sira = 0;

            if (seçilen == Seçilen.Havuz)
                listBox = listHavuz;     
            else if (seçilen == Seçilen.Ogrenilcekler)
                listBox = listOgrenilcekler;    
            else if (seçilen == Seçilen.Test)
                listBox = listTest;             
            else
                listBox = listOgrenilen;
                     
            Kelime.KelimeSil(KelimeVer(listBox));
            foreach (Kelime a in Oturum.kelimes)
            {
                if (KelimeVer(listBox) == a)
                {
                    Oturum.kelimes[sira] = null;
                }
                sira++;
            }

            listBox.Items.Remove(listBox.SelectedItem);
            MessageBox.Show("Kelime silindi!");

           
        }

        private Kelime KelimeVer(ListBox listBox)
        {
            Kelime kelime = Oturum.kelimes[0];


            for (int i = 0; i <= Oturum.kelimes.Length - 1; i++)
            {
                 kelime = Oturum.kelimes[i];

                if (kelime == null)
                    continue;

                if (listBox.SelectedItem.ToString() == kelime.Turkce)
                    return kelime;

            }

                return kelime;
        }

        private void btnİlerlet_Click(object sender, EventArgs e)
        { 
            if(seçilen==Seçilen.Secilmedi)
            {
                MessageBox.Show("Bir kelime seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (seçilen == Seçilen.Havuz)
            {
                object selected = listHavuz.SelectedItem;


                KelimeVer(listHavuz).DurumGuncelle(Kelime.Durumu.Ogrenilecek);
                listOgrenilcekler.Items.Add(listHavuz.SelectedItem);
                listHavuz.Items.Remove(listHavuz.SelectedItem);

            }              
            else if (seçilen == Seçilen.Ogrenilcekler)
            {
                KelimeVer(listOgrenilcekler).DurumGuncelle(Kelime.Durumu.Test);
                listTest.Items.Add(listOgrenilcekler.SelectedItem);
                listOgrenilcekler.Items.Remove(listOgrenilcekler.SelectedItem);
            }               
            else if (seçilen == Seçilen.Test)
            {
                MessageBox.Show("Bir kelimeyi sadece test yoluyla öğrenilene taşıyabilirsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            else if (seçilen == Seçilen.Ogrenilen)
                MessageBox.Show("Daha fazla ilerletemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGerilet_Click(object sender, EventArgs e)
        {
            if (seçilen == Seçilen.Havuz)
                MessageBox.Show("Daha fazla geriletemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (seçilen == Seçilen.Ogrenilcekler)
            {
                KelimeVer(listOgrenilcekler).DurumGuncelle(Kelime.Durumu.Havuz);
                listHavuz.Items.Add(listOgrenilcekler.SelectedItem);
                listOgrenilcekler.Items.Remove(listOgrenilcekler.SelectedItem);
            }              
            else if (seçilen == Seçilen.Test)
            {
                KelimeVer(listTest).DurumGuncelle(Kelime.Durumu.Ogrenilecek);
                listOgrenilcekler.Items.Add(listTest.SelectedItem);
                listTest.Items.Remove(listTest.SelectedItem);
            }                
            else if (seçilen==Seçilen.Ogrenilen)
            {
                KelimeVer(listOgrenilen).DurumGuncelle(Kelime.Durumu.Test);
                listTest.Items.Add(listOgrenilen.SelectedItem);
                listOgrenilen.Items.Remove(listOgrenilen.SelectedItem);
            }
        }

        private void FormKelimeHavuzu_Load(object sender, EventArgs e)
        {
      
            Kelime a = Oturum.kelimes[0];
            for (int i = 0; i <= Oturum.kelimes.Length-1; i++)
            {
                a = Oturum.kelimes[i];

                if (a == null)
                    continue;

                if (a.Durum == Kelime.Durumu.Havuz)
                    listHavuz.Items.Add(a.Turkce);
                else if (a.Durum == Kelime.Durumu.Ogrenilecek)
                    listOgrenilcekler.Items.Add(a.Turkce);
                else if (a.Durum == Kelime.Durumu.Test)
                    listTest.Items.Add(a.Turkce);
                else if (a.Durum == Kelime.Durumu.Ogrenilen)
                    listOgrenilen.Items.Add(a.Turkce);
            }
               
        }

        private void YenidenSay()
        {
            Oturum.istatistik.havuzKelime = listHavuz.Items.Count;
            Oturum.istatistik.ogrenilcekKelime = listOgrenilcekler.Items.Count;
            Oturum.istatistik.testKelime = listTest.Items.Count;
            Oturum.istatistik.ogrenilenKelime = listOgrenilen.Items.Count;
        }

        private void Yenile()
        {
            listHavuz.Refresh();
            listOgrenilcekler.Refresh();
            listTest.Refresh();
            listOgrenilen.Refresh();
        }

        private void FormKelimeHavuzu_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
