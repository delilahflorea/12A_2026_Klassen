using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom
{
    internal class Milea10
    {
        static Random rng = new Random();

        public bool Start()
        {
            int answer = GenPolNotSolv();
            return guess(answer);
        }

        static int rand()
        {
            int a = rng.Next(1, 12);
            return a;
        }

        static char randoperator()
        {
            char[] ops = { '+', '-', '*' };
            int a = rng.Next(0, 3);
            return ops[a];
        }

        /*
        static void genPolNot()
        {
            string expr = rand().ToString();

            for (int i = 0; i < 4; i++)
            {
                char op = randoperator();
                int num = rand();

                if (rng.Next(2) == 0)
                {
                    expr = $"{num} {expr} {op}";
                }
                else
                {
                    expr = $"{expr} {num} {op}";
                }
            }
            Console.WriteLine(expr);
        } */
        static int GenPolNotSolv()
        {
            int answer = rand();
            string expr = answer.ToString();

            for (int i = 0; i < 4; i++)
            {
                char op = randoperator();
                int num = rand();

                if (rng.Next(2) == 0)
                {
                    answer = calculate(num, answer, op);
                    expr = $"{num} {expr} {op}";
                }
                else
                {
                    answer = calculate(answer, num, op);
                    expr = $"{expr} {num} {op}";
                }
            }
            Console.WriteLine(expr);

            return answer;
        }

        static int calculate(int left, int right, char op)
        {
            if (op == '+') return left + right;
            if (op == '-') return left - right;
            return left * right;
        }

        static bool guess(int answer)
        {
            Console.WriteLine("Was ist die Antwort?");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == answer)
            {
                Console.WriteLine("Richtig!");
                return true;
            }
            else
            {
                Console.WriteLine($"Falsch. Die Antwort war {answer}.");
                return false;
            }
        }
    }
}
