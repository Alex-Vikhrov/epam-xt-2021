using System;

namespace _1._1._3._Another_Triangle
{
    class AnotherTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Another Triangle ***");
            GetAnotherTriangle();
            Console.ReadLine();
        }

        static void GetAnotherTriangle()
        {
            Console.Write("Введите количество строк N:");
            int string_N = Int32.Parse(Console.ReadLine());

            for (int row_counter = 0; row_counter < string_N; row_counter++)
            {
                for (int spase = string_N; spase > row_counter; spase--)
                {
                    Console.Write(" ");// 1) 1-треугольник из пробелов 
                }
                for (int star = 0; star < row_counter; star++)
                {
                    Console.Write("*");// 2) 2-треугольник добавляющий звездочки к 3 треугольнику
                }
                for (int triangle_star = 0; triangle_star <= row_counter; triangle_star++)
                {
                    Console.Write("*");// 3) 3-треугольник из 2 задания
                }
                Console.WriteLine();
            }

        }
    }
}
