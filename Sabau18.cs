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
              { 0,1,0,1,1 },
              { 1,0,1,0,1 },
              { 0,1,0,1,0 },
              { 1,0,1,0,1 },
              { 1,1,0,1,0 }
            };
            frage = "Welchen Grad hat Knoten nr 2 ?";
        }
        public Sabau18(int n, string roomName)
        {
            this.n = n;
            this.roomName = roomName;
            this.frage = frage;
            m = new int[n, n];
        }
        public void Afismat()
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private void RobertMethode1()
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
            Console.WriteLine();
            /* Console.WriteLine("Die Losung des Escape Rooms besteht aus einem Code aus 4 Zahlen/Buchstaben:");
             string eingabe;
             eingabe = Console.ReadLine();
             if (eingabe == "-cos(2x)/2+C")
             {
                 Console.WriteLine("Die Aufgabe ist gelöst.");
             }
             else
             {
                 Console.WriteLine("Die Aufgabe ist nicht gelöst.");
             }*/
            //Afismat();
        } 
     
        public void RobertMethode2()
        {
            RobertMethode1();
            Console.WriteLine("Dein Antwort auf die Frage: " );
            int antwort =Convert.ToInt32(Console.ReadLine());
            int grad;
            int nrchancen = 3;
            for (int i = 0; i < n; i++)
            {
                grad = 0;
                for (int j = 0; j < n; j++)
                {
                    grad += m[i, j];
                }
                if (i == 2)
                {
                    if (grad == antwort)
                    {
                        Console.WriteLine("Die Aufgabe ist gelöst.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Die Aufgabe ist nicht gelöst.");
                        nrchancen--;
                        if(nrchancen > 0)
                        {
                            Console.WriteLine("Du hast noch " + nrchancen + " Chancen.");
                            Console.WriteLine("Dein Antwort auf die Frage: ");
                            antwort = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Du hast keine Chancen mehr.");
                        }
                    }
                }
            }
        }
    }
}


