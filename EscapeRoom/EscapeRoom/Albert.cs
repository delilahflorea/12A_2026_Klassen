using System;

//Erstellt eine Klasse für ein Objekt aus einem Escape Room. Das Objekt soll am Ende des Namens eure Katalognr. haben. 
//Das Objekt beinhaltet 3 Daten, 2 Konstruktoren und 2 Methoden. Die Methoden sollen Aufgaben für den Escape Room 
//für das betreffende Objekt lösen.

//ich will testen ob der spieler als erstes 1 als int korrekt eintippt und dann sollte die kode schreiben, dass es korrekt ist und dass
//die Aufgabe gelöst ist.

namespace EscapeRoom
{
    internal class Albert
    {
        public void AlbertMethode()
        {
            Console.WriteLine("Dies ist die Albert-Methode.");

            int eingabe;
            Console.WriteLine("Bitte geben Sie die Zahl 1 ein:");
            eingabe = Int32.Parse(Console.ReadLine());
            if (eingabe == 1)
            {
                Console.WriteLine("Korrekt! Aufgabe gelöst.");
            }
            else
            {
                Console.WriteLine("Falsch! Bitte versuchen Sie es erneut.");
            }
        }
    }
}
