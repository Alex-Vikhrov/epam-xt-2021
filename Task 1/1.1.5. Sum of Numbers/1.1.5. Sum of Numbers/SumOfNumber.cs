using System;

namespace _1._1._5._Sum_of_Numbers
{
    class SumOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Number ***");
            getSumOfNumber();
        }

        static void getSumOfNumber() 
        {
            int a = 0;
            int b = 0;
            int sum = 0;

            for (int i = 1; i < 1000; i++) // цикл отвечает за : перебор чисел до 1000
            {
                if (i % 3 == 0)
                {
                    a = i;
                }
                else if (i % 5 == 0)
                {
                    b = i;
                }

                sum += a + b;
                a = 0;
                b = 0;
                Console.WriteLine($"sum = {sum += a + b}");
            }
            Console.WriteLine(sum);
        }
    }
}
