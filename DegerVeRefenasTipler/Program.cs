using System;

namespace DegerVeRefenasTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=? 30 
            // sayi1 = 10
            // sayi2 = 30
            // sayi1 yeni değeri 30
            // sayi2 yeni değeri 65 oldu

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ??? 999
            //sayilar1 in referans numarası = sayilar2 nin referans numarası diye okunur
            //sayilar1 artık sayilar2 nin referans numarasını alır.
            //sayilar2 nin referans numarasının 0 ıncı elemanı 999 olarak atanıyor.
            //sayilar1 in referans sayılarını kimse tutmadiği için bellekten silniyor.




        }
    }
}
