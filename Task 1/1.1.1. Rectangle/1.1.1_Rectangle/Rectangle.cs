using System;

namespace _1._1._1_Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Rectangle***");
            GetSRectangle();
            Console.Write("Нажмите ENTER для перехода ко 2 версии программы");
            Console.ReadLine();
            GetSRectangleVersia_2();
            Console.ReadLine();
        }
        static void GetSRectangle()
        {

            Console.WriteLine("Введите сторону А:");
            bool value_a = Int32.TryParse(Console.ReadLine(), out int side_a);
            if (value_a)
                Console.WriteLine("Сторона А = {0}", side_a);

            Console.WriteLine("Введите сторону B:");
            bool value_b = Int32.TryParse(Console.ReadLine(), out int side_b);
            if (value_b)
                Console.WriteLine("Сторона B = {0}", side_b);

            if (side_a == side_b || side_a <= 0 || side_b <= 0)
            {
                Console.WriteLine("Вы ввели некорректное значение, сторона A = {0} и B = {1}, не может иметь отрицательного значения или <null>," + Environment.NewLine + 
                "или строкового значения.", side_a, side_b);
                return;
            }

            int area = side_a * side_b;
            Console.WriteLine($"S = {area}");
        }
        static void GetSRectangleVersia_2()
        {
            Func<int, int, bool> isSquare = (a, b) => a == b;
            Func<int, bool> isInvalidSide = a => a < 0;

            Console.WriteLine("Введите сторону А:");
            int side_a = Int32.Parse(Console.ReadLine()); 

            Console.WriteLine("Введите сторону B:");
            int side_b = Int32.Parse(Console.ReadLine());

            if (isSquare(side_a, side_b))
            {
                Console.WriteLine("Вы ввели квадрат");
            } else if (isInvalidSide (side_a) || isInvalidSide(side_b))
            {
                Console.WriteLine("Вы ввели некорректное значение");
                return;
            }

            int area = side_a * side_b;
            Console.WriteLine($"S = {area}");
        }
    }
}
