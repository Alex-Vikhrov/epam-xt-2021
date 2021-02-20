using System;

namespace _1._1._3._Another_Triangle_Versia__2
{
    class AnotherTriangleVersia2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Another Triangle V2 ***");
            getAnotherTriangleV2();
            Console.ReadLine();
        }

        static void getAnotherTriangleV2()
        {
            Console.Write("Введите количество строк N:");
            string tekst = Console.ReadLine();
            int N = Convert.ToInt32(tekst);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= (N - i - 1); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (i * 2 + 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
