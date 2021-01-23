using System;
using System.Collections.Generic;

namespace _009.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[]
            //{"Aysel", "Orhan", "Sema", "İbrahim"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //İki türlü liste oluşturulabilir. Birincisi aşağıdaki gibi.
            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Furkan");

            //İkincisi ise bu şekilde
            List<string> isimler2 = new List<string>
            { "Aysel", "Orhan", "Sema", "İbrahim" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Furkan");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
