using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double w, h;

        Console.WriteLine("Prosze podac wage w kg oraz wzrost w m");
        w = inputValue();
        h = inputValue();
        double bMI;

        bMI = w / Math.Pow(h, 2);
        Console.WriteLine("Body Mass Index =");
        Console.WriteLine(bMI);
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

