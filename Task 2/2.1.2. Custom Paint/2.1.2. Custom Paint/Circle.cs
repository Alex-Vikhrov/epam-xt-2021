using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1._2._Custom_Paint
{
    class Circle
    {
        const int pi = 3;
        public int S;
        public int P;
        public void CalcSCircle()
        {
            Console.WriteLine("Введите параметры фигуры круг:");
            
            Console.WriteLine("Введите координату х0:");
            int x0 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату у0:");
            int y0 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Центр круга имеет координаты A({0},{1})", x0, y0);

            Console.WriteLine("Введите радиус круга R:");
            int R = Int32.Parse(Console.ReadLine());

            S = pi * R;
            P = 2 * pi * R;
        }
        public void DisplayStatsCircle()
        {
            Console.WriteLine("S круга = {0}", S);
            Console.WriteLine("P круга = {0}", P);
            Console.WriteLine("Фигура создана!");
        }


        /* задать центр круга;
         * радиус;
         * и 2 свойства площадь круга и длину окружности */
    }
}
