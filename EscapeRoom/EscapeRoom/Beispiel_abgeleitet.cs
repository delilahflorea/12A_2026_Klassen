using EscapeRoom;
using System;

public class Beispiel_abgeleitet : Beispiel
{
	public Beispiel_abgeleitet()
	{
	}

    new string z = "abgeleitet";
    public Beispiel_abgeleitet(Beispiel_abgeleitet h) : base(h)
    {
        Console.WriteLine("Kopierungskonstruktor Basis+ abgeleitet");
    }
    public Beispiel_abgeleitet(int x, string y) : base(x, y)
    {
        Console.WriteLine("Konstruktor Basis+ abgeleitet");
    }
    public void BeispielMethode1()
    {
        Console.WriteLine("Dies ist ein Beispiel einer Methode in der abgeleiteten Klasse!");
        BeispielMethode1();
    }

    public override void BeispielMethode2()
    {
        Console.WriteLine("Uberschriebene Methode");
    }

    public void BeispielMethode3()
    {
        base.BeispielMethode2();
        BeispielMethode2();
        Console.WriteLine(z + base.z);
    }

}
