using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("sepete ekle:"+ product.ProductName );
        }

        public void Add2(string name)
        {
            Console.WriteLine("Sepete ekele : " + name);
        }
    }
}
