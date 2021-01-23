using System;

namespace _002.ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteri1 = new Musteriler();
            musteri1.musteriAdi = "Ayşe";
            musteri1.musteriSoyadi = "Çınar";
            musteri1.musteriID = 12345678910;
            musteri1.musteriAnneAdi = "Fevziye";

            Musteriler musteri2 = new Musteriler();
            musteri2.musteriAdi = "Mehmet";
            musteri2.musteriSoyadi = "Çınar";
            musteri2.musteriID = 12345678902;
            musteri2.musteriAnneAdi = "Hayriye";

            Musteriler musteri3 = new Musteriler();
            musteri3.musteriAdi = "Yeşil";
            musteri3.musteriSoyadi = "Türkmen";
            musteri3.musteriID = 12345678906;
            musteri3.musteriAnneAdi = "Yeşim";

            Console.WriteLine("----------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Console.WriteLine("----------------------------");

        }
    }
}
