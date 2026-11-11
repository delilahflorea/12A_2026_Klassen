public class Class1
{
    public void Herausforderung16()
    {
        Console.WriteLine("\n--- Herausforderung 16 ---");
        Console.WriteLine("Lose das Zahlenrätsel!");

        string[] zeilen =
        {
            "6 8 5",
            "9 7 1",
            "4 2 3"
        };

        int n = zeilen.Length;
        int m = zeilen[0].Split(' ').Length;

        Console.WriteLine("Die Matrix hat " + n + " Zeilen und " + m + " Spalten.");

        Console.WriteLine("Wie viele Zahlen enthalt die Matrix insgesamt?");

        int antwort;

        if (int.TryParse(Console.ReadLine(), out antwort))
        {
            if (antwort == n * m)
            {
                Console.WriteLine("Richtig! Die Matrix enthalt " + (n * m) + " Zahlen.");
            }
            else
            {
                Console.WriteLine("Falsch! Die Matrix enthalt " + (n * m) + " Zahlen.");
            }
            else
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein!");
            }

        }
    }