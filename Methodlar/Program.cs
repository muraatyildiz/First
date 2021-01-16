using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 0;
            product1.ProductName = "Elma";
            product1.Price = 15;
            product1.explanation = "Amasya elması";

            Product product2 = new Product();
            product2.id = 1;
            product2.ProductName = "Karpuz";
            product2.Price = 152;
            product2.explanation = "Diyarbakır";

            Product[] products = new Product[] {product1,product2 };
            foreach (var product in products)
            {
                Console.WriteLine(product.id);
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.explanation);
                Console.WriteLine("---------");

            }
            Console.WriteLine("-----------------methods------------------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add2("armut");
        }
    }
}
