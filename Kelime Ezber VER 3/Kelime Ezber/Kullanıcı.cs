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
        public İstatistik istatistik = new İstatistik();
        public Kelime[] kelimes = new Kelime[100];

        

        public Kullanıcı(string ad,string şifre)
        {
            this.Ad = ad;
            this.Şifre = şifre;
        }

        public static void KullanıcıSil(Kullanıcı K)
        {
            K = null;     
        }





    }
}
