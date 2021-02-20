using System;

namespace _1._1._1_Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Rectangle***");
            getSRectangle();
            Console.Write("Нажмите ENTER для перехода ко 2 версии программы");
            Console.ReadLine();
            getSRectangleVersia_2();
            Console.ReadLine();
        }
        static void getSRectangle()
        {
            Console.WriteLine("Введите сторону А:");
            string A = Console.ReadLine();
            int a = Convert.ToInt32(A);

            Console.WriteLine("Введите сторону B:");
            string B = Console.ReadLine();
            int b = Convert.ToInt32(B);

            if (a == b || a <= 0 || b <= 0)
            {
                Console.WriteLine("Вы ввели некорректное значение");
                return;
            }

            int S = a * b;
            Console.WriteLine($"S = {S}");
        }
        static void getSRectangleVersia_2()
        {
            Func<int, int, bool> isSquare = (a, b) => a == b;
            Func<int, bool> isInvalidSide = a => a < 0;

            Console.WriteLine("Введите сторону А:");
            string A = Console.ReadLine();
            int a = Convert.ToInt32(A);

            Console.WriteLine("Введите сторону B:");
            string B = Console.ReadLine();
            int b = Convert.ToInt32(B);

            if (isSquare(a, b))
            {
                Console.WriteLine("Вы ввели квадрат");
            } else if (isInvalidSide (a) || isInvalidSide(b))
            {
                Console.WriteLine("Вы ввели некорректное значение");
                return;
            }

            int S = a * b;
            Console.WriteLine($"S = {S}");
        }
    }
}
