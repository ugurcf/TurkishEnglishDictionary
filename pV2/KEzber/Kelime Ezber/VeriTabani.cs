using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    abstract class VeriTabani
    {
        //TODO: EN SON SPRINT'TE GEREKSİNİMLERE GÖRE DEĞİŞEBİLİR

        protected abstract void VeriKelimeEkle();
        protected abstract void VeriKelimeSil();
        protected abstract void VeriİstatistikGuncelle();
        protected abstract void VeriKullaniciyiGuncelle();
        protected abstract void VeriKullaniciEkle();
        protected abstract void VeriKullaniciSil();

    }
}
