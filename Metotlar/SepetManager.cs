using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {   
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi : "+ product.Name);
        }

        public void Add2(string productName,string definition,double price,int stockNumber)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :" + productName);
        }
    }
}
