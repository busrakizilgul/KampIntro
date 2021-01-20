using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //mylist de T ile çalışacağım anlamına geliyor.
    {
        //metodun dışında, direkt classın içinde yazdığımız değişkene her yerden erişim sağlanır.
        T[] items;

        //constructor metodu-yapıcı (bir class newlendiğinde çalışan block=constructor blok)
        public MyList()
        {
            items = new T[0];
        }


        public void Add(T item)
        {
            //referans numarasını tutar. Geçici dizinin referansı=items referansıdır yani onu tutmuş olur.
            //new yapınca yeni referans numarası gelir. Uçmasın diye geçici olarak tuttuk. 
            T[] tempArray = items;
            items = new T[items.Length+1]; //items.length dizinin eleman sayısını verir. 
            //Dizinin eleman sayısını artırmak için newle. items.length+1

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }

            items[items.Length - 1] = item; //itemsın son elemanı=items.length-1

        }
    }
}
