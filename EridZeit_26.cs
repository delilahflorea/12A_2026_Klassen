using System;

public class EridZeit_26
{
	private int minuten;
private string basis6;
private int basis10;

public EridZeit_26()
{
    basis6 = "";
    basis10 = 0;
}

public EridZeit_26(string Basis6Zahl)
{
    basis6 = Basis6Zahl;
    basis10 = 0;
}
public void Basis6()
{
    string[] zeilen = File.ReadAllLines("Basis6.txt");
    basis6 = zeilen[0].Trim();

    for (int i = 0; i < zeilen.Length - 1; i++)
    {
        zeilen[i] = zeilen[i + 1];
    }
    zeilen[zeilen.Length - 1] = basis6;
    File.WriteAllLines("Basis6.txt", zeilen);

    basis10 = 0;
    int multi = 1; 

    for (int i = basis6.Length - 1; i >= 0; i--)
    {
        int ziff = basis6[i] - '0';
        basis10 += ziff * multi;
        multi *= 6;
    }

    while (true)
    {
        Console.WriteLine("Wandle die folgende Zahl um, damit du witergehen kannst: " + basis6);
        Console.Write("Deine Antwort: ");

        string eingabe = Console.ReadLine();

        if (int.TryParse(eingabe, out int Antwort) && Antwort == basis10)
        {
            Zeit();
            break; 
        }
        else
        {
            Console.WriteLine("Falsch! Rechne noch einmal.\n");
        }
    }
}
public void Zeit()
{
    minuten = basis10 / 60;

    while (true)
    {
        Console.WriteLine("Jetzt wandle die Zahl " + basis10 + " in Minuten um.");
        string eingabeMin = Console.ReadLine();

        if (int.TryParse(eingabeMin, out int AntwortMin) && AntwortMin == minuten)
        {
            Console.WriteLine("Richtig! Du kannst jetzt witergehen!");
            break; 
        }
        else
        {
            Console.WriteLine("Falsch! Rechne noch einmal.\n");
        }
    }
}
}
