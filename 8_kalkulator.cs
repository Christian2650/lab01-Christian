using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, t, w;

        Console.WriteLine("Prosimy o wybranie numer działania, które ma zostać wykonane (dodawanie - 1, odejmowanie - 2, mnożenie - 3 oraz dzielenie -4)");
        t = inputValue();
        Console.WriteLine("Prosimy o podanie liczb a oraz b, na których ma zostać wykonane powyższe działanie");
        a = inputValue();
        b = inputValue();
        if (t == 1)
        {
            w = a + b;
            Console.WriteLine("Wynik dodawania tych liczb to:");
            Console.WriteLine(w);
        }
        else
        {
            if (t == 2)
            {
                w = a - b;
                Console.WriteLine("Wynik odejmowania tych liczb to:");
                Console.WriteLine(w);
            }
            else
            {
                if (t == 3)
                {
                    w = a * b;
                    Console.WriteLine("Wynik mnożenia tych liczb to:");
                    Console.WriteLine(w);
                }
                else
                {
                    if (t == 4)
                    {
                        if (b == 0)
                        {
                            w = a;
                            Console.WriteLine("Wynik dzielenia tych dwóch liczb to:");
                            Console.Write(w);
                            Console.Write("/0");
                        }
                        else
                        {
                            w = a / b;
                            Console.WriteLine("Wynik dzielenie tych dwóch liczb to:");
                            Console.WriteLine(w);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wybrano niepoprawny numer działania");
                    }
                }
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

