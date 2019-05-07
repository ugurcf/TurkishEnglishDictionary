using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    public class Kullanıcı
    {
        private string Ad;
        private string Şifre;
        public İstatistik istatistik = new İstatistik();
        public LinkedList<Kelime> Kelimeler = new LinkedList<Kelime>();
       

        private Kullanıcı(string ad,string şifre)
        {
            this.Ad = ad;
            this.Şifre = şifre;
        }

        public static void KullanıcıOluştur(string ad,string şifre)
        {
            Kullanıcı kullanıcı = new Kullanıcı(ad, şifre);
        }

        public string KullanıcıSil(Kullanıcı K)
        {
            if (this.Ad == K.Ad && this.Şifre == K.Şifre)
            {
                K = null;
                K.istatistik = null;
                return "Kullanıcı başarıyla silindi!";
            }
            else
            {
                return "Kullanıcı bilgileri eşleşmiyor!";
            }             
        }

        public void ListeyeEkle(Kelime kelime)
        {
            Kelimeler.AddLast(kelime);
        }
        
        public void ListedenCikar(Kelime kelime)
        {
           Kelimeler.Remove(kelime);
        }


    }
}
