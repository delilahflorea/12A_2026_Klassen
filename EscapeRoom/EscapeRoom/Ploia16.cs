using System;

public class Class1
{
    private string frage;
    private int richtigeAntwort;

    public Class1()
        : this("Wie viele Zahlen enthält die Matrix insgesamt?", 16)
    {
    }
    public Class1(string frage, int richtigeAntwort)
    {
        this.frage = frage;
        this.richtigeAntwort = richtigeAntwort;
    }
    public Class1(Class1 andereKlasse)
        : this(andereKlasse.frage, andereKlasse.richtigeAntwort)
    {
    }
    private bool IstAntwortRichtig(int antwort)
    {
        return antwort == richtigeAntwort;
    }
    public void Herausforderung16()
    {
        Console.WriteLine("\n--- Herausforderung 16 ---");
        Console.WriteLine("Löse das Zahlenrätsel!");

        string[] zeilen =
        {
            "6 8 5 7",
            "9 7 1 4",
            "4 2 3 8",
            "1 5 6 2"
        };

        int n = zeilen.Length;
        int m = zeilen[0].Split(' ').Length;

        Console.WriteLine("Die Matrix hat " + n + " Zeilen und " + m + " Spalten.");
        Console.WriteLine(frage);

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int antwort))
            {
                if (IstAntwortRichtig(antwort))
                {
                    Console.WriteLine("Richtig! Die Matrix enthält " + (n * m) + " Zahlen.");
                    break;
                }
                Console.WriteLine("Falsch! Versuche es noch einmal.");
            }
            else
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein!");
            }
        }
    }
}