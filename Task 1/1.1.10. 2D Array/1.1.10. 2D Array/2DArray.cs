using System;

namespace _1._1._10._2D_Array
{
    class Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 2DArray ***");
            getSum2DArray();
        }

        static void getSum2DArray()
        {
            Console.WriteLine("Введите размерность массива:");
            Console.WriteLine("Введите размерность 1:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите размерность 2:");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            int sum = 0;
            int[,] mass = new int[a, b];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.WriteLine($"Введите числа массива по индексу [{i} {j}]");
                    mass[i,j] = Int32.Parse(Console.ReadLine()); //mass[i, j] = x++;
                    //if ((i + j) % 2 == 0)
                    //{
                    //    Console.WriteLine($"Sum = {sum += mass[i, j]}");
                    //}
                }
            }

            //int[,] mass = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //int[,] mass = new int[3, 2]; 

            //int x = 0;
            //int sum = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    //mass[i, j] = x++;
                    if ((i + j) % 2 == 0)
                    {
                        Console.WriteLine($"Sum = {sum += mass[i, j]}");
                    }
                }
            }
        }
    }
}
