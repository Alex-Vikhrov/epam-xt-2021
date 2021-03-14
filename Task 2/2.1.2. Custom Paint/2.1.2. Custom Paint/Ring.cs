using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1._2._Custom_Paint
{
    class Ring: Circle
    {
        public void DisplayStatsRing()
        {
            Console.WriteLine("S круга = {0}", S);
            Console.WriteLine("P круга = {0}", P);
            Console.WriteLine("Фигура создана!");
        }
    }
}
