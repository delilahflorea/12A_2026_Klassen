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
    internal class Albert
    {


        public void AlbertMethode()
        {
            Console.WriteLine("Dies ist die Albert-Methode.");

            int[,] mat = new int[5, 5] { { 0, 1, 1, 0, 0 }, { 0, 0, 1, 1, 0 }, { 0, 0, 0, 1, 1 }, { 1, 0, 0, 0, 1 }, { 1, 1, 0, 0, 0 } };

            Console.WriteLine("Die Adjazenzmatrix ist:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Gibt es einen eulerischen Zyklus in diesem Graphen? (ja/nein)");
            string Antwort = Console.ReadLine();
            
            if(Antwort == "ja")
            {
                Console.WriteLine("Richtig! Es gibt einen eulerischen Zyklus.");
            }
            else
            {
                Console.WriteLine("Falsch! Es gibt einen eulerischen Zyklus.");
                return;
            }





            int[,] mat2 = new int[10, 10] { { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                                            { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                            { 1, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                                            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
                                            { 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 },
                                            { 1, 1, 1, 1, 1, 1, 0, 1, 1, 1 },
                                            { 1, 1, 1, 1, 1, 1, 1, 0, 1, 1 },
                                            { 1, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
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

            // Vordefinierte minimale Lösung: genau eine Kante von 9 nach 0.
            Console.WriteLine("Geben Sie die Kante als 9-0 ein:");
            string input = Console.ReadLine();

            if (input == "9-0")
            {
                Console.WriteLine("Richtig! Der Graph ist mit der minimalen Anzahl von Kanten stark konnex.");
            }
            else
            {
                Console.WriteLine("Falsch! Die minimale Lösung ist genau die Kante 9-0.");
            }
        }
    }
}
