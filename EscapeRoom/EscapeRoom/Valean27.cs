using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class Valean27
    {
        public void Class1Methode()
        {
            Console.WriteLine("Der Geheimnisscode");
            Console.WriteLine("Antwortet den Fragen um die Code zu erhalten.");

            Console.Write("Wie viele Jahreszeiten gibt es? ");
            string raspuns1 = Console.ReadLine();

            Console.Write("Wie viele Finger hat eine Hand ");
            string raspuns2 = Console.ReadLine();

            Console.Write("Wie viele Seiten hat ein Dreieck? ");
            string raspuns3 = Console.ReadLine();

            string cod = raspuns1 + raspuns2 + raspuns3;

            if (cod == "453")
            {
                Console.WriteLine("Richtig! Sie sind aus dem Labor aus!");
            }
            else
            {
                Console.WriteLine("Falsch. Versuchen Sie es erneut");
            }
        }

    }
}
