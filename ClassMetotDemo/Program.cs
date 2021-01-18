using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 122222;
            musteri1.Adi = "Gonca Derman";
            musteri1.HesapNo = 1234;
            musteri1.Aciklama = "Bireysel Müşteri";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 133333;
            musteri2.Adi = "Etem Derman";
            musteri2.HesapNo = 1345;
            musteri2.Aciklama = "Kurumsal Müşteri";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 144444;
            musteri3.Adi = "Ateş Derman";
            musteri3.HesapNo = 1456;
            musteri3.Aciklama = "Bireysel Müşteri";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri No: " + musteri.Id);
                Console.WriteLine("Hesap No: " + musteri.HesapNo);
                Console.WriteLine("Ad Soyad: " + musteri.Adi);
                Console.WriteLine("Müşteri Tipi: " + musteri.Aciklama);
                Console.WriteLine("----");
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Sil(musteri3);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
        }
    }
}
