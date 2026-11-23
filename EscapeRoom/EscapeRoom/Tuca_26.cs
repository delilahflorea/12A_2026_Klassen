using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class Tuca_26
    {
        private int minuten;
        private string basis6;
        private int zahl;
        private int[] stelle = new int[180];
        private int basis10;

        public Tuca_26()
        {
            basis6 = " ";
            basis10 = 0;
        }

        public Tuca_26(string Basis6Zahl)
        {
            basis6 = Basis6Zahl;
            basis10 = 0;
        }
        public void Basis6()
        {
            int j, k, l, zahl = 0;
            for (j = 1; j < 6; j++)
            {
                for (k = 0; k < 6; k++)
                {
                    for (l = 0; l < 6; l++)
                    {
                        stelle[zahl] = j * 100 + k * 10 + l;
                        zahl++;
                    }
                }
            }
            basis6 = stelle[new Random().Next(0, 180)].ToString();

            basis10 = 0;
            int multi = 1;

            for (int i = basis6.Length - 1; i >= 0; i--)
            {
                int ziff = basis6[i] - '0';
                basis10 += ziff * multi;
                multi *= 6;
            }

            while (true)
            {
                Console.WriteLine("Wandle die folgende Zahl im Basis 6 um, damit du witergehen kannst: " + basis6);
                Console.Write("Deine Antwort: ");

                string eingabe = Console.ReadLine();

                if (int.TryParse(eingabe, out int Antwort) && Antwort == basis10)
                {
                    Zeit();
                    break;
                }
                else
                {
                    Console.WriteLine("Falsch! Rechne noch einmal.\n");
                }
            }
        }
        protected void Zeit()
        {
            minuten = basis10 / 60;

            while (true)
            {
                Console.WriteLine("Du hast " + basis10 + " Sekunden. Wandle sie in Minuten um.");
                string eingabeMin = Console.ReadLine();

                if (int.TryParse(eingabeMin, out int AntwortMin) && AntwortMin == minuten)
                {
                    Console.WriteLine("Richtig! Du kannst jetzt witergehen!");
                    break;
                }
                else
                {
                    Console.WriteLine("Falsch! Rechne noch einmal.\n");
                }
            }
        }
    }
}
