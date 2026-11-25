using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class Stoica_21
    {
        public static void Start()
        {
            Console.WriteLine("Im folgenden Program müssen Sie raten, wie viele Damen auf einer n*n Schachtafel gleichzeitig sitzen können, ohne sich einander anzugreifen");
            Console.WriteLine("Geben Sie die Größe der Schachtafel ein (n):");

            int n = int.Parse(Console.ReadLine());

            bool getroffen = false;
            while (!getroffen)
            {
                Console.WriteLine("");
                Console.WriteLine("Geben Sie die Schätzung ein:");
                int s = int.Parse(Console.ReadLine());

                if (s == n)
                {
                    getroffen = true;
                    Console.WriteLine("\nSie haben die richtige Nummer eingegeben.");
                }
                else
                {
                    Console.WriteLine("Sie haben die falsche Nummer eingegeben. Versuchen Sie noch ein Mal.");
                }
            }
        }

    }
}
