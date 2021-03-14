using System;

namespace _2._1._2._Custom_Paint
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            // меню ввода 
            do {
                Console.WriteLine("*** Custom Paint ***");
                Console.WriteLine("{0} Выберите действие:" + Environment.NewLine +
                "1. Добавить пользователя" + Environment.NewLine +
                "2. Добавить фигуру" + Environment.NewLine +
                "3. Вывести фигуры" + Environment.NewLine +
                "4. Очистить холст" + Environment.NewLine +
                "5. Выход");

                //Console.WriteLine("1. Добавить пользователя");
                //Console.WriteLine("2. Добавить фигуру");
                //Console.WriteLine("3. Вывести фигуры");
                //Console.WriteLine("4. Очистить холст");
                //Console.WriteLine("5. Выход");

                if (!Int32.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Будьте так любезны, введите число из списка пожалуйтса !");
                }

                switch (number)
                {
                    case 1:
                        /*string name = Console.ReadLine();*/// перенести в мейн
                        User app = new User(/*Console.ReadLine()*/);
                        app.DisplayStats();
                        break;
                    case 2:
                        Console.WriteLine("{0} Выберите тип фигуры:");
                        Console.WriteLine("1) Круг;");
                        Console.WriteLine("2) Кольцо;");
                        Console.WriteLine("3) Прямоугольник;");
                        Console.WriteLine("4) Квадрат.");

                        int num; /*= Int32.Parse(Console.ReadLine());*/
                        if (!Int32.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine("{0} Введите число из списка пожалуйтса !");
                        }

                        switch (num)
                        {
                            case 1:
                                Circle figure1 = new Circle();
                                figure1.CalcSCircle();
                                figure1.DisplayStatsCircle();
                                break;
                            case 2:
                                Ring figure2 = new Ring();
                                figure2.DisplayStatsCircle();
                                figure2.DisplayStatsRing();
                                break;
                            case 3:
                                Rectangle figure3 = new Rectangle();
                                figure3.getSRectangle();
                                figure3.DisplayStatsRectangle();
                                break;
                            case 4:
                                Square figure4 = new Square();
                                figure4.getSRectangle();
                                figure4.DisplayStatsSqare();
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("1. Круг;");
                        Console.WriteLine("2. Кольцо;");
                        Console.WriteLine("3. Прямоугольник;");
                        Console.WriteLine("4. Квадрат.");
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                }
              } while (number < 5);



            //User app = new User();
            //app.DisplayStats();

            //Rectangle figure1 = new Rectangle();
            //figure1.getSRectangle();
            //figure1.DisplayStatsRectangle();

            //Square figure2 = new Square();
            //figure2.getSRectangle();
            //figure2.DisplayStatsSqare();
        }
    }
}
