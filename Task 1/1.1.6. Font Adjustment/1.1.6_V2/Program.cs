using System;
using System.Collections.Generic;

namespace _1._1._6_V2
{
    class Program
    {
        public enum EmpType
        {
            bold = 1,
            italic,
            underline,
            cancel,
            exit
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*** Font Adjustment ***");
            GetFontAdjustment();
        }

        static void GetFontAdjustment()
        {
            List<string> fonts = new List<string>();
            do
            {
                Console.Write("Введите:" + Environment.NewLine +
                    "1: bold" + Environment.NewLine +
                    "2: italic" + Environment.NewLine +
                    "3: underline" + Environment.NewLine +
                    "4: cancel" + Environment.NewLine +
                    "5: exit");
                Console.WriteLine();

                EmpType emp = (EmpType)Int32.Parse(Console.ReadLine());
                switch (emp)
                {
                    case EmpType.bold:
                        if (!fonts.Contains("Bold"))
                        {
                            fonts.Add("Bold");
                        }
                        else
                        {
                            fonts.Remove("Bold");
                        }
                        break;

                    case EmpType.italic:
                        if (!fonts.Contains("Italic"))
                        {
                            fonts.Add("Italic");
                        }
                        else
                        {
                            fonts.Remove("Italic");
                        }
                        break;

                    case EmpType.underline:
                        if (!fonts.Contains("Underline"))
                        {
                            fonts.Add("Underline");
                        }
                        else
                        {
                            fonts.Remove("Underline");
                        }
                        break;
                    case EmpType.cancel:
                        if (!fonts.Contains("Параметры надписи:"))
                        {
                            fonts.Clear();
                        }
                        Console.WriteLine("Параметры надписи:");
                        break;

                    case EmpType.exit:
                        return;
                }
                Console.WriteLine("Параметры надписи:" + string.Join(", ", fonts));
            } while (true);
        }
    }
}
