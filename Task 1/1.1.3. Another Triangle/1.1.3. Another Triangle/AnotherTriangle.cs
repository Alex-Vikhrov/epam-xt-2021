using System;

namespace _1._1._3._Another_Triangle
{
    class AnotherTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Another Triangle ***");
            getAnotherTriangle();
            Console.Write("Нажмите ENTER для перехода ко 2 версии программы");
            Console.ReadLine();
            Console.WriteLine("*** XMasTree ***");
            getXMasTree();
            Console.ReadLine();
        }

        static void getAnotherTriangle()
        {
            Console.Write("Введите количество строк N:");
            string tekst = Console.ReadLine();
            int N = Convert.ToInt32(tekst);

            for (int i = 0; i < N; i++)
            {
                for (int k = N; k > i; k--)
                {
                    Console.Write(" ");// 1) 1-треугольник из пробелов 
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");// 2) 2-треугольник добавляющий звездочки к 3 треугольнику
                }
                for (int f = 0; f <= i; f++)
                {
                    Console.Write("*");// 3) 3-треугольник из 2 задания
                }
                Console.WriteLine();
            }

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
