using System;
class Ratsel_6
{
    public void    Mathe()
    {
        Console.WriteLine("Rätsel 6: Was ist Wurzel von 625 und 324?");
        int antwort = Int32.Parse(Console.ReadLine());
        if (antwort == 25 && antwort == 18)
        {
            Console.WriteLine("Richtig! Das Rätsel ist gelöst.");
        }
        else
        {
            Console.WriteLine("Falsch! Versuche es noch einmal.");
        }
    }
}
