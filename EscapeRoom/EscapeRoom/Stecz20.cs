/*Erstellt eine Klasse für ein Objekt aus einem Escape Room. 
Das Objekt soll am Ende des Namens eure Katalognr. haben. Das Objekt beinhaltet 3 Daten, 2 Konstruktoren und 2 Methoden.
Die Methoden sollen Aufgaben für den Escape Room für das betreffende Objekt lösen.*/
using System;

namespace EscapeRoom
{
    internal class Stecz20
    {
        private int groesse;
        private int[,] matrix;
        private string raumName;
        private string frage;

        public Stecz20()
        {
            groesse = 8;
            raumName = "Escape Room Stecz 20";
            frage = "Wie viele Pferde können maximal auf dem Schachbrett stehen, ohne sich gegenseitig anzugreifen?";
            matrix = new int[groesse, groesse];
        }

        public Stecz20(Stecz20 andere)
        {
            groesse = andere.groesse;
            raumName = andere.raumName;
            frage = andere.frage;
            matrix = new int[groesse, groesse];

            for (int zeile = 0; zeile < groesse; zeile++)
            {
                for (int spalte = 0; spalte < groesse; spalte++)
                {
                    matrix[zeile, spalte] = andere.matrix[zeile, spalte];
                }
            }
        }

        public int SteczMethode1()
        {
            int anzahlPferde = 0;

            for (int zeile = 0; zeile < groesse; zeile++)
            {
                for (int spalte = 0; spalte < groesse; spalte++)
                {
                    if ((zeile + spalte) % 2 == 0)
                    {
                        matrix[zeile, spalte] = 1;
                        anzahlPferde++;
                    }
                }
            }

            return anzahlPferde;
        }

        public void SteczMethode2()
        {
            Console.WriteLine(raumName);
            Console.WriteLine("Auf jedem Feld der Matrix kann ein Pferd stehen.");
            Console.WriteLine("Ein Pferd bewegt sich wie ein Springer: zwei Felder in eine Richtung und ein Feld zur Seite.");
            Console.WriteLine();

            for (int zeile = 0; zeile < groesse; zeile++)
            {
                Console.Write("| ");
                for (int spalte = 0; spalte < groesse; spalte++)
                {
                    Console.Write(". ");
                }
                Console.WriteLine("|");
            }

            Console.WriteLine();
            Console.WriteLine(frage);
            Console.WriteLine("Du hast 3 Chancen.");
            int richtigeAntwort = SteczMethode1();

            for (int chance = 1; chance <= 3; chance++)
            {
                Console.Write($"Antwort, Chance {chance}: ");
                if (int.TryParse(Console.ReadLine(), out int antwort) && antwort == richtigeAntwort)
                {
                    Console.WriteLine("Die Aufgabe ist gelöst.");
                    return;
                }

                if (chance < 3)
                {
                    Console.WriteLine("Falsch. Du hast noch eine Chance.");
                }
            }

            Console.WriteLine("Du hast keine Chancen mehr.");
        }
    }
}

