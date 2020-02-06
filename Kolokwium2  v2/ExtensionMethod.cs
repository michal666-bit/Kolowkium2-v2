using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2__v2
{
  public static class ExtensionMethod
    {
        public static int Slowo(this String str)
        {
            
            for (int i = 0; i < str.Length; i++)
            {
                if (i<str.Length)
                {
                    Console.WriteLine(str);
                }
                else if(i>str.Length)
                {
                    Console.WriteLine(str.Remove(i));
                }
                else if(str.Length<3)
                {
                    Console.WriteLine("Za krótki wyraz");
                }

            }
            return str.Length;
          
                          
        }
    }
}
