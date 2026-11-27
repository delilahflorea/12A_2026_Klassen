using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace EscapeRoom;

internal class Nicula13
{
    char[,] mat = new char[15, 15];
    int i, j;
    int oddi = 0;
    int oddj = 0;

    public Nicula13()
    {

    }


    public void Nicula13methode()
    {
        Console.Write("\nFinden Sie die z zwischen den s \n");
        Random x = new Random();
        oddi = x.Next(1, 15);
        oddj = x.Next(1, 15);

        for (i = 1; i < 15; i++)
        {
            for (j = 1; j < 15; j++)
            {

                mat[i, j] = (i == oddi && j == oddj) ? 'z' : 's';
                Console.Write(mat[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
    public void Nicula13methode2_2()
    {
        Console.Write("\nGeben sie die Zeile an (1-14): ");
        int zeile = int.Parse(Console.ReadLine());

        Console.Write("Geben Sie die Spalte an (1-14): ");
        int spalte = int.Parse(Console.ReadLine());


        if (zeile == oddi && spalte == oddj)
        {
            Console.WriteLine("Richtig!");

        }
        else
        {
            Console.WriteLine($"Falsch. Versuche noch ein Mal");
            Nicula13methode2_2();

        }

    }
}