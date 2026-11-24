using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    //gegeben ist eine matrix. nimmt die zweitgrosste zahl aus jeder reihe und der Kode zum Safe
    //ist die drittletzte permutation erzeugt durch die backtracking-methode

    //daten: int+string
    //konstruktoren: parameter+kopierung
    //methoden:Public (ruft die private methode auf)+private
    internal class Muste12
    {
        private int[,] tafel;
        private int code;
        private string inhalt;

        public Muste12()
        {
            tafel = new int[,]
            {
                { 1, 5, 0, 2, 1 },
                { 4, 0, 3, 8, 2 },
                { 5, 6, 10, 1, 3 },
                { 3, 7, 8, 1, 9 },
                { 6, 9, 2, 10, 4 }
            };
            code = 0;
            inhalt = "Schluessel";
        }

        //parameter 
        public Muste12(int[,] tafel, string inhalt)
        {
            this.tafel = tafel;
            this.code = 0;
            this.inhalt = inhalt;
        }

        //kopierung
        public Muste12(Muste12 s)
        {
            tafel = s.tafel;
            code = s.code;
            inhalt = s.inhalt;
        }

        // Methode 1: zeigt das Rätsel und die Matrix an und sucht dabei
        // die zweitgrößte Zahl aus jeder Reihe
        public int[] ZweitZahl()
        {
            Console.WriteLine("Nimm die zweitgrößte Zahl aus jeder Reihe.");
            Console.WriteLine("Der Code ist die drittletzte Permutation, die durch die Backtracking-Methode erzeugt wird.");
            Console.WriteLine();

            int n = tafel.GetLength(0);
            int[] ergebnis = new int[n];
            for (int i = 0; i < n; i++)
            {
                int max = -99999999;
                int zweit = -99999999;
                for (int j = 0; j < n; j++)
                {
                    int wert = tafel[i, j];
                    Console.Write(wert.ToString().PadLeft(4)); // Matrix anzeigen

                    if (wert > max)
                    {
                        zweit = max;
                        max = wert;
                    }
                    else if (wert > zweit && wert < max)
                    {
                        zweit = wert;
                    }
                }
                Console.WriteLine();
                ergebnis[i] = zweit;
            }
            return ergebnis;
        }

        // Methode 2:berechnet mit Backtracking die drittletzte Permutation
        public void KodeSuche(int[] zahlen)
        {
            int n = zahlen.Length;
            int[] x = new int[n];
            bool[] benutzt = new bool[n];
            int letzte = -1, vorletzte = -1, drittletzte = -1;

            void Back(int k)
            {
                if (k == n)
                {
                    int perm = 0;
                    for (int i = 0; i < n; i++)
                        perm = perm * 10 + zahlen[x[i]];
                    drittletzte = vorletzte;
                    vorletzte = letzte;
                    letzte = perm;
                    return;
                }
                for (int i = 0; i < n; i++)
                {
                    if (!benutzt[i])
                    {
                        benutzt[i] = true;
                        x[k] = i;
                        Back(k + 1);
                        benutzt[i] = false;
                    }
                }
            }

            Back(0);
            code = drittletzte;

            bool offen = false;
            while (!offen)
            {
                Console.WriteLine();
                Console.Write("Code eingeben: ");
                int eingabe = Int32.Parse(Console.ReadLine());
                if (eingabe == code)
                {
                    Console.WriteLine("Korrekt! Safe offen! Inhalt: " + inhalt);
                    offen = true;
                }
                else
                {
                    Console.WriteLine("Falsch! Safe bleibt zu");
                }
            }
        }
    }
}
