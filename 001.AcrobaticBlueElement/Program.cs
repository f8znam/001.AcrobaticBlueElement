using System;

namespace _001.AcrobaticBlueElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            
            int ogrenciSayisi = 32000;  //Tam sayılar tanımlanır.
            double faizOrani = 1.45; //Virgüllü sayılar tanımlanır.
            bool sistemeGirisYapmisMi = false; //0 veya 1 alacak değerler tanımlanır. True veya False ile belirtilir.

            double dolarDun = 7.35;
            double dolarBugun = 7.25;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

        }
    }
}
