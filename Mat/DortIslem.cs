using System;
using System.Collections.Generic;
using System.Text;

namespace Mat
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2) 
        {
            int Toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + Toplam);
        }

        public void Cikar(int sayi1, int sayi2) 
        {
            int Cikartma = sayi1 - sayi2;
            Console.WriteLine("Sonuc : " + Cikartma);
        }
        public void Carp(int sayi1, int sayi2) 
        {
            int Carpma = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + Carpma);
        }
        public void Bol(int sayi1, int sayi2) 
        {
            int Bolme = sayi1 / sayi2;
            Console.WriteLine("Sonuç : " + Bolme);
        }
 
    }
}
