using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Say";
            musteri1.Job = "bankacı";
            
            Musteri musteri2 = new Musteri(); 
            musteri2.Ad = "Veli";
            musteri2.Soyad = "Saymak";
            musteri2.Job = "işçi";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "Çimen";
            musteri3.Job = "öğretmen";

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Canan";
            musteri4.Soyad = "Can";
            musteri4.Job = "mühendis";

            Musteri musteri5 = new Musteri();
            musteri5.Ad = "Hasan";
            musteri5.Soyad = "Efe";
            musteri5.Job = "Bakkal";

            Musteri[] musteriler = new Musteri[]
            {
                musteri1,musteri2,musteri3,musteri4,musteri5
            };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Job);
                Console.WriteLine("------------");
                             
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri3);
            musteriManager.Sil(musteri5);
        }
    }
}
