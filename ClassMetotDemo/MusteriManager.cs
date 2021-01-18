using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Adi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Adi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi : " + musteri.Aciklama);
        }
    }
}
