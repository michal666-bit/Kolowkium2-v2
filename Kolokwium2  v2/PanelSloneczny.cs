using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2__v2
{
    class PanelSloneczny : IZasilanie
    {
        public void Zasilaj(int energia)
        {
            DateTime thisDay = DateTime.UtcNow;
            int godzinaStart = 6;
            int godzinaStop = 18;


            if (energia < 100 && godzinaStart >= 6 && godzinaStop >=18)
            {
                Console.WriteLine("OK");
            }
        }
    }
}
