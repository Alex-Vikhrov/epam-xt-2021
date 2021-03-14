using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1._2._Custom_Paint
{
    class Rectangle
    {
        public int S;
        public void getSRectangle()
        {
            Console.WriteLine("Введите параметры фигуры прямоугольник:");
                Console.WriteLine("Введите сторону А:");
                if (!Int32.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("A не может быть равно B! Введите сторону А!");
                }

                Console.WriteLine("Введите сторону B:"); 
                if (!Int32.TryParse(Console.ReadLine(), out int b))
                {
                    Console.WriteLine("Введите сторону B!");
                }

            if (/*a == b ||*/ a <= 0 || b <= 0)
            {
                Console.WriteLine("Вы ввели некорректное значение");
                return;
            }

            S = a * b;
        }
        public void DisplayStatsRectangle()
        {
            Console.WriteLine("S прямоугольника = {0}", S);
            Console.WriteLine("Фигура создана!");
        }
        //public void DisplayStatsSqare()
        //{
        //    Console.WriteLine("S квадрата = {0}", S);
        //}
    }
}
