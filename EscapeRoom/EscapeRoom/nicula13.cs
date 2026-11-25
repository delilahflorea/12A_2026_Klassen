using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace EscapeRoom;

internal class nicula13
{
    char[,] mat = new char[15, 15];
    int i, j;
    int oddi=0;
    int oddj=0;


    public nicula13()
    {

    }

    
    public void nicula13methode()
    {

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
       nicula13methode2_2();
    }
    private void nicula13methode2_2()
    {
        Console.Write("\nGeben sie die Zeile an (1-15): ");
        int zeile = int.Parse(Console.ReadLine());

        Console.Write("Geben Sie die Spalte an (1-15): ");
        int spalte = int.Parse(Console.ReadLine());


        if (zeile == oddi && spalte == oddj)
        {
            Console.WriteLine("Richtig!");
        }
        else
        {
            Console.WriteLine($"Falsch. Die Antowrt war Reihe {oddi}, Spalte {oddj}.");

        }

    }
}