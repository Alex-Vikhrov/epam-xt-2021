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
