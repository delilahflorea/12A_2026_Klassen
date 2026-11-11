/*Erstellt eine Klasse für ein Objekt aus einem Escape Room. 
Das Objekt soll am Ende des Namens eure Katalognr. haben. Das Objekt beinhaltet 3 Daten, 2 Konstruktoren und 2 Methoden.
Die Methoden sollen Aufgaben für den Escape Room für das betreffende Objekt lösen.*/
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EscapeRoom
{
    internal class Robert
    {
        public void RobertMethode()
        {
            Console.WriteLine("um die Antwort zu erhalten,berechne das Integral von sin(2x)");
            string eingabe;
            eingabe = Console.ReadLine();
            if (eingabe == "-cos(2x)/2+C")
            {
                Console.WriteLine("Die Aufgabe ist gelöst.");
            }
            else
            {
                Console.WriteLine("Die Aufgabe ist nicht gelöst.");
            }
        }
    }
}


