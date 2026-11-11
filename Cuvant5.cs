using System;

public class Cuvant5
{
    public Cuvant5()
    {
        string cuvantAme = "AREM";
        string cuvant = "MARE";
        bool ok = false;

        Console.WriteLine("Cuvantul amestecat este: " + cuvantAme);
        Console.WriteLine("Care este cuvantul?");
        while (!ok)
        {
            string raspuns = Console.ReadLine();
            if (raspuns == cuvant)
            {
                Console.WriteLine("Da,asta era cuvantul");
                ok = true;
            }
            else
            {
                Console.WriteLine("Gresit, mai incearca o data");
            }
        }
    }
}
