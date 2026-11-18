namespace EscapeRoom
{
    internal class Terioiu23
    {
        //Daten string+int
        //Konstruktoren Kopierungskonstruktore+mit Parametern
        //eine private Methode, eine public methode, die die private Methode aufruft
        private int codSecret;
        private string loc;
        private bool deschis;

        public Terioiu23()
        {
            codSecret = 1235;
            loc = "Biblioteca";
            deschis = false;
        }

        public Terioiu23(int codSecret, string loc)
        {
            this.codSecret = codSecret;
            this.loc = loc;
            deschis = false;
        }

        public bool VerificaCod(int codIntrodus)
        {
            return codIntrodus == codSecret;
        }

        public bool DeschideTresor(int codIntrodus)
        {
            if (VerificaCod(codIntrodus))
            {
                deschis = true;
            }

            return deschis;
        }
    }
}
