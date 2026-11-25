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

            Console.WriteLine($"\nSind die Knoten {ersterKnoten} und {zweiterKnoten} adjazent?");
            bool antwort = LiesJaNein();

            if (antwort == sindAdjazent)
            {
                Console.WriteLine("Richtig! Aufgabe gelöst!");
            }
            else
            {
                Console.WriteLine("Leider falsch. Die richtige Antwort wäre " +
                    (sindAdjazent ? "ja" : "nein") + " gewesen.");
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
