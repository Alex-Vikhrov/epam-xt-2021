using System;

namespace _1._1._4._X_Mas_Tree
{
    class XMasTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** XMasTree ***");
            GetXMasTree();
        }

        static void GetXMasTree()
        {
            Console.Write("Введите количество треугольников N:");
            int string_N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= string_N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k <= (string_N - j - 1); k++)
                    {
                        Console.Write(" ");
                    }
                    for (int f = 0; f < (j * 2 + 1); f++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
