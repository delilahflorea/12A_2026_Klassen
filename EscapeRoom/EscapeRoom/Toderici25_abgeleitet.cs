public class Toderici25_abgeleitet : Toderici25
{
    public Toderici25_abgeleitet() : base()
    {
    }

    public Toderici25_abgeleitet(Toderici25_abgeleitet k) : base(k)
    {
        Console.WriteLine("Copy constructor: base + derived");
    }

    public Toderici25_abgeleitet(int raspuns, int incercari_rele) : base(raspuns, incercari_rele)
    {
        Console.WriteLine("Constructor: base + derived");
    }

    public override void Toderici25Methode2(int rightansw, int wrongansw)
    {
        Console.WriteLine("Level 2 - the clock is back!");
        Console.WriteLine("How many times do the hour and minute hands overlap in 12 hours?");
        antw = int.Parse(Console.ReadLine());  
        if (antw == 11)
        {
            Console.WriteLine("Correct! You may proceed.");
            this.rightansw++;
        }
        else
        {
            Console.WriteLine("Incorrect. Try again.");
            this.wrongansw++;
            Toderici25Methode2(this.rightansw, this.wrongansw);
        }
    }

    public void Toderici25Methode3()
    {
        base.Toderici25Methode2(rightansw, wrongansw);
        Toderici25Methode2(rightansw, wrongansw);
    }
}
