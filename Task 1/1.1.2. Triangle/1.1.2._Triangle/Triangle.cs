using System;

namespace _1._1._2._Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Triangle ***");
            GetTriangle();
            Console.ReadLine();
        }

        static void GetTriangle()
        {
            Console.Write("Введите количество строк N:");
            int string_n = Int32.Parse(Console.ReadLine());

            for (int row_counter = 0; row_counter < string_n; row_counter++)
            {
                for (int star = 0; star <= row_counter; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

