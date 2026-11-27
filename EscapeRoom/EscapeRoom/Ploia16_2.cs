namespace EscapeRoom
{
    internal class Ploia16_2
    {
        private readonly string objektName;
        private readonly int[,] matrix;
        private readonly int richtigeAntwort;

        public Ploia16_2()
            : this("Zahlenmatrix", new int[,]
            {
                { 6, 8, 5, 7 },
                { 9, 7, 1, 4 },
                { 4, 2, 3, 8 },
                { 1, 5, 6, 2 }
                }, 96)
        {
        }

        public Ploia16_2(string objektName, int[,] matrix, int richtigeAntwort)
        {
            this.objektName = objektName;
            this.matrix = matrix;
            this.richtigeAntwort = richtigeAntwort;
        }

        public int BerechneCode()
        {
            int summe = 0;
            int diagonale = 0;

            for (int zeile = 0; zeile < matrix.GetLength(0); zeile++)
            {
                for (int spalte = 0; spalte < matrix.GetLength(1); spalte++)
                {
                    summe += matrix[zeile, spalte];

                    if (zeile == spalte)
                    {
                        diagonale += matrix[zeile, spalte];
                    }
                }
            }

            return summe + diagonale;
        }

        public void Loesung()
        {
            Console.WriteLine("\n--- " + objektName + " ---");
            Console.WriteLine("Berechne den Geheimcode der Matrix.");
            Console.WriteLine("Die Matrix lautet:");

            for (int zeile = 0; zeile < matrix.GetLength(0); zeile++)
            {
                for (int spalte = 0; spalte < matrix.GetLength(1); spalte++)
                {
                    Console.Write(matrix[zeile, spalte] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Addiere zuerst alle Zahlen der Matrix.");
            Console.WriteLine("Addiere danach noch einmal die Zahlen der Hauptdiagonale.");
            Console.WriteLine("Wie lautet der Geheimcode?");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int antwort))
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein!");
                    continue;
                }

                if (antwort == richtigeAntwort)
                {
                    Console.WriteLine("Richtig! Der Geheimcode lautet " + BerechneCode() + ".");
                    return;
                }

                Console.WriteLine("Falsch! Versuche es noch einmal.");
            }
        }
    }
}
