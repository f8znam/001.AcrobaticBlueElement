using System;

namespace _002.YummyHiddenAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            //array - dizi
            string[] kurslar = new string[] 
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java",
                "Python"
            };

            for (int i = 0;  i <kurslar.Length;  i++) // i=i+2 ve i+=2 aynı anlamı taşır. İkişer ikişer yükseltir. i++ ise birer birer arttırır.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("*************Dizi sonu.*************");

            foreach (string kurs in kurslar) // kurslar dizisindeki kursları dolaşacak. 
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
