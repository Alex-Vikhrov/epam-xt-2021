using System;
using System.Collections.Generic;

namespace _1._1._6._Font_Adjustment
{
    class FontAdjustment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Font Adjustment ***");
            GetFontAdjustment();
        }

        static void GetFontAdjustment()
        {
            List<string> fonts = new List<string>();
            int numberFonts;
            do
            {
                Console.Write("Введите:" + Environment.NewLine +
                    "1: bold" + Environment.NewLine +
                    "2: italic" + Environment.NewLine +
                    "3: underline" + Environment.NewLine +
                    "4: cancel" + Environment.NewLine +
                    "5: exit");
                Console.WriteLine();
                // Проверка на число 
                if (!Int32.TryParse(Console.ReadLine(), out numberFonts))
                {
                    Console.WriteLine("Введите число!");
                    continue;
                }
                
                switch (numberFonts)
                {
                    case 1:
                        if (!fonts.Contains("Bold"))
                        {
                            fonts.Add("Bold");
                        }
                        else
                        {
                            fonts.Remove("Bold");
                        }
                        break;

                    case 2:
                        if (!fonts.Contains("Italic"))
                        {
                            fonts.Add("Italic");
                        }
                        else
                        {
                            fonts.Remove("Italic");
                        }
                        break;

                    case 3:
                        if (!fonts.Contains("Underline"))
                        {
                            fonts.Add("Underline");
                        }
                        else
                        {
                            fonts.Remove("Underline");
                        }       
                        break;
                    case 4:
                        if (!fonts.Contains("Параметры надписи:"))
                        {
                            fonts.Clear();
                        }
                        Console.WriteLine("Параметры надписи:");
                        break;

                    case 5:
                        return;
                }
                Console.WriteLine("Параметры надписи:" + string.Join(", ", fonts));
            } while (numberFonts < 5);
        }
    }
}
