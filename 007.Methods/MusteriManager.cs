using System;
using System.Collections.Generic;
using System.Text;

namespace _002.ClassMethodDemo
{
    class MusteriManager
    {
        public void Add(Musteriler musteriler)
        {
            Console.WriteLine("1. Sıradaki Müşterimizin bilgileri: " + musteriler.musteriAdi + " " + musteriler.musteriSoyadi + " " + musteriler.musteriID + " " + musteriler.musteriAnneAdi);
        }
    }
}
