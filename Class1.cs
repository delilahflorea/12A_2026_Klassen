using System;

namespace EscapeRoom
{
    internal class Class1
    {
        public void StartGame()
        {
            Console.WriteLine("Rätselraum: Der vierstellige Fluchtcode");
            Console.WriteLine("Beantworte die vier Fragen mit Zahlen.");
            Console.WriteLine();

            int[] antworten = new int[4];
            string[] fragen =
            {
                "Frage 1: Wie viele Tage hat eine Woche?",
                "Frage 2: Wie viele Beine hat eine Spinne?",
                "Frage 3: Wie viele Finger hat eine Hand?",
                "Frage 4: Wie viele Seiten hat ein Dreieck?"
            };

            for (int i = 0; i < fragen.Length; i++)
            {
                Console.Write(fragen[i] + " ");
                while (!int.TryParse(Console.ReadLine(), out antworten[i]) || antworten[i] < 0 || antworten[i] > 9)
                {
                    Console.Write("Bitte gib eine einzelne Ziffer ein: ");
                }
            }

            string code = string.Join("", antworten);
            Console.WriteLine();
            Console.Write("Gib den vierstelligen Fluchtcode ein: ");
            string eingegebenerCode = Console.ReadLine() ?? "";

            if (eingegebenerCode == code && code == "7853")
            {
                Console.WriteLine("Der Code ist richtig!");
                Console.WriteLine("Du bist entkommen! Herzlichen Glückwunsch!");
            }
            else
            {
                Console.WriteLine("Der Code ist falsch. Die Tür bleibt verschlossen.");
            }
        }       
    }
}
