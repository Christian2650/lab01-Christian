using System;
public class Test
{
    public static void Main()
    {
        int a, b, wynik = 1;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        while (b > 0)
        {
            wynik *= a;
            b--;
        }

        Console.WriteLine(wynik);
    }
}
