using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2__v2
{
    
    
        class Panel
        {
            public event EventHandler Gora;
            public event EventHandler Dol;
            public event EventHandler Lewo;
            public event EventHandler Prawo;
        

            public Panel()
            {
                Gora += UP;
                Dol += DOWN;
                Lewo += LEFT;
                Prawo += RIGHT;
            }
            public void Ruch()
            {
                Gora.Invoke(this, EventArgs.Empty);
                Dol.Invoke(this, EventArgs.Empty);
                Lewo.Invoke(this, EventArgs.Empty);
                Prawo.Invoke(this, EventArgs.Empty);

        }
            private void UP(object obj, EventArgs args)
            {
                Console.WriteLine("W góre");
            }
            private void DOWN(object obj, EventArgs args)
            {
                Console.WriteLine("W dol");
            }
            private void LEFT(object obj, EventArgs args)
            {
                Console.WriteLine("W lewo");
            }
            private void RIGHT(object obj, EventArgs args)
        {
            Console.WriteLine("W prawo");
        }
    }
    }


