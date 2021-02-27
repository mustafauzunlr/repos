using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming Convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi" + urun.Adi);
        }

        //Böyle yazmamak lazım aşağıdaki hatali bir tercih
        public void Ekle2(string urunAdi, string aciklama, double fiyati, int stokAdedi )
        {
            Console.WriteLine("Sepete Eklendi" + urunAdi);

        }
    }
}
