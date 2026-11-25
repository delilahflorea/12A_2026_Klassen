using System;

namespace EscapeRoom
{
    internal class Toader24
    {
        // 3 Daten
        public int Code;
        public string Farbe;
        public bool Offen;

        // 1. Konstruktor
        public Toader24()
        {
            Code = 1014;
            Farbe = "Rot";
            Offen = false;
        }

        // 2. Konstruktor
        public Toader24(int code, string farbe, bool offen)
        {
            Code = code;
            Farbe = farbe;
            Offen = offen;
        }

        // 1. Methode
        public bool CodePruefen(int eingabe)
        {
            if (eingabe < 1000 || eingabe > 9999)
            {
                return false;
            }

            int z1 = eingabe / 1000;
            int z2 = (eingabe / 100) % 10;
            int z3 = (eingabe / 10) % 10;
            int z4 = eingabe % 10;

            int summe = z1 + z2 + z3 + z4;

            return eingabe % 13 == 0 && summe % 3 == 0;
        }

        // 2. Methode
        public void Oeffnen(int eingabe)
        {
            if (CodePruefen(eingabe))
            {
                Offen = true;
                Console.WriteLine("Schloss geöffnet!");
            }
            else
            {
                Console.WriteLine("Falscher Code! Versuch es noch einmal.");
            }
        }
    }
}