using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, d;

        Console.WriteLine("Podaj a");
        a = inputValue();
        Console.WriteLine("Podaj b");
        b = inputValue();
        Console.WriteLine("Podaj c");
        c = inputValue();
        Console.WriteLine("Podaj d");
        d = inputValue();
        if (b == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        if (d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        double x, y;

        while (b != d)
        {
            if (b > d)
            {
                b = b - d;
            }
            else
            {
                d = d - b;
            }
        }
        x = a + c;
        y = b;
        Console.WriteLine("Licznik to");
        Console.WriteLine(x);
        Console.WriteLine("Mianownik to");
        Console.WriteLine(y);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

