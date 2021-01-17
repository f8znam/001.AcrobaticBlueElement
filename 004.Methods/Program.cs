using System;

namespace _004.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Apple";
            product1.productPrice = 15;
            product1.productData = "Amasya Apple";

            Product product2 = new Product();
            product2.productName = "Watermelon";
            product2.productPrice = 80;
            product2.productData = "Diyarbakır Watermelon";

            Product[] fruits = new Product[] { product1, product2 };

            foreach (Product product in fruits )
            {
                Console.WriteLine(product.productName);
                Console.WriteLine(product.productPrice);
                Console.WriteLine(product.productData);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("------------------Methods-----------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            Console.WriteLine("------------------------");
            sepetManager.Add2("Pineapple,",  12, "Green Pineapple");
            sepetManager.Add2("Apple,", 35, "Green Apple");
            sepetManager.Add2("Melon,", 55, "Juicy Melon");

        }
    }
}
