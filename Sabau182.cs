using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class Sabau182 : Sabau18
    {
        private int BerechneGesamtweg(int erstesZiel, int zweitesZiel, int drittesZiel)
        {
            int ersterWeg = RobertMethode1(0, erstesZiel);
            int zweiterWeg = RobertMethode1(erstesZiel, zweitesZiel);
            int dritterWeg = RobertMethode1(zweitesZiel, drittesZiel);

            return ersterWeg + zweiterWeg + dritterWeg;
        }

        public void Level2()
        {
            Console.WriteLine();
            Console.WriteLine("Level 2:");
            Console.WriteLine("Du musst eine Route durch drei verschiedene Zielknoten planen.");
            Console.WriteLine("Berechne die Summe der kürzesten Wege für die Route 0 -> Ziel 1 -> Ziel 2 -> Ziel 3.");
            Console.Write("Gib den ersten Zielknoten ein (0 bis 4): ");
            int erstesZiel = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gib den zweiten Zielknoten ein (0 bis 4): ");
            int zweitesZiel = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gib den dritten Zielknoten ein (0 bis 4): ");
            int drittesZiel = Convert.ToInt32(Console.ReadLine());

            if (!IstGueltigeRoute(erstesZiel, zweitesZiel, drittesZiel))
            {
                Console.WriteLine("Die Zielknoten müssen zwischen 1 und 4 liegen und verschieden sein.");
                return;
            }

            int richtigeAntwort = BerechneGesamtweg(erstesZiel, zweitesZiel, drittesZiel);
            int chancen = 3;

            while (chancen > 0)
            {
                Console.Write("Deine Antwort: ");
                string eingabe = Console.ReadLine();

                if (int.TryParse(eingabe, out int antwort) && antwort == richtigeAntwort)
                {
                    Console.WriteLine("Richtig! Level 2 ist gelöst.");
                    return;
                }

                chancen--;
                if (chancen > 0)
                {
                    Console.WriteLine("Falsch. Du hast noch " + chancen + " Chancen.");
                }
                else
                {
                    Console.WriteLine("Falsch. Das Zahlenschloss bleibt geschlossen.");
                }
            }
        }

        private bool IstGueltigeRoute(int erstesZiel, int zweitesZiel, int drittesZiel)
        {
            return erstesZiel >= 1 && erstesZiel <= 4 &&
                   zweitesZiel >= 1 && zweitesZiel <= 4 &&
                   drittesZiel >= 1 && drittesZiel <= 4 &&
                   erstesZiel != zweitesZiel &&
                   erstesZiel != drittesZiel &&
                   zweitesZiel != drittesZiel;
        }
    }
}
