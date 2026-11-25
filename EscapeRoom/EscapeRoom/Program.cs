using EscapeRoom;

Console.WriteLine("Escape Room");

//Jeder Schüler schreibt nach dem Kommentar mit seiner Nummer den Aufruf seiner Klasse für das Lösen
//des Objektes im Escape Room.

int ct = 0;
int antw = 0;
bool[] geloest = new bool[28];
while (ct<8)
{
    Console.WriteLine("Klassennummereingabe (0-27):");
    antw=Int32.Parse(Console.ReadLine());
    if (antw >= 0 && antw < 28 && geloest[antw])
    {
        Console.WriteLine("Dieses Rätsel wurde bereits gelöst!");
        continue;
    }
    switch (antw)
    {
        case 0:
            //Beispiel
            /*Beispiel b = new Beispiel();
            b.BeispielMethode();
            ct++;*/
            geloest[0] = true;
            break;
        case 1:
            //1
            break;
        case 2:
            //2
            break;
        case 3:
            //3
            break;
        case 4:
            //4
            break;
        case 5:
            //5
            break;
        case 6:
            //6
            break;
        case 7:
            //7
            break;
        case 8:
            //8
            break;
        case 9:
            //9
            break;
        case 10:
            //10
            break;
        case 11:
            //11
            break;
        case 12:
            //12
            break;
        case 13:
            //13
            break;
        case 14:
            //14
            break;
        case 15:
            Orlea15 t = new Orlea15();
            t.HinweisAnzeigen();
            Console.WriteLine("Gib den Code ein:");
            int antwort = Convert.ToInt32(Console.ReadLine());
            Orlea15_2 f2= new Orlea15_2();
            if (t.CodePruefen(antwort))
            {
                ct++;
                geloest[15] = true;
            }
            else
            { 
                Orlea15 t1 = new Orlea15();
                f2.neuerHinweis();
                int antwort2 = Convert.ToInt32(Console.ReadLine());
                if (t.CodePruefen(antwort2))
                {
                    ct++;
                    geloest[15] = true;
                }
            }
            break;
        case 16:
            //16
            break;
        case 17:
            //17
            break;
        case 18:
            //18
            break;
        case 19:
            //19
            break;
        case 20:
            //20
            break;
        case 21:
            //21
            break;
        case 22:
            //22
            break;
        case 23:
            //23
            break;
        case 24:
            //24
            break;
        case 25:
            //25
            break;
        case 26:
            //26
            break;
        case 27:
            //27
            break;
        default:
            Console.WriteLine("Diese Klasse existiert nicht!");
            break;
        }
    }
Console.WriteLine("Herzlichen Glückwunsch!");
Console.WriteLine("Ihr habt den Escape Room geschafft!");