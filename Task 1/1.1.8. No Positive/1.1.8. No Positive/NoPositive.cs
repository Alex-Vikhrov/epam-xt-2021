using System;

namespace _1._1._8._No_Positive
{
    class NoPositive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** No Positive ***");
            getNoPositive();
        }

        static void getNoPositive()
        {
            int[,,] mas = { { { 1, 2, -3, 4 } }, { { 5, -6, -10, 11 } }, { { 2, 3, 4, 5 } } };
            /*int[,,] mas = { { { -1, 0 }, { -3, 4 } },
                            { { -4, 5 }, { -6, 7 } },
                            { { -7, 8 }, { -9, 2 } },
                            { { -7, 9 }, { -1, 1 } } };*/
                                                         

            int rows = mas.GetUpperBound(0) + 1;
            int columns1 = mas.GetUpperBound(1) + 1;
            int columns2 = mas.GetUpperBound(2) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns1; j++)
                {
                    for (int a =0; a < columns2; a++)
                    {
                        if (mas[i, j, a] >= 0)
                        {
                            mas[i, j, a] = 0;
                        }
                        Console.Write($"{mas[i, j, a]} \t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
