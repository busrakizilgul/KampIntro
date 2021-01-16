using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention büyük harfle başla örneğin Ekle. Bir yerde normal parantez görürsen orada metot çalışıyordur.
        //syntax - yazım şekilleri
        //neyi eklemek istedğini metoda vermek gerekir. Buna parametre denir. 

        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);

        } 

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
