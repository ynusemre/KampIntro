using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Definition = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Definition = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1,product2 };

            foreach (var prodcut in products)
            {
                Console.WriteLine(prodcut.Name);
                Console.WriteLine(prodcut.Price);
                Console.WriteLine(prodcut.Definition);
                Console.WriteLine("--------------------------------");
            }


            Console.WriteLine("----------Metodlar-------------");

            //Instance - örnek
            // Encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut","Yeşil Armut",12,10);
            sepetManager.Add2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12,8);

        }
    }
}
