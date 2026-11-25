using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class Ghircoias05
    {
        public void Cuvant05()
        {
            string cuvantAme = "AREM";
            string cuvant = "MARE";
            bool ok = false;

            Console.WriteLine("Cuvantul amestecat este: " + cuvantAme);
            Console.WriteLine("Care este cuvantul?");

            while (!ok)
            {
                string? raspuns = Console.ReadLine();
                if (raspuns == cuvant)
                {
                    Console.WriteLine("Da,asta era cuvantul");
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Gresit, mai incearca o data");
                }
            }
        }
    }
}
