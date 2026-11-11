Console.WriteLine("Im folgenden Program mussen Sie raten, wie viele Damen auf einer n*n Schachtafel gleichzeitig sitzen konnen, ohne sich einander anzugreifen");
Console.WriteLine("geben Sie die Grose des Schachtafels ein (n):");

int n = int.Parse(Console.ReadLine());

bool getroffen = false;
while (!getroffen)
{
    Console.WriteLine("");
    Console.WriteLine("Geben Sie die Schatzung ein:");
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
