using System;

namespace Deger_ve_Referas_tip
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
            //sayi1 ??? 30 olur

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;

            sayilar2[0] = 999;
            //sayilar1[0] kaç olur 999 çünkü  yukarıdakiler stack'tır  ve değer tiplerini tutar int float gibi  heap ise referans tiptir yani referans numarasını tutar.

        }
    }
}
