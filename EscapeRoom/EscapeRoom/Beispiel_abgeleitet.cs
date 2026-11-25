using EscapeRoom;
using System;

public class Beispiel_abgeleitet : Beispiel
{
    public Beispiel_abgeleitet()
    {
    }

    new string z = "Abgeleitet";
    public Beispiel_abgeleitet(Beispiel_abgeleitet h) : base(h)
    {
        Console.WriteLine("Kopierungskonstruktor Basis + abgeleitet");
    }
    public Beispiel_abgeleitet(int x, string y) : base(x, y)
    {
        Console.WriteLine("Konstruktor Basis+ abgeleitet");
    }
    public void BeispielMethode1()
    {
        Console.WriteLine("Dies ist ein Beispiel einer Methode in der abgeleiteten Klasse!");
        MethodePublic();
    }

    public override void BeispielMethode2()
    {
        Console.WriteLine("Uberschriebene Methode in der abgeleiteten Klasse!");
    }

    public void BeispielMethode3()
    {
        base.BeispielMethode2();
        BeispielMethode2();
        Console.WriteLine("Basisklasse Methoden und Methoden in der abgeleiteten Klasse!");
        Console.WriteLine("Basisdaten: " + base.z + "Abgeleitete Daten: " + z);
    }
}