using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            // type safety =tip güvenliği
            // Do not repeat yourself

            // değer tutucu, alias
            string kategoriEtiketi = "Katogori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYampmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            

            
            /*
            if (sistemeGirisYampmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }*/ 
                          
            
 

            //Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
