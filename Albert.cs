using System;

//Erstellt eine Klasse für ein Objekt aus einem Escape Room. Das Objekt soll am Ende des Namens eure Katalognr. haben. 
//Das Objekt beinhaltet 3 Daten, 2 Konstruktoren und 2 Methoden. Die Methoden sollen Aufgaben für den Escape Room 
//für das betreffende Objekt lösen.

//ich habe eine gerichtete adjazenzmatrix und es soll eulerisch sein. ich frage den spieler ob es dort ein eulerischer zyklus gibt, 
//und er antwortet mit ja oder nein. wenn er korrekt beantwortet, dann ist die Aufgabe gelöst.



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
            }

        }
    }
}
