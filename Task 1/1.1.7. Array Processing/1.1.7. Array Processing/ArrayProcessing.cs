using System;

namespace _1._1._7._Array_Processing
{
    class ArrayProcessing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Array Processing ***");
            getArrayProcessing();
        }

        static void getArrayProcessing()
        {
            // Ввод чисел массива
            int x;
            Console.Write("Введите числа в массив :");
            x = int.Parse(Console.ReadLine());
            int[] numbers = new int[x];

            // Заполнение массива рандомными числами
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(100);
            }

            // Сортировка рандомного массива
            int sort;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        sort = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = sort;
                    }
                }
            }
            // Вывод отсортированного массива 
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Сравнение максимального и минимального элемента в массиве 
            int max = numbers[0]; 
            int min = numbers[0];

            foreach (int num in numbers)
            {
                if(max < num)
                {
                    max = num;
                }
                else if (min > num) 
                {
                    min = num;
                }
            }
            Console.WriteLine("Min:{0}", min);
            Console.WriteLine("Max:{0}", max);
        }
    }
}