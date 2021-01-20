using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
            //ctrl k + ctrl c
        {
            //arrayler bizim oluşturduğumuz sınırlarda takılır. Dizileri genişletemeyiz. 
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //5 elemanlı bir array
            ////new dediğimiz anda bellekte yeni bir adres oluşur.
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //LIST 
            //koleksiyonlar da arrayler gibi değerleri kaydeder. 

            List<string> isimler2 = new List<string> {"Engin", "Murat", "Kerem", "Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
