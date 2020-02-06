using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2__v2
{
    class Hex
    {
        public string Kod = "FFAEAE";
        public Hex(string kKod)
        {
            Kod = kKod;
        }
        public void Deconstruct(out string kKod,string R, string G, string B)
        {
            kKod = Kod;
            
            
            
        }
        public void Deconstruct1(out string kKod, string liczba1,string liczba2,string liczba3)
        {
            kKod = Kod;
        }
    }
}
