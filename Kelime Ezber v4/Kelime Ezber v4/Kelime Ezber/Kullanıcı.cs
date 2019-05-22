using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    public class Kullanıcı
    {
        public string Ad { get; private set; }
        public string Şifre { get; private set; }
        public İstatistik istatistik;
        public Kelime[] kelimes;
       
        public Kullanıcı(string ad,string şifre)
        {
            this.Ad = ad;
            this.Şifre = şifre;
            this.kelimes = new Kelime[500];
            for (int i = 0; i <= 499; i++)
                this.kelimes[i] = Kelime.YeniKelimeEkle("-1", "-1", "-1", "-1");

            this.istatistik = new İstatistik();
        }
      
        public static void KullanıcıSil(Kullanıcı K)
        {
            K = null;  
        }

    }
}
