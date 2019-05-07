using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
   abstract class TestYapma
    {
       public Kelime KelimeSec(Kullanıcı k, int sayi)
        {
            Kelime a = k.Kelimeler.First.Value;

            for (int i = 1; i < sayi; i++)
                a = k.Kelimeler.First.Next.Value;

            return a;
        }
       public abstract string SoruSor(Kullanıcı k, int sayi);
       public abstract string DogruCevapKoy(Kullanıcı k, int sayi);
       public abstract string YanlisCevapKoy(Kullanıcı k,int sayi);
       
    }
}
