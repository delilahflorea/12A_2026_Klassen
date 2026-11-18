using System;

public class Zahlenschloss123
{
    // 3 Daten
    public int Code;
    public string Farbe;
    public bool Offen;

    // 1. Konstruktor
    public Zahlenschloss123()
    {
        Code = 1234;
        Farbe = "Rot";
        Offen = false;
    }

    // 2. Konstruktor
    public Zahlenschloss123(int code, string farbe, bool offen)
    {
        Code = code;
        Farbe = farbe;
        Offen = offen;
    }

    // 1. Methode: Code überprüfen
    public bool CodePruefen(int eingabe)
    {
        return eingabe == Code;
    }

    // 2. Methode: Schloss öffnen
    public void Oeffnen(int eingabe)
    {
        if (CodePruefen(eingabe))
        {
            Offen = true;
            Console.WriteLine("Schloss geöffnet!");
        }
        else
        {
            Console.WriteLine("Falscher Code!");
        }
    }
}

