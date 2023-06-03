using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Proszę podać długość boków trójkąta");
        Console.WriteLine("Bok 1");
        a = inputValue();
        Console.WriteLine("Bok 2");
        b = inputValue();
        Console.WriteLine("Bok 3");
        c = inputValue();
        if (a == b)
        {
            if (a == c)
            {
                Console.WriteLine("Podane boki są równie, przez co utworzenie trójkąta równobocznego jest możliwe");
            }
            else
            {
                Console.WriteLine("Podane boki nie są równe, przez co utworzenie trójkąta równobocznego nie będzie możliwe");
            }
        }
        else
        {
            Console.WriteLine("Podane boki nie są równe, przez co utworzenie trójkąta równobocznego nie będzie możliwe");
        }
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

