using System;

namespace _3.OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //İki farklı şekilde yazılabilir. İlk kısımda normal parantez ile ürün tanımlanmışken, bu tanımlamada süslü parantez kullanılır ve "product1" gibi isim kullanılmaya ihtiyaç olmaz.
            //Direk değişken tanımlanmış olur. Gerek sıralı gerek altalta da yazılabilir.
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
