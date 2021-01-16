using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);


            //ARRAY = DİZİLER

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç İçin Temel Kurs", 
                "Java" , "Python", "C++"}; // tek tek tanımlamak yerine listede tuttuk.

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarar. Dizileri kolay dolaşmak için kullanırız.
                //in kurslar= kursları tek tek dolaş.
                //kurs = alias. Yerine başka bir şey de yazabiliriz.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu- Footer");
        }
    }
}
