namespace EscapeRoom
{
    internal class Huditan06
    {
        private string _aufgabe;
        private int _cifra;

        public Huditan06() : this("Screibe ein Nummer der auch von hinten gelesen werden kann und durch 2 und 3 teilbar ist", -1)
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
            Console.Write("Schreibe eine Ziffer von 0 bis 9: ");

            while (!int.TryParse(Console.ReadLine(), out _cifra) || _cifra < 0 || _cifra > 9)
            {
                Console.Write("Ungültige Eingabe. Bitte eine Ziffer von 0 bis 9 eingeben: ");
            }

            int palindrom = FindePalindrom();
            Console.Write("Schreibe das Palindrom, an das du denkst: ");

            if (int.TryParse(Console.ReadLine(), out int raspuns) && raspuns == palindrom)
            {
                Console.WriteLine("Du hast gewonnen! Richtiges Ergebnis.");
            }
            else
            {
                Console.WriteLine("Du hast verloren! Falsche Antwort.");
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
