using System;
using System.Collections.Generic;
using System.Text;

//2 constructor: kopierungs, parameter
//2 functii: private,public-->ruft private
//date: string, int

namespace EscapeRoom
{
    internal class Ghircoias05
    {
        protected string cuvantAme;
        protected string cuvant;
        protected int count=0;

        public Ghircoias05(string cuvantAmestecat = "arem", string cuvantCorect = "mare")
        {
            cuvantAme = cuvantAmestecat;
            cuvant = cuvantCorect;
        }

        public Ghircoias05(Ghircoias05 altObiect)
        {
            cuvantAme = altObiect.cuvantAme;
            cuvant = altObiect.cuvant;
            count = 0;
        }
        public virtual void Cuvant()
        {
            bool ok = false;

            Console.WriteLine("Cuvantul amestecat este: " + cuvantAme);
            Console.WriteLine("Care este cuvantul?");

            while (!ok)
            {
                string raspuns = Console.ReadLine() ?? "";

                count++;

                if (VerificaRaspuns(raspuns))
                {
                    Console.WriteLine("Da, acesta era cuvantul!");
                    Console.WriteLine("Ai avut nevoie de "+ count+ " incercari.");

                    ok = true;
                }
                else
                {
                    Console.WriteLine("Gresit, mai incearca o data!");
                }
            }
        }
       
        private bool VerificaRaspuns(string raspuns)
        {
            return (raspuns.ToLower() == cuvant.ToLower());
        }

    }
}
