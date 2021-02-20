using System;

namespace _1._1._4._X_Mas_Tree
{
    class XMasTree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** XMasTree ***");
            getXMasTree();
        }

        static void getXMasTree()
        {
            Console.Write("Введите количество треугольников N:");
            string tekst = Console.ReadLine();
            int N = Convert.ToInt32(tekst);

            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k <= (N - j - 1); k++)
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
