using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type safe -- tip güvenli
            foreach (Urun urun in urunler)
            {//urun yerine x de yazabiliriz. Anlamlı olsun diye küçük harfle yazdık. 
             //Urun yerine var yazabiliriz. Arka planda direkt Urun yazıyor aslında.
             
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("--------------------------Metotlar------------------");

            //instance - örnek
            //encapsulation
            
            SepetManager sepetManager = new SepetManager();
            //her biri farklı sayfada çalışıyormuş gibi düşün
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8); 
        }
    }
}


//Do not repeat yourself - kendini tekrar etme - Clean code - Best practice: doğru uygulama teknikleri
//Temel yapılar sadece classların içinde olur
//bir classın içinde birden fazla metot  olabilir.