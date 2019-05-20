using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
     class SQL : VeriTabani
    {
        //TODO: EN SON SPRINT'TE GUNCELLENECEK

        private static SQL instance;



        private SQL()
        {

        }

        public static SQL GetInstance()
        {
            if (instance == null)
                instance = new SQL();

            


            return instance;

        }

        public override void VeriKelimeEkle()
        {
            throw new NotImplementedException();
            //TODO: EN SON SPRINT'TE EKLENECEK
        }

        public override void VeriKelimeSil()
        {
            throw new NotImplementedException();
            //TODO: EN SON SPRINT'TE EKLENECEK
        }

        public override void VeriKullaniciEkle()
        {
            throw new NotImplementedException();
            //TODO: EN SON SPRINT'TE EKLENECEK
        }

        public override void VeriKullaniciSil()
        {
            throw new NotImplementedException();
            //TODO: EN SON SPRINT'TE EKLENECEK
        }

        public override void VeriKullaniciyiGuncelle()
        {
            throw new NotImplementedException();
            //TODO: EN SON SPRINT'TE EKLENECEK
        }

        public override void VeriİstatistikGuncelle()
        {
            throw new NotImplementedException();
            //TODO: EN SON SPRINT'TE EKLENECEK
        }

        

        
    }
}
