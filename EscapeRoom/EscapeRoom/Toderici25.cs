public class Toderici25
{
    public Toderici25()
    {

    }

    public Toderici25(int raspuns, int incercari_rele)
    {
        this.rightansw = raspuns;
        this.wrongansw = incercari_rele;
    }

    int antw = 0;
    public int wrongansw = 0;
    public int rightansw = 0;

    //i need a fun escape room method that prints out a message to the console

    public void Toderici25Methode()
    {
        Console.WriteLine("I have a round face, yet no eyes, nose, or mouth. I have two hands that run in circles all day, yet I never leave home. ");
        Console.WriteLine("How many numbers do I carry?");
        antw = int.Parse(Console.ReadLine());
        if (antw == 12)
        {
            Console.WriteLine("Correct! The answer is 12.");
            Console.WriteLine("The answer is your key to the next puzzle. You may proceed.");
            rightansw++;

        }
        else
        {
            Console.WriteLine("Incorrect. Try again.");
            wrongansw++;
            Toderici25Methode();
        }

    }

    //a sedond challange, with 3 modes based on the constructor with parameter. If the user gets the answer right the first time its easy, if they get it wrong once its medium, if they get it wrong twice or moreits hard. The user has 3 tries to get the answer right. If they get it wrong 3 times the game ends and they have to start over. 

    public void Toderici25Methode2(int rightansw, int wrongansw)
    {
        if (wrongansw >= 3)
        {
            wrongansw = 2;
        }
        switch (wrongansw)
        {
            case 0:
                Console.WriteLine("Easy mode:");
                Console.WriteLine("9+10");
                antw = int.Parse(Console.ReadLine());
                if (antw == 21)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. Difficulty increased.You should have known this. 9+10=21");
                    wrongansw++;
                    Toderici25Methode2(rightansw, wrongansw);
                }
                break;
            case 1:
                Console.WriteLine("Medium mode:");
                Console.WriteLine("Calculate f'(4) if f(x) = (x^3 + 32) / sqrt(x)");
                antw = int.Parse(Console.ReadLine());
                if (antw == 18)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. Difficulty increased.");
                    wrongansw++;
                    Toderici25Methode2(rightansw, wrongansw);
                }
                break;
            case 2:
                // Hard mode
                Console.WriteLine("Hard mode:");
                Console.WriteLine("Calculate the definite integral from 0 to pi/2 of: (12*sin^2(x)*cos(x) + 4*cos(x)) dx");
                antw = int.Parse(Console.ReadLine());
                if (antw == 8)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect.Try again.");
                    wrongansw++;
                    Toderici25Methode2(rightansw, wrongansw);
                }
                break;
        }
    }

}
