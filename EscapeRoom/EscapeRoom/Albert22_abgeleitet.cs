using EscapeRoom;
using System;

public class Albert22_abgeleitet : Albert22
{
    public Albert22_abgeleitet()
    {
    }

    new string z = "Abgeleitet";
    public Albert22_abgeleitet(Albert22_abgeleitet h) : base(h)
    {
        Console.WriteLine("Kopierungskonstruktor Basis + abgeleitet");
    }
    public Albert22_abgeleitet(int x, string y) : base(x, y)
    {
        Console.WriteLine("Konstruktor Basis+ abgeleitet");
    }
    public void AlbertMethode1()
    {
        Console.WriteLine("Dies ist eine Albert-Methode in der abgeleiteten Klasse!");
        MethodePublic();
    }

    public override void AlbertMethode2()
    {
        Console.WriteLine("Uberschriebene Methode in der abgeleiteten Klasse!");
    }

    public void AlbertMethode3()
    {
        base.AlbertMethode2();
        AlbertMethode2();
        Console.WriteLine("Basisklasse Methoden und Methoden in der abgeleiteten Klasse!");
        Console.WriteLine("Basisdaten: " + base.z + "Abgeleitete Daten: " + z);
    }
}
