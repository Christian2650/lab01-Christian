using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double p, o, r;

        p = inputValue();
        r = Math.Sqrt(p * 3.14);
        o = 2 * 3.14 * r;
        Console.WriteLine(o);
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
