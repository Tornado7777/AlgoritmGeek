//Требуется реализовать вычисление числа фибоначи через рекурсию.
//Пример чисел Фибоначчи:
//F(0) = 0,
//F(1) = 1.
//Для остальных чисел:
//F(N) = F(N - 2) + F(N - 1).
//То есть для F(2) будет F(2) = F(0) + F(1) = 0 + 1 = 1.
//F(3) будет F(3) = F(1) + F(2) = 1 + 1 = 2.

using System;

namespace quest1_3c
{
    class Program
    {
        static int Fibonachi(int N)
        {
            int fibonachiN = 0;


            for (int i = 1; i <= N; i++)
            {

                if (i == 1)
                {
                    fibonachiN = 1;

                }
                else
                {
                    fibonachiN = Fibonachi(N-1) + Fibonachi(N-2);
                }

            }

            return fibonachiN;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input fibonachi: ");
            bool success = int.TryParse(Console.ReadLine(), out int N);
            if (success & (N >= 0))
            {
                Console.WriteLine("Fibonache N = " + Fibonachi(N));
            }
            else
            {
                Console.WriteLine("Is not number or N < 0");
            }


        }
    }
}