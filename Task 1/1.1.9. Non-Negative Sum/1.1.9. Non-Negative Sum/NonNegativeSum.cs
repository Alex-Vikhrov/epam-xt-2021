using System;

namespace _1._1._9._Non_Negative_Sum
{
    class NonNegativeSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** NonNegativeSum ***");
            GetNonNegativeSum();
        }

        static void GetNonNegativeSum()
        {
            int[] mass = { 1, 2, 3, -4, -5, 10 };

            int sum = 0;
            for(int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    //mass[i] = 0;
                    //sum += mass[i];
                    Console.WriteLine($"Sum = {sum += mass[i]}");
                }
                //Console.WriteLine("sum = {0}", sum);
            }
        }
    }
}
