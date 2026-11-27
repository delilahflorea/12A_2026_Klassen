namespace EscapeRoom;

internal class Nicula13Level2 : Nicula13
{
    const int size = 20;
    const int targets = 3;
    char[,] mat2 = new char[size, size];
    int[] oddi2 = new int[targets];
    int[] oddj2 = new int[targets];
    int[] reihenfolge = new int[targets];

    public Nicula13Level2() : base()
    {
    }

    public void Nicula13Level2methode()
    {
        Console.WriteLine("\nLevel 2 baut auf Level 1 auf, startet aber mit einem neuen Rätsel.");
        Nicula13Level2methode2_2();
    }

    public void Nicula13Level2methode2_2()
    {
        Console.WriteLine("\nLevel 2: Finden Sie drei n zwischen den m.");
        Console.WriteLine("Es gibt genau drei n");
        Console.WriteLine("Die Reihenfolge richtet sich nach der Spalte: sie typen die n-koordonate der n, das am nächsten an Spalte 1 liegt.");
        for (int target = 0; target < targets; target++)
        {
            do
            {
                oddi2[target] = Random.Shared.Next(1, size);
                oddj2[target] = Random.Shared.Next(1, size);

                bool alreadyUsed = false;
                for (int previous = 0; previous < target; previous++)
                {
                    if (oddi2[previous] == oddi2[target] && oddj2[previous] == oddj2[target])
                    {
                        alreadyUsed = true;
                    }
                }

                if (!alreadyUsed)
                {
                    break;
                }
            }
            while (true);
        }

        for (int i = 0; i < targets; i++)
        {
            reihenfolge[i] = i;
        }

        for (int i = 0; i < targets - 1; i++)
        {
            for (int j = i + 1; j < targets; j++)
            {
                int first = reihenfolge[i];
                int second = reihenfolge[j];

                if (oddj2[second] < oddj2[first]
                    || (oddj2[second] == oddj2[first] && oddi2[second] < oddi2[first]))
                {
                    reihenfolge[i] = second;
                    reihenfolge[j] = first;
                }
            }
        }

        Console.Write("i\\j ");
        for (int j = 1; j < size; j++)
        {
            Console.Write($"{j,2} ");
        }

        Console.WriteLine();

        for (int i = 1; i < size; i++)
        {
            Console.Write($"{i,2}  ");

            for (int j = 1; j < size; j++)
            {
                bool isTarget = false;
                for (int target = 0; target < targets; target++)
                {
                    if (i == oddi2[target] && j == oddj2[target])
                    {
                        isTarget = true;
                    }
                }

                mat2[i, j] = isTarget ? 'n' : 'm';
                Console.Write(mat2[i, j] + "  ");
            }

            Console.WriteLine();
        }

        int found = 0;

        while (found < targets)
        {
            Console.WriteLine($"\nGesucht wird das n Nummer {found + 1} von {targets}.");
            Console.Write("Reihe i (1-19): ");
            if (!int.TryParse(Console.ReadLine(), out int row)
                || row < 1
                || row >= size)
            {
                Console.WriteLine("Ungültige Reihe.");
                continue;
            }

            Console.Write("Spalte j (1-19): ");
            if (!int.TryParse(Console.ReadLine(), out int column)
                || column < 1
                || column >= size)
            {
                Console.WriteLine("Ungültige Spalte.");
                continue;
            }

            int target = reihenfolge[found];
            if (row == oddi2[target] && column == oddj2[target])
            {
                found++;
                Console.WriteLine($"Richtig! {found}/{targets} n gefunden.");
            }
            else
            {
                Console.WriteLine("Falsche Koordinaten oder falsche Reihenfolge. Versuchen Sie noch einmal.");
            }
        }

        Console.WriteLine("\nAlle drei n wurden in der richtigen Reihenfolge gefunden!");
        Console.WriteLine("gluckwunsch!!!");
        Console.WriteLine("        \\ | /");
        Console.WriteLine("      -- \\|/ --");
        Console.WriteLine("         \\|/");
        Console.WriteLine("      -- /|\\ --");
        Console.WriteLine("        / | \\");
        Console.WriteLine("          |");
        Console.WriteLine("          |");
        Console.WriteLine("        __|__");
        Console.WriteLine("       /     \\");
     
    }
}
