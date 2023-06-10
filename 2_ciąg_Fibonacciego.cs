using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int n = 0; true; n++)
            {
                c = a + b;

                a = b;
                b = c;

                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
