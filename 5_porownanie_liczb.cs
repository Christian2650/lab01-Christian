﻿using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Podaj dwie liczby, ktore maja zostac porownane");
        a = inputValue();
        b = inputValue();
        if (a == b)
        {
            Console.WriteLine("Podane liczby są równe");
        }
        else
        {
            if (a > b)
            {
                Console.WriteLine("Poniższa liczba jest większa");
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Poniższa liczba jest większa");
                Console.WriteLine(b);
            }
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

