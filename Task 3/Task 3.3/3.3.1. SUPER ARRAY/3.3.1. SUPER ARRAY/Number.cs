using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _3._3._1._SUPER_ARRAY
{
    class Number
    {
        public Number(int[] array)
        {
            this.Array = array;
        }

        public int[] Array { get; }

        public int CalcSum(Func<int, int> selector)
        {
            return Array.Sum(selector);
            //int sum = 0;
            //foreach (var item in Array)
            //{
            //    sum += selector(item);
            //}
            //return sum;
        }

        public int CalcAverageValue(Func<int, int> value)
        {
            return Array.Sum(value) / Array.Length;
        }

        public void GetFrequencyValue()
        {

        }
    }
}
