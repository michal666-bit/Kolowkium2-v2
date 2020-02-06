using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2__v2
{
    public class Bateria : IZasilanie
    {
        int Pojemnosc = 100;

        public void Zasilaj(int energia)
        {
            if (energia>Pojemnosc)
            {
                Console.WriteLine("OK");
                Pojemnosc--;
            }
            else
            {
                Console.WriteLine("Brak zasilania");
            }
            
        }
    }
}
