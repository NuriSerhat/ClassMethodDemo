using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Nuri";
            musteri1.SoyAdi = "Kaplan";
            musteri1.DogumTarihi = 1984;
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Kaya";
            musteri2.SoyAdi = "Deniz";
            musteri2.DogumTarihi = 1973;
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Funda";
            musteri3.SoyAdi = "Arslan";
            musteri3.DogumTarihi = 1986;
            musteri3.Id = 3;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.SoyAdi);
                Console.WriteLine(musteri.DogumTarihi);
                Console.WriteLine(musteri.Id);
                Console.WriteLine("Sıradaki Müşteri");
             }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri3);
            musteriManager.SikayetEt(musteri1);



        }
    }
}
