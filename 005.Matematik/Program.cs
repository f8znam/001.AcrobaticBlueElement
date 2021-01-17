using System;

namespace _005.Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            Console.WriteLine("-----------------");
            dortIslem.Topla(6, 9);
        }
    }
}
