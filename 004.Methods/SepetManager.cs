using System;
using System.Collections.Generic;
using System.Text;

namespace _004.Methods
{
    class SepetManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine(product.productName + " added to list.");
        }
        // Aşağıdaki yöntemde değişiklik yapıldığı zaman kullanıldığı her yerde değiştirileceği için tercih edilmez. 
        // Örneğin stok kodu da eklenseydi, program.cs sayfasında üç koda da stok kodunu eklemek zorunda kalabilirdik.
        public void Add2(string productName, double productPrice, string productData)
        {
            Console.WriteLine(productName + " added to list.");
        }
    }
}
