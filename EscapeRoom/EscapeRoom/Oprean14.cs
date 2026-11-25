using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class Oprean14
    {
        int x = 0; string y = "";
        public Oprean14()
        {

        }
        public Oprean14(int x, string y)
        {
            this.x = x;
            this.y = y;
        }
        public void Oprean14Methode1()
        {
            Console.WriteLine("Wie viele Knochen hat der menschliche Korper?");
            string eingabe;
            eingabe = Console.ReadLine();
            if (eingabe == "206")
            {
                Console.WriteLine("Richtig!!");
            }
            else
            {
                Console.WriteLine("Wirf eine weitere Muenze ein.");
            }
        }

        public void Oprean14Methode2()
        {
            Console.WriteLine("Din ce dai bacul?");
            string eingabe1, eingabe2, eingabe3;
            eingabe1 = Console.ReadLine();
            if (eingabe1 == "fizica")
            {
                Console.WriteLine("Care este formula vitezei?");
                eingabe2 = Console.ReadLine();
                if (eingabe2 == "v=d/t" || eingabe2 == "v = d / t")
                {
                    Console.WriteLine("Bine! Care este formula lui pitagora generalizat?");
                    eingabe3 = Console.ReadLine();
                    if (eingabe3 == "a^2 = b^2 + c^2 + 2bc * cos α" || eingabe3 == "a^2=b^2+c^2+2bc*cosα")
                    {
                        Console.WriteLine("Bravo!!");
                    }
                    else
                    {
                        Console.WriteLine("Esti PAMANT!");
                    }

                }
                else
                {
                    Console.WriteLine("Esti BETON!");
                }
            }
            else
            {
                Console.WriteLine("Gresit! Nu dai bacul PUNKT.");
            }
        }

    }
}
