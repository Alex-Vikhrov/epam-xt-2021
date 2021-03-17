using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2._1._Game_v2
{
    class Map
    {
        private int S;
        private int height = 500;
        private int width = 300;
        public void createMap()
        {
            int a = 500;
            int b = 300;
            S = a * b;
        }
        public void DisplayStatsMap()
        {
            Console.WriteLine("** Описание карты **");
            Console.WriteLine("Высота карты = {0}", height);
            Console.WriteLine("Ширина карты = {0}", width);
            Console.WriteLine("S карты = {0}", S);
            Console.WriteLine("Карта создана!");
        }
    }
}
