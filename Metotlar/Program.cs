using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           string urunAdi = "Elma";
           double fiyati = 15;
           string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma","Karpuz"};

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Dİyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            //type-safe -- tip gğvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------");


            }

            Console.WriteLine("---------Metotlar---------");

            // instance - örnek
            //encapsulation - kapsülleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.EKle2("Armut", "Yeşil armut", 12, 23456);
            sepetManager.EKle2("Elma", "Yeşil", 10, 456);
            sepetManager.EKle2("Karpuz", "Kırmızı", 12, 789);
        }
    }
}
