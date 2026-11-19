internal class Tuca_26_2 : Tuca_26
{
    private int neueBasis10;
    private string zielBasis6;

    public Tuca_26_2() : base()
    {
        neueBasis10 = 0;
        zielBasis6 = "";
    }

    public void b10inb6()
    {
        int neueZiffern = new Random().Next(10, 100);
        neueBasis10 = minuten * 100 + neueZiffern;
        
        int aux = neueBasis10;
        zielBasis6 = "";

        while (aux > 0)
        {
            int rest = aux % 6;
            zielBasis6 = rest + zielBasis6; 
            aux = aux / 6;
        }

        while (true)
        {
            Console.WriteLine("An der Minutenanzahl (" + minuten + ") werden zwei Ziffern angehängt.");
            Console.WriteLine("Deine neue Zahl lautet: " + neueBasis10);
            Console.Write("Wandle diese Zahl zurück in Basis 6 um: ");

            string antwort = Console.ReadLine().Trim();

            if (antwort == zielBasis6)
            {
                Console.WriteLine("Richtig!");
                break;
            }
            else
            {
                Console.WriteLine("Falsch! Versuche noch einmal.\n");
            }
        }
    }
}
