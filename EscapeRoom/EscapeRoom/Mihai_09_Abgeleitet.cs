using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class Mihai_09_Level2 : Mihai_09
    {
        int summe2;
        new int[] pali = new int[900];
        new int code;
        int versuche;

        public Mihai_09_Level2(int s) : base(s)
        {
            code = 0;
            summe2 = s;
            versuche = 0;
        }

        public void Palindrom2()
        {
            int anzahl2 = 0;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                        if (2 * i + 2 * j + k == summe2)
                        {
                            pali[anzahl2] = (10000 * i + 1000 * j + 100 * k + 10 * j + i);
                            anzahl2 = anzahl2 + 1;
                        }
                }
            }

            code = randomPal(anzahl2, pali);


        }
        public void prim(int code)
        {
            int z = code % 10;
            int ok = 1;
            if (z == 1 || z == 0)
                ok = 2;
            else
                for (int i = 2; i <= z / 2; i++)
                {
                    if (z % i == 0)
                    {
                        ok = 0;
                        break;
                    }
                }
            if (ok == 1)
            {
                Console.WriteLine("eine Primzahl.");
            }
            else if (ok == 0)
            {
                Console.WriteLine(" keine Primzahl.");
            }
            else
            {
                Console.WriteLine(" 0 oder 1.");
            }
        }
        public void welcheZahl2()
        {
            Console.WriteLine("Der Code ist ein funfstelliges Palindrom. Die Summe der Ziffern ist " + summe2 + ". Welche ist der Code?");
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine("Versuch " + i);
                int var = Convert.ToInt32(Console.ReadLine());

                if (var == code)
                {
                    Console.WriteLine("Richtig!");
                    return;
                }
                else
                {
                    Console.WriteLine("Falsch!");

                    versuche++;

                    switch (versuche)
                    {
                        case 1:
                            Console.WriteLine("Der Rest der Ziffer in der Mitte geteilt durch 2 ist: " + (code / 100) % 10 % 2);
                            break;
                        case 2:
                            Console.WriteLine("Die aussere Zahl ist:");
                            prim(code);
                            break;
                        case 3:
                            Console.WriteLine("Der Rest der zweiten Ziffer geteilt durch 5 ist: " + code / 10 % 10 % 5);
                            break;
                        case 4:
                            Console.WriteLine("Die Ziffer in der Mitte ist:" + code / 100 % 10);
                            break;
                        case 5:
                            Console.WriteLine("Die Summe der ersten beiden Ziffern ist: " + (code / 1000 + code / 100 % 10));
                            break;
                        case 6:
                            Console.WriteLine("Verusche noch ein Mal:");
                            break;
                        case 7:
                            Console.WriteLine("Letzte Chance:");
                            break;
                    }
                }
            }

            Console.WriteLine("Leider verloren! Der Code war " + code);
        }
    }
}

