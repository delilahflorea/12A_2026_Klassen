using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    public class Beispiel
    {
        //Daten string+int
        //Konstruktoren Kopierungskonstruktor+mit Parameter
        //Eine private Methode, eine public Methode - ruft die private Methode auf

        protected int x = 0; string y = "";
        protected string z = "Basis";
        public Beispiel()
        {

        }
        public Beispiel(Beispiel k)
        {
            x = k.x;
            y = k.y;

        }
        public Beispiel(int x, string y)
        {
            this.x = x;
            this.y = y;
        }

        private void MetPrivate()
        {
            Console.WriteLine("Private Methode in der Basisklasse!");
        }

        protected void MethodePublic()
        {
            Console.WriteLine("Dies ist ein Beispiel einer public Methode die eine private Methode aufruft!");
            MetPrivate();
        }

        public virtual void BeispielMethode2()
        {
            Console.WriteLine("Dies ist ein Beispiel einer virtual Methode in der Basisklasse!");
        }

    }
}