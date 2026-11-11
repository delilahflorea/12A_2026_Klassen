using System;

public class Class1
{
    public Class1 (int a, int b)
    {
        int c = 0, d = 1;
        a = a - 2;
        while(a>0)
        {
            b = c + d;
            c = d;
            d = b;
            Write(b+ " ");
            a--;
        }
    }
}
