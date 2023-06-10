using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double m, n, k;

        Console.WriteLine("Podaj n oraz k - podane liczby muszą być nie mniejsze od 5");
        n = inputValue();
        k = inputValue();
        if (n < 5)
        {
            Console.WriteLine("Liczby n oraz k nie mogą być mniejsze od 5, prosimy o wprowadzenie poprawnych liczb");
        }
        if (k < 5)
        {
            Console.WriteLine("Liczby n oraz k nie mogą być mniejsze od 5, prosimy o wprowadzenie poprawnych liczb");
        }
        m = (n - k) / k;
        Console.WriteLine(m);
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

