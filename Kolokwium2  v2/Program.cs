using System;
using System.Collections.Generic;

namespace Kolokwium2__v2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Składnik> Składniki = new List<Składnik>();

            Składniki.Add(new Składnik() { Weglowodany = 10,Tluszcz= 15, Sol= 20 });
            Składniki.Add(new Składnik() { Weglowodany = 25, Tluszcz = 12, Sol = 22 });
            Składniki.Add(new Składnik() { Weglowodany = 11, Tluszcz = 14, Sol = 19 });
            Składniki.Add(new Składnik() { Weglowodany = 16, Tluszcz = 18, Sol = 123 });
            Składniki.Add(new Składnik() { Weglowodany = 12, Tluszcz = 19, Sol = 1245 });
            Składniki.Add(new Składnik() { Weglowodany = 7, Tluszcz = 12, Sol = 1124 });
            Składniki.Add(new Składnik() { Weglowodany = 6, Tluszcz = 19, Sol = 12546 });
            
        }
    }
}
