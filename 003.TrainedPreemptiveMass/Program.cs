using System;

namespace _003.TrainedPreemptiveMass
{
    class Kurs
    {
        //prop yaz tab+tab
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kurs cKursu = new Kurs();
            cKursu.kursAdi = "C#";
            cKursu.Egitmen = "Engin Demiroğ";
            cKursu.izlenmeOrani = 168;

            Kurs javaKursu = new Kurs();
            javaKursu.kursAdi = "Java";
            javaKursu.Egitmen = "Furkan Öznam";
            javaKursu.izlenmeOrani = 35;

            Kurs pythonKursu = new Kurs();
            pythonKursu.kursAdi = "Python";
            pythonKursu.Egitmen = "Efna Öznam";
            pythonKursu.izlenmeOrani = 3658;

            Kurs[] kurslar = new Kurs[] { cKursu, javaKursu, pythonKursu };
           
            foreach (var x in kurslar)
            {
                Console.WriteLine(x.kursAdi + " : " + x.Egitmen);
            }           
        }
    }
}
