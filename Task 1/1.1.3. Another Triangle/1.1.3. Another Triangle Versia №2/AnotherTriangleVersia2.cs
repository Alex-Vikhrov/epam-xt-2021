using System;

namespace _1._1._3._Another_Triangle_Versia__2
{
    class AnotherTriangleVersia2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Another Triangle V2 ***");
            GetAnotherTriangleV2();
            Console.ReadLine();
        }

        static void GetAnotherTriangleV2()
        {
            Console.Write("Введите количество строк N:");
            int string_N = Int32.Parse(Console.ReadLine());

            for (int row_counter = 0; row_counter < string_N; row_counter++)
            {
                for (int space = 0; space <= (string_N - row_counter - 1); space++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < (row_counter * 2 + 1); star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
