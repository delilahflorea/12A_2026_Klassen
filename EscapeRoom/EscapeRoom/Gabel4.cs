namespace EscapeRoom
{
    // der graf und ihre adjaze4nzmatrix soll schon ertesllt sein und das spielist das man auf die adjmatrix hinschauen soll und sagen ob 2 knoten adjazent sind 
    internal class Gabel4
    {
        private readonly int[,] adjazenzmatrix;
        private readonly int anzahlKnoten;
        private readonly Random zufallsgenerator;

        public Gabel4()
        {
            adjazenzmatrix = new int[,]
            {
                { 0, 1, 1, 0, 0, 0 },
                { 1, 0, 0, 1, 0, 0 },
                { 1, 0, 0, 1, 1, 0 },
                { 0, 1, 1, 0, 0, 1 },
                { 0, 0, 1, 0, 0, 1 },
                { 0, 0, 0, 1, 1, 0 }
            };
            anzahlKnoten = adjazenzmatrix.GetLength(0);
            zufallsgenerator = new Random();
        }

        public Gabel4(Gabel4 vorlage)
        {
            adjazenzmatrix = (int[,])vorlage.adjazenzmatrix.Clone();
            anzahlKnoten = vorlage.anzahlKnoten;
            zufallsgenerator = new Random();
        }

        public void SofiaMethode()
        {
            Console.WriteLine("Adjazenzmatrix des Graphen:");
            Console.Write("    ");
            for (int i = 0; i < anzahlKnoten; i++)
            {
                Console.Write($"{i,3}");
            }

            Console.WriteLine();
            for (int zeile = 0; zeile < anzahlKnoten; zeile++)
            {
                Console.Write($"{zeile,3} ");
                for (int spalte = 0; spalte < anzahlKnoten; spalte++)
                {
                    Console.Write($"{adjazenzmatrix[zeile, spalte],3}");
                }

                Console.WriteLine();
            }

            int ersterKnoten = zufallsgenerator.Next(anzahlKnoten);
            int zweiterKnoten;
            do
            {
                zweiterKnoten = zufallsgenerator.Next(anzahlKnoten);
            }
            while (zweiterKnoten == ersterKnoten);

            bool sindAdjazent = adjazenzmatrix[ersterKnoten, zweiterKnoten] == 1;

            Console.WriteLine($"\nLevel 1: Sind die Knoten {ersterKnoten} und {zweiterKnoten} adjazent?");
            bool antwort = LiesJaNein();

            if (antwort != sindAdjazent)
            {
                Console.WriteLine("Leider falsch. Die richtige Antwort wäre " +
                    (sindAdjazent ? "ja" : "nein") + " gewesen.");
                return;
            }

            Console.WriteLine("Richtig!");

            int knoten = zufallsgenerator.Next(anzahlKnoten);
            int grad = 0;
            for (int spalte = 0; spalte < anzahlKnoten; spalte++)
            {
                grad += adjazenzmatrix[knoten, spalte];
            }

            Console.WriteLine($"\nLevel 2: Welchen Grad hat Knoten {knoten}?");
            Console.Write("Deine Antwort: ");
            if (!int.TryParse(Console.ReadLine(), out int gradAntwort) || gradAntwort != grad)
            {
                Console.WriteLine($"Leider falsch. Der Grad von Knoten {knoten} ist {grad}.");
                return;
            }

            Console.WriteLine("Richtig!");

            knoten = zufallsgenerator.Next(anzahlKnoten);
            bool[] nachbarn = new bool[anzahlKnoten];
            for (int spalte = 0; spalte < anzahlKnoten; spalte++)
            {
                nachbarn[spalte] = adjazenzmatrix[knoten, spalte] == 1;
            }

            Console.WriteLine($"\nLevel 3: Welche Knoten sind Nachbarn von Knoten {knoten}?");
            Console.WriteLine("Gib die Knotennummern durch Leerzeichen getrennt ein.");
            Console.Write("Deine Antwort: ");
            string eingabe = Console.ReadLine() ?? string.Empty;
            bool[] antwortNachbarn = new bool[anzahlKnoten];
            bool gueltigeEingabe = true;

            foreach (string teil in eingabe.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (!int.TryParse(teil, out int nachbar) || nachbar < 0 || nachbar >= anzahlKnoten)
                {
                    gueltigeEingabe = false;
                    break;
                }

                antwortNachbarn[nachbar] = true;
            }

            for (int i = 0; i < anzahlKnoten; i++)
            {
                if (antwortNachbarn[i] != nachbarn[i])
                {
                    gueltigeEingabe = false;
                    break;
                }
            }

            if (gueltigeEingabe)
            {
                Console.WriteLine("Richtig! Aufgabe gelöst!");
            }
            else
            {
                Console.Write("Leider falsch. Die Nachbarn sind: ");
                for (int i = 0; i < anzahlKnoten; i++)
                {
                    if (nachbarn[i])
                    {
                        Console.Write($"{i} ");
                    }
                }

                Console.WriteLine();
            }
        }

        private static bool LiesJaNein()
        {
            while (true)
            {
                Console.Write("Deine Antwort (ja/nein),DU HAST EINE CHANCE: ");
                string antwort = Console.ReadLine()?.Trim().ToLowerInvariant() ?? string.Empty;

                if (antwort == "ja" || antwort == "j")
                {
                    return true;
                }

                if (antwort == "nein" || antwort == "n")
                {
                    return false;
                }

                Console.WriteLine("Bitte antworte mit ja oder nein.");
            }
        }
    }
}
