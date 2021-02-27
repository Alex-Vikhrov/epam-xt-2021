using System;
using System.Collections.Generic;

namespace _1._1._1___1._1._10
{
    class Task_1
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("*** THE MAGNIFICENT TEN ***");
                Console.WriteLine("Введите номер задания:");
                Console.WriteLine("1: RECTANGLE");
                Console.WriteLine("2: TRIANGLE");
                Console.WriteLine("3: ANOTHER TRIANGLE");
                Console.WriteLine("4: X-MAS TREE");
                Console.WriteLine("5: SUM OF NUMBERS");
                Console.WriteLine("6: FONT ADJUSTMENT");
                Console.WriteLine("7: ARRAY PROCESSING");
                Console.WriteLine("8: NO POSITIVE");
                Console.WriteLine("9: NON-NEGATIVE SUM");
                Console.WriteLine("10: 2D ARRAY");
                Console.WriteLine("11: EXIT");
                n = Int32.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("***Rectangle***");
                        getSRectangle();
                        Console.Write("Нажмите ENTER для перехода ко 2 версии программы");
                        Console.ReadLine();
                        getSRectangleVersia_2();
                        break;

                    case 2:
                        Console.WriteLine("*** Triangle ***");
                        getTriangle();
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("*** Another Triangle ***");
                        getAnotherTriangle();
                        Console.Write("Нажмите ENTER для перехода ко 2 версии программы");
                        Console.ReadLine();
                        Console.WriteLine("*** Another Triangle V2 ***");
                        getAnotherTriangleV2();
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("*** XMasTree ***");
                        getXMasTree();
                        break;
                    case 5:
                        Console.WriteLine("*** Number ***");
                        getSumOfNumber();
                        break;
                    case 6:
                        Console.WriteLine("*** Font Adjustment ***");
                        getFontAdjustment();
                        break;
                    case 7:
                        Console.WriteLine("*** Array Processing ***");
                        getArrayProcessing();
                        break;
                    case 8:
                        Console.WriteLine("*** No Positive ***");
                        getNoPositive();
                        break;
                    case 9:
                        Console.WriteLine("*** NonNegativeSum ***");
                        getNonNegativeSum();
                        break;
                    case 10:
                        Console.WriteLine("*** 2DArray ***");
                        getSum2DArray();
                        break;

                    case 11:
                        break;
                }
            } while (n < 11);


            static void getSRectangle() //1.1.1
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
            static void getSRectangleVersia_2() //1.1.1 V2
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
                }
                else if (isInvalidSide(a) || isInvalidSide(b))
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                    return;
                }

                int S = a * b;
                Console.WriteLine($"S = {S}");
            }

            static void getTriangle() //1.1.2 
            {
                Console.Write("Введите количество строк N:");
                string tekst = Console.ReadLine();
                int N = Convert.ToInt32(tekst);

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }
            }

            static void getAnotherTriangle() //1.1.3
            {
                Console.Write("Введите количество строк N:");
                string tekst = Console.ReadLine();
                int N = Convert.ToInt32(tekst);

                for (int i = 0; i < N; i++)
                {
                    for (int k = N; k > i; k--)
                    {
                        Console.Write(" ");// 1) 1-треугольник из пробелов 
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");// 2) 2-треугольник добавляющий звездочки к 3 треугольнику
                    }
                    for (int f = 0; f <= i; f++)
                    {
                        Console.Write("*");// 3) 3-треугольник из 2 задания
                    }
                    Console.WriteLine();
                }
            }

            static void getAnotherTriangleV2() //1.1.3 V2
            {
                Console.Write("Введите количество строк N:");
                string tekst = Console.ReadLine();
                int N = Convert.ToInt32(tekst);

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j <= (N - i - 1); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < (i * 2 + 1); k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            static void getXMasTree() //1.1.4
            {
                Console.Write("Введите количество треугольников N:");
                string tekst = Console.ReadLine();
                int N = Convert.ToInt32(tekst);

                for (int i = 0; i <= N; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        for (int k = 0; k <= (N - j - 1); k++)
                        {
                            Console.Write(" ");
                        }
                        for (int f = 0; f < (j * 2 + 1); f++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }

            static void getSumOfNumber() //1.1.5
            {
                int a = 0;
                int b = 0;
                int sum = 0;

                for (int i = 0; i < 1000; i++) // цикл отвечает за : перебор чисел до 1000
                {
                    if (i % 3 == 0)
                    {
                        a = i;
                    }
                    else if (i % 5 == 0)
                    {
                        b = i;
                    }

                    sum += a + b;
                    a = 0;
                    b = 0;
                    Console.WriteLine($"sum = {sum += a + b}");
                }
                Console.WriteLine(sum);
            }

            static void getFontAdjustment() //1.1.6
            {
                List<string> Font = new List<string>();
                int numberFont;
                do
                {
                    Console.Write("Введите:" + "\n" +
                        "1: bold" + "\n" +
                        "2: italic" + "\n" +
                        "3: underline" + "\n" +
                        "4: cancel" + "\n" +
                        "5: exit");
                    Console.WriteLine();
                    // Проверка на число 
                    if (!Int32.TryParse(Console.ReadLine(), out numberFont))
                    {
                        Console.WriteLine("Введите число!");
                    }

                    switch (numberFont)
                    {
                        case 1:
                            if (!Font.Contains("Bold"))
                            {
                                Font.Add("Bold");
                            }
                            else
                            {
                                Font.Remove("Bold");
                            }
                            Console.WriteLine("Параметры надписи:" + string.Join(", ", Font));
                            break;

                        case 2:
                            if (!Font.Contains("Italic"))
                            {
                                Font.Add("Italic");
                            }
                            else
                            {
                                Font.Remove("Italic");
                            }
                            Console.WriteLine("Параметры надписи:" + string.Join(", ", Font));
                            break;

                        case 3:
                            if (!Font.Contains("Underline"))
                            {
                                Font.Add("Underline");
                            }
                            else
                            {
                                Font.Remove("Underline");
                            }
                            Console.WriteLine("Параметры надписи:" + string.Join(", ", Font));
                            break;
                        // кейс 4 - не могу понять почему он не удаляет их всех 
                        case 4:
                            if (!Font.Contains("Параметры надписи:"))
                            {
                                Font.Remove("Bold");
                                Font.Remove("Underline");
                                Font.Remove("Underline");
                            }
                            Console.WriteLine("Параметры надписи:");
                            break;

                        case 5:
                            break;
                    }
                } while (numberFont < 5);
            }

            static void getArrayProcessing() //1.1.7
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
                    if (max < num)
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

            static void getNoPositive() //1.1.8
            {
                int[,,] mas = { { { 1, 2, -3, 4 } }, { { 5, -6, -10, 11 } }, { { 2, 3, 4, -5 } } };
                /*int[,,] mas = { { { -1, 0 }, { -3, 4 } },
                                { { -4, 5 }, { -6, 7 } },
                                { { -7, 8 }, { -9, 2 } },
                                { { -7, 9 }, { -1, 1 } } };*/


                int rows = mas.GetUpperBound(0) + 1;
                int columns1 = mas.GetUpperBound(1) + 1;
                int columns2 = mas.GetUpperBound(2) + 1;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns1; j++)
                    {
                        for (int a = 0; a < columns2; a++)
                        {
                            if (mas[i, j, a] >= 0)
                            {
                                mas[i, j, a] = 0;
                            }
                            Console.Write($"{mas[i, j, a]} \t");
                        }
                    }
                    Console.WriteLine();
                }
            }

            static void getNonNegativeSum() //1.1.9
            {
                int[] mass = { 1, 2, 3, -4, -5, 10 };

                int Sum = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] < 0)
                    {
                        mass[i] = 0;
                    }

                    Console.WriteLine($"Sum = {Sum += mass[i]}");
                }
            }

            static void getSum2DArray() //1.1.10
            {
                //Console.WriteLine("Введите размерность массива:");
                //Console.WriteLine("Введите размерность 1:");
                //int a = Int32.Parse(Console.ReadLine());
                //Console.WriteLine("Введите размерность 2:");
                //int b = Int32.Parse(Console.ReadLine());
                //Console.WriteLine();

                int[,] mass = new int[3, 2];

                int x = 0;
                int sum = 0;
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    for (int j = 0; j < mass.GetLength(1); j++)
                    {
                        mass[i, j] = x++;
                        if ((i + j) % 2 == 0)
                        {
                            Console.WriteLine($"Sum = {sum += mass[i, j]}");
                        }
                    }
                }
            }
        }
    }
}
