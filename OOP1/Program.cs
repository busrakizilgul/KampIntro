using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2=mobilya kategorisi olsun.
            product1.ProductName = "Masa";
            product1.UnitPrice= 500;
            product1.UnitsInStock = 3;

            //Bu şekilde de yazabiliriz.
            Product product2 = new Product { Id = 2, CategoryId=5, UnitsInStock=5, ProductName="Kalem", UnitPrice=35 };

            //PascalCase(classlar büyük harfle başlar)   //camelCase (ilk kelimenin ilk harfi küçük, ikinci kelimenin ilk harfi büyük)
            //case sensitive(küçük-büyük harf duyarlılığı)
            //eşittirin sol tarafı stack de oluşur, sağ tarafı heap de oluşur.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            

            //int, double, bool... değer tiptir. Değer tiplerde atamalar tamamen değeri üzerinden olur ve bağlantı tamamen kopar.
            //diziler, classlar, abstract classlar, interfaceler... referans tiptir. 
            //Atamalar referansın numarasıyla yapılır yani bellekteki adresiyle yapılır. 
            //ref out 


        }
    }
}
