using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklendi " + musteri.Adi + " : " + musteri.SoyAdi);
            

        }
         public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+ " : " + musteri.SoyAdi + " : " + "Müşteri listesinden başarıyla silindi" );
        }

        public void SikayetEt(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Adi + "  " + musteri.SoyAdi + " kurumumuzla ilgili bir şikayetiniz varsa lütfen " +
                "bize ulaşın");

        }
    }
}
