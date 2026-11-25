using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class Orlea15_2 : Orlea15
    {
        private int versuche;

        public Orlea15_2()
        {
            versuche = 0;
        }

        public void neuerHinweis()
        {
            versuche++;

            if (versuche == 1)
            {
                hinweis = "Die Summe aller Ziffern ist 15.";
            }
            else if (versuche == 2)
            {
                hinweis = "Die zweite Ziffer ist 2 und die dritte ist 3.";
            }
            else
            {
                hinweis = "Die letzte Ziffer ist eine ungerade Zahl groesser als 5.";
            }

            HinweisAnzeigen();
        }

        public int GetVersuche()
        {
            return versuche;
        }
    }
}
