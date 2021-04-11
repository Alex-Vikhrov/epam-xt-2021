using System;
using System.Linq;

namespace _3._1._2._TEXT_ANALYSIS
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcLowercase();
        }

        static string InputText()
        {
            Console.WriteLine("Введите текст статьи:");
            string text = Console.ReadLine();
            Console.Clear();
            return text;
        }

        static void CalcLowercase()
        {
            string text = InputText();
            char[] symbols = new char[] { ' ', ',', '.', '?', '!', ':', ';', '№', '@', '-', '_' };
            string[] words = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            var result = words.GroupBy(w => w)
                              .Where(w => w.Count() > 1)
                              .Select(w => new { Word = w.Key, Frequency = w.Count() });

            foreach (var item in result)
            {
                Console.WriteLine("Слова повторяющиеся в статье: {0}", item.Word);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Слово: {0}" + Environment.NewLine + 
                    "2. Повторяется: {1}",item.Word, item.Frequency);
                Console.WriteLine("--------------------------------");
            }
            Console.Write("Нажмите любую клавишу, чтобы ознакомиться с рекомендацией.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("С учетом полученных данных решите, от как слов по возможности стоит избавиться или пытаться использовать не так часто.");
            Console.ReadLine();
        }
    }
}