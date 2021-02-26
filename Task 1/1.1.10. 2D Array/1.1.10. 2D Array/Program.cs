using System;

namespace _1._1._10._2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[a] + [b] % 2");
            getSum2DArray();
        }

        static void getSum2DArray()
        {
            //Console.WriteLine("Введите размерность массива:");
            //int a = Int32.Parse(Console.ReadLine());
            //int b = Int32.Parse(Console.ReadLine());
            //Console.WriteLine();

            int[,] mass = new int[5, 5];
            Random r = new Random();

            int sum = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.WriteLine($"Sum = {sum += mass[i, j]}");
                    }
                }
            }

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = r.Next(-20, 20);
                }
                Console.WriteLine();
            }
            
        }
    }
}
