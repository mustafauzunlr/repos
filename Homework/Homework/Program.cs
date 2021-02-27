using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Huawei sw";
            urun1.Satici = "Flera";
            urun1.Fiyati = 3000;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Cisco sw";
            urun2.Satici = "Netova";
            urun2.Fiyati = 5000;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "juniper sw";
            urun3.Satici = "Marcom";
            urun3.Fiyati = 2000;

            Urun urun4 = new Urun();
            urun4.UrunAdi = "enteras sw";
            urun4.Satici = "Flera";
            urun4.Fiyati = 3000;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

            foreach (Urun Urun in urunler)
            {
                Console.WriteLine(Urun.UrunAdi + ":" + Urun.Satici);
            }
            Console.WriteLine("foreach Bitti");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]);
            }

            Console.WriteLine("for bitti");


        }
    }


    class Urun
    {
        public string UrunAdi { get; set; }
        public string Satici { get; set; }
        public int Fiyati { get; set; }

    }

}




