using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " +musteri.Ad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " +musteri.Ad);
        }
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("müşteri listesi:");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
            }
        }
       
    }
}
