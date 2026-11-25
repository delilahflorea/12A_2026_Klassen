using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class Luca7
    {

        int x = 0; string y = "";

        public Luca7()
        {

        }

        public Luca7(int x, string y)
        {
            this.x = x;
            this.y = y;

        }

        public void Luca7Methode1()
        {

            Console.WriteLine("Welcher ist der kleinste Primnummer aus 3 Ziffer?");
            string eingabe;
            eingabe = Console.ReadLine();
            if (eingabe == "101")
            {
                Console.WriteLine("richtig");
            }
            else
            {
                Console.WriteLine("Pech gehabt");
            }

        }

        public void Luca7Methode2()
        {

            Console.WriteLine("Welcher ist der GGT von 625 und 900");
            string eingabe;
            eingabe = Console.ReadLine();
            if (eingabe == "25")
            {
                Console.WriteLine("gut gemacht");
            }
            else
            {
                Console.WriteLine("Nachstes Mal");
            }


        }

    }
}
