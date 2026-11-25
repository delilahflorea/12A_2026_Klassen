namespace EscapeRoom
{
    internal class Huditan06
    {
        private string _aufgabe;
        private int _cifra;

        public Huditan06() : this("Sunt un număr care se citește la fel de la început și de la sfârșit. Sunt divizibil cu 2 și 3 și conțin cifra aleasă de tine. Ce număr sunt?", -1)
        {
        }

        public Huditan06(string aufgabe, int cifra)
        {
            _aufgabe = aufgabe;
            _cifra = cifra;
        }

        public Huditan06(Huditan06 anderesRätsel)
            : this(anderesRätsel._aufgabe, anderesRätsel._cifra)
        {
        }

        public void Mathe()
        {
            Console.WriteLine(_aufgabe);
            Console.Write("Introdu o cifră de la 0 la 9: ");

            while (!int.TryParse(Console.ReadLine(), out _cifra) || _cifra < 0 || _cifra > 9)
            {
                Console.Write("Valoare invalidă. Introdu o cifră de la 0 la 9: ");
            }

            int palindrom = FindePalindrom();
            Console.Write("Scrie palindromul la care te gândești: ");

            if (int.TryParse(Console.ReadLine(), out int raspuns) && raspuns == palindrom)
            {
                Console.WriteLine("Ai câștigat! Răspuns corect.");
            }
            else
            {
                Console.WriteLine("Ai pierdut! Răspuns greșit.");
            }
        }

        private int FindePalindrom()
        {
            for (int zahl = 1; ; zahl++)
            {
                string zahlAlsText = zahl.ToString();
                char[] umgekehrt = zahlAlsText.ToCharArray();
                Array.Reverse(umgekehrt);

                bool istPalindrom = zahlAlsText == new string(umgekehrt);
                bool istDurchZweiTeilbar = zahl % 2 == 0;
                bool istDurchDreiTeilbar = zahl % 3 == 0;
                bool enthältCifra = zahlAlsText.Contains(_cifra.ToString());

                if (istPalindrom && istDurchZweiTeilbar && istDurchDreiTeilbar && enthältCifra)
                {
                    return zahl;
                }
            }
        }
    }

}
