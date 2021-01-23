using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla();

        void BiseyYap();
        
    }
}

//interface: Eğer bir sınıf bir interface'i kullanırsa bu interfacedeki metodları içermek zorunda.
//İnterface olduğunu anlamak için I harfi kullanırız. 
//interfaceleri biribirinin alternatifi olan ama kod içeriği farklı olan durumlar için kullanırız. Önemli not!