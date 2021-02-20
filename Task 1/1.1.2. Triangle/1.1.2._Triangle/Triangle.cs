using System;

namespace _1._1._2._Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Triangle ***");
            getTriangle();
            Console.ReadLine();
        }

        static void getTriangle()
        {
            Console.Write("Введите количество строк N:");
            string tekst = Console.ReadLine();
            int N = Convert.ToInt32(tekst);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }
        }
    }
}

