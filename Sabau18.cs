/*Erstellt eine Klasse für ein Objekt aus einem Escape Room. 
Das Objekt soll am Ende des Namens eure Katalognr. haben. Das Objekt beinhaltet 3 Daten, 2 Konstruktoren und 2 Methoden.
Die Methoden sollen Aufgaben für den Escape Room für das betreffende Objekt lösen.*/
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
//Aufgabe fur Escape Room von Robert Sabau 
//Daten string+int
//Konstruktoren Kopierungskonstruktor + mit Parameter
//Eine private Methode,eine public Methode - ruft die private Methode auf 

namespace EscapeRoom
{
    internal class Sabau18
    {
        int n;
        int[,] m;
        string roomName = "Escape Room Sabau 18";
        string frage;
        public Sabau18()
        {
            this.n = 5;
            this.roomName = roomName;
            m = new int[,]
            {
              { 0,4,0,2,7 },
              { 4,0,1,0,3 },
              { 0,1,0,5,0 },
              { 2,0,5,0,2 },
              { 7,3,0,2,0 }
            };
            frage = "Gib den Zielknoten ein. Startknoten ist 0. Wie lang ist der kürzeste Weg?";

        }
        public Sabau18(Sabau18 andere)
        {
            this.n = andere.n;
            this.roomName = andere.roomName;
            this.frage = andere.frage;
            this.m = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    this.m[i, j] = andere.m[i, j];
                }
            }
        }

        protected int RobertMethode1(int ziel)
        {
            return RobertMethode1(0, ziel);
        }

        protected int RobertMethode1(int start, int ziel)
        {
            int[] entfernung = new int[n];
            bool[] besucht = new bool[n];

            for (int i = 0; i < n; i++)
            {
                entfernung[i] = int.MaxValue;
            }
            entfernung[start] = 0;

            for (int schritt = 0; schritt < n; schritt++)
            {
                int aktuellerKnoten = -1;
                for (int i = 0; i < n; i++)
                {
                    if (!besucht[i] && (aktuellerKnoten == -1 || entfernung[i] < entfernung[aktuellerKnoten]))
                    {
                        aktuellerKnoten = i;
                    }
                }

                if (aktuellerKnoten == -1)
                {
                    break;
                }

                besucht[aktuellerKnoten] = true;
                for (int nachbar = 0; nachbar < n; nachbar++)
                {
                    if (m[aktuellerKnoten, nachbar] > 0 &&
                        entfernung[aktuellerKnoten] + m[aktuellerKnoten, nachbar] < entfernung[nachbar])
                    {
                        entfernung[nachbar] = entfernung[aktuellerKnoten] + m[aktuellerKnoten, nachbar];
                    }
                }
            }

            return entfernung[ziel];
        } 
     
        public void RobertMethode2()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(frage);
            Console.WriteLine("Gib eine Zahl zwischen 0 und 4 ein:");
            int ziel = Convert.ToInt32(Console.ReadLine());
            int richtigeAntwort = RobertMethode1(0, ziel);

            int nrchancen = 3;
            while (nrchancen > 0)
            {
                Console.WriteLine("Dein Antwort auf die Frage: ");
                int antwort = Convert.ToInt32(Console.ReadLine());

                if (richtigeAntwort == antwort)
                {
                    Console.WriteLine("Die Aufgabe ist gelöst.");
                    return;
                }

                Console.WriteLine("Die Aufgabe ist nicht gelöst.");
                nrchancen--;
                if (nrchancen > 0)
                {
                    Console.WriteLine("Du hast noch " + nrchancen + " Chancen.");
                }
                else
                {
                    Console.WriteLine("Du hast keine Chancen mehr.");
                }
            }
        }
    }
}


