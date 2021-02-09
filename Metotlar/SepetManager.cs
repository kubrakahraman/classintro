using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler,Sepete Eklendi : " + urun.Adi);


        }


        public void EKle2(string urunAdi, string aciklama, double fiyat,int stokadedi)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urunAdi);
        }






    }

        
}
