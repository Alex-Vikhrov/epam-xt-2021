using System;

namespace _3._3._1._SUPER_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(new int[] { 1, 2, 3, 4 });
            number.CalcSum(n => n + 1);
        }
    }
}
