using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
   abstract class TestYapma
    {
       public Kelime KelimeSec(int Kacinci)
        {
            Kelime a = SQL.GetInstance().suankiKullanici.kelimes[0];
       
            

            for (int i = 0; i <= Kacinci; i++)
                a = SQL.GetInstance().suankiKullanici.kelimes[i];

            if (a != null)
                return a;
            else
                return KelimeSec(Kacinci + 1);
        }
       public abstract string SoruSor(int Kacinci);
       public abstract string DogruCevapKoy(int Kacinci);
       public abstract string YanlisCevapKoy(int Kacinci);
       
    }
}
