
class Palindrom_Code_09
{
    int code;
    int summe;
    int versuche;
    int[] pali = new int[90];
    Random r = new Random();

    public Palindrom_Code_09(int s)
    {
        code = 0;
        summe = s;
        versuche = 0;
    }
    public Palindrom_Code_09()
    {
        code = 0;
        summe = 0;
        versuche = 0;
    }
    
    public int randomPal(int anzahl)
    {
        int nr = pali[r.Next(0, anzahl)];
        return nr;
    }

    public void grmitte(int code)
    {
        if (code / 10 % 10 >= 5)
            Console.Write("groser oder gleich 5");    
        else
            Console.Write("kleiner als 5");
        Console.WriteLine();
    }
    public void Palindrom()
    {
        int anzahl = 0;
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                if (2 * i + j == summe)
                {
                    pali[anzahl] = 100 * i + 10 * j + i;
                    anzahl++;
                }
            }
        }
        code = randomPal(anzahl);

    }
    public void welcheZahl()
    {
        Console.WriteLine("Der Code ist ein dreistelliges Palindrom. Die Summe der Ziffern ist " + summe + ". Welche ist der Code?");
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine("Versuch " + i);
            int var = Convert.ToInt32(Console.ReadLine());

            if (var == code)
            {
                Console.WriteLine("Richtig!");
                return;
            }
            else
            {
                Console.WriteLine("Falsch!");

                versuche++;

                switch(versuche)
                {
                    case 1:
                        Console.WriteLine("Der Rest der Ziffer in der Mitte geteilt durch 2 ist: " + (code / 10) % 10 % 2);
                        break;
                    case 2:
                        Console.WriteLine("Die mittlere Zahl ist:");
                        grmitte(code);
                        break;
                    case 3:
                        Console.WriteLine("Der Rest der letzter Zahl geteilt durch drei ist: "+ code%3);
                        break;
                    case 4:
                        Console.WriteLine("Letzte Chance:");
                        break;
                }
            }
        }

        Console.WriteLine("Leider verloren! Der Code war " + code);
    }
}


