using System;
using System.Collections.Generic;

namespace _3._1._1._WEAKEST_LINK
{
    class Program
    {
        static void Main(string[] args)
        {
            CirleCalcPepole();
        }

        static int InputPepolN()
        {

            Console.WriteLine("ВЫВОД: Введите количество людей - N стоящих в кругу.");

            bool value = Int32.TryParse(Console.ReadLine(), out int pepole_N);

            while (!value || pepole_N < 2)
            {
                Console.WriteLine("Вы ввели некоректное значение, введите число, в кругу должно быть минимум 2 человека! ");
                value = Int32.TryParse(Console.ReadLine(), out pepole_N);
            }

            Console.WriteLine("ВВОД: {0}", pepole_N);
            return pepole_N;
        }

        static void CirleCalcPepole()
        {
            Queue<int> pepoleQ = new Queue<int>();

            int pepole = InputPepolN();
            Console.WriteLine("ВЫВОД: Сгенерирован круг людей. Начинаем вычеркивать каждого второго.");

            for (int i = 1; i <= pepole; i++)
            {
                pepoleQ.Enqueue(i);
            }

            int round = 1;

            while (pepoleQ.Count != 1)
            {
                pepoleQ.Enqueue(pepoleQ.Dequeue());
                pepoleQ.Dequeue();
                Console.WriteLine($"ВЫВОД: Раунд {round++}.Вычеркнут человек.Людей осталось:{pepoleQ.Count}");
            }
            Console.WriteLine("ВЫВОД: Игра окончена.Невозможно вычеркнуть больше людей.");
        }
    }
}













#region List

//        //Console.WriteLine("ВЫВОД: Введите количество людей стоящих в кругу");

//        //bool value = Int32.TryParse(Console.ReadLine(), out int pepol_n);

//        //while (!value || pepol_n <= 2 )
//        //{
//        //    Console.WriteLine("Вы ввели некоректное значение, введите число людей в круге, в кругу должно быть минимум 2 человека! ");
//        //    value = Int32.TryParse(Console.ReadLine(), out pepol_n);
//        //}

//        //Console.WriteLine("ВВОД: {0}", pepol_n);
//        //}

//        //static void CirleCalcPepole()
//        //{
//        //    List<int> people = new List<int>();
//        //    Console.WriteLine("ВЫВОД: Введите количество людей стоящих в кругу");
//        //    int n = PepolN();


//        //}
//    }
//}
#endregion