using System;
using System.Collections.Generic;

namespace _1._1._6._Font_Adjustment
{
    class FontAdjustment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Font Adjustment ***");
            getFontAdjustment();
        }

        static void getFontAdjustment()
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
    }
}
