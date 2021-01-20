using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Ürünle ilgili operasyonlar bulunan class. Ekleme, silme, güncelleme, listeleme gibi operasyonlar. 
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) //product türünde bir şey ver
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        //void=

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }


        //void ile int farkı
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

    }
}
