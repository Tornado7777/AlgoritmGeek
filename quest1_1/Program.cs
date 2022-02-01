using System;

namespace quest1_1
{
    class Program
    {
        static bool SimpleNumber(int number)
        {
            int d = 0;
            bool simple = false;
            for (int i = 2; i < number; i++)
            {
                if (i < number)
                {
                    if (number % i == 0) d++;
                }
            }
            if (d == 0) simple = true;
            return simple;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input number: ");
            n = Int32.Parse(Console.ReadLine());
            SimpleNumber(n);
        }
    }
}
