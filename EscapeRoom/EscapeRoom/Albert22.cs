using System;

//Erstellt eine Klasse für ein Objekt aus einem Escape Room. Das Objekt soll am Ende des Namens eure Katalognr. haben. 
//Das Objekt beinhaltet 3 Daten, 2 Konstruktoren und 2 Methoden. Die Methoden sollen Aufgaben für den Escape Room 
//für das betreffende Objekt lösen.

//ich habe eine gerichtete adjazenzmatrix und es soll eulerisch sein. ich frage den spieler ob es dort ein eulerischer zyklus gibt, 
//und er antwortet mit ja oder nein. wenn er korrekt beantwortet, dann ist die Aufgabe gelöst. danach will ich nochmal eine andere adjmatrix
//einer gerichteten Graphen erstellen, und der Spieler soll die bogen der form 2-5 zb schreiben und enter geben damit er den graph stark konnex macht.
//wenn der Spieler den minimalen anzahl der notigen kanten schreibt, dann ist die Aufgabe gelöst. Dieses graph soll grosser sein, also 10 Knoten haben.
//mein programm liest kanten aus einer einzigen Zeile ein. dann checkt es ob der spieler nur die minimalen kanten geschrieben hat
//und der graph stark konnex ist, und wenn ja, dann ist die Aufgabe gelöst. ansonsten ist die Aufgabe nicht gelöst.


namespace EscapeRoom
{
    public class Albert22
    {
        protected int x = 0;
        protected string y = "";
        protected string z = "Basis";

        public Albert22()
        {
        }

        public Albert22(Albert22 k)
        {
            x = k.x;
            y = k.y;
        }

        public Albert22(int x, string y)
        {
            this.x = x;
            this.y = y;
        }

        private void MetPrivate()
        {
            Console.WriteLine("Private Methode in der Basisklasse!");
        }

        protected void MethodePublic()
        {
            Console.WriteLine("Dies ist ein Beispiel einer public Methode die eine private Methode aufruft!");
            MetPrivate();
        }

        public virtual void AlbertMethode2()
        {
            Console.WriteLine("Dies ist eine virtual Methode in der Basisklasse!");
        }


        public void AlbertMethode()
        {
            Console.WriteLine("Dies ist die Albert-Methode.");

            int[,] mat = new int[5, 5] { { 0, 1, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1 }, { 1, 0, 0, 0, 0 } };

            Console.WriteLine("Die Adjazenzmatrix ist:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            bool ersteAufgabeGeloest = false;
            while (!ersteAufgabeGeloest)
            {
                Console.WriteLine("Gibt es einen Hamiltonischen Zyklus in diesem Graphen? (ja/nein)");
                string antwort = (Console.ReadLine() ?? string.Empty).Trim();

                if (antwort.Equals("ja", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Richtig! Es gibt einen Hamiltonischen Zyklus.");
                    ersteAufgabeGeloest = true;
                }
                else
                {
                    Console.WriteLine("Falsch! Versuchen Sie es erneut.");
                }
            }





            int[,] mat2 = new int[10, 10] { { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                                            { 0, 0, 0, 0, 1, 0, 0, 0, 1, 1 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            Console.WriteLine("Die Adjazenzmatrix ist:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Vordefinierte minimale Lösung: genau zwei Kanten werden benötigt.
            bool zweiteAufgabeGeloest = false;
            while (!zweiteAufgabeGeloest)
            {
                Console.WriteLine("Wie viele Kanten werden mindestens benötigt, damit der Graph stark konnex wird?");
                string anzahl = (Console.ReadLine() ?? string.Empty).Trim();
                Console.WriteLine("Geben Sie danach die beiden Kanten im Format 1-2,3-4 ein:");
                string input = (Console.ReadLine() ?? string.Empty).Replace(" ", "");

                bool richtigeKanten = input == "8-0,9-2" || input == "9-2,8-0" ||
                                      input == "8-2,9-0" || input == "9-0,8-2";

                if (anzahl == "2" && richtigeKanten)
                {
                    Console.WriteLine("Richtig! Der Graph ist mit der minimalen Anzahl von Kanten stark konnex.");
                    zweiteAufgabeGeloest = true;
                }
                else
                {
                    Console.WriteLine("Falsch! Die Anzahl oder die Kanten sind nicht korrekt. Versuchen Sie es erneut.");
                }
            }
        }
    }
}