using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EscapeRoomVicMade
{
    internal class Victor
    {
        public Victor()
        {

        }

        int antw = 0;
        int tryCountLeft = 3;

        //i need a fun escape room method that prints out a message to the console

        public bool VictorMethode()
        { 
            Console.WriteLine("I have a round face, yet no eyes, nose, or mouth. I have two hands that run in circles all day, yet I never leave home. ");
            Console.WriteLine("How many numbers do I carry?");
            antw = int.Parse(Console.ReadLine());
            if (antw == 12)
            {
                Console.WriteLine("Correct! The answer is 12.");
                Console.WriteLine("The answer is your key to the next puzzle. You may proceed.");
                return true;
            }
            else
            {
                tryCountLeft--;
                if (tryCountLeft > 0)
                {
                    Console.WriteLine($"Incorrect! You have {tryCountLeft} tries left. Please try again.");
                    VictorMethode();
                    return false;
                }
                else
                {
                    Console.WriteLine("Sorry, you have used all your tries. The correct answer was 12.");
                    return false;
                }
            }

        }
    }
}
