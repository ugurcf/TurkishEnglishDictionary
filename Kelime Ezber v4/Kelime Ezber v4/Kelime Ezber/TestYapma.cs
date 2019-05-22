using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
   abstract class TestYapma
    {

        
        Kullanıcı Oturum = SQL.GetInstance().OturumuVer();
        public Kelime[] soruKelimeleri = new Kelime[SQL.GetInstance().OturumuVer().istatistik.testKelime];

        public Kelime KelimeSec(int Kacinci)
        {
            return soruKelimeleri[Kacinci];
        }

       public abstract string SoruSor(int Kacinci);
       public abstract string DogruCevapKoy(int Kacinci);
       public abstract string YanlisCevapKoy(int Kacinci);
       
    }
}
