using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double kwota, oprocentowanie, liczbaMiesiecy, zarobek1, zarobek2, zarobekCalkowity;

        Console.WriteLine("Podaj kwotę początkową, która wpłacisz na konto oszczędnościowe");
        kwota = inputValue();
        Console.WriteLine("Oprocentowanie konta w skali roku");
        oprocentowanie = inputValue();
        Console.WriteLine("Liczba miesiecy oszczedzania");
        liczbaMiesiecy = inputValue();
        zarobek1 = kwota * (oprocentowanie * liczbaMiesiecy / 12);
        zarobekCalkowity = zarobek1 * 0.81;
        Console.WriteLine("Zarobek calkowity wynosi:");
        Console.WriteLine(zarobekCalkowity);
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

