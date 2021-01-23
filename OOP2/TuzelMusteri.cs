using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{

    //Coorporate
    //miras inheritance
    //tüzel müşteri miras alır müşteriden.  Musteri: ebeveyn
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }
    }
}
