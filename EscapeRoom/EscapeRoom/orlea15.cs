using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class orlea15
    {
        protected int code;
        protected string hinweis;
        protected bool geloest;

        public orlea15()
        {
            code = 1239;
            hinweis = "Der Code hat 4 unterschiedliche Ziffern, wobei die erste eine 1 ist.";
            geloest = false;
        }

        public orlea15(int code, string hinweis)
        {
            this.code = code;
            this.hinweis = hinweis;
            geloest = false;
        }

        public void HinweisAnzeigen()
        {
            Console.WriteLine(hinweis);
        }
        public bool CodePruefen(int antwort)
        {
            if (antwort == code)
            {
                Console.WriteLine("Richtig! Der Tresor ist offen!");
                geloest = true;
                return true;
            }
            else
            {
                Console.WriteLine("Falsch! Versuche es noch einmal.");
                return false;
            }
        }
    }
}
