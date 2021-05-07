using System;
using System.Linq;
using System.IO;

namespace _3._1._2._TEXT_ANALYSIS_VERSIA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetText();
            CalcLowercase();
        }

        static string GetText()
        {
            var path = @"G:\text.txt";

            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(fileStream);

            var text2 = streamReader.ReadToEnd();

            return text2;
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
            var text2 = GetText();
            char[] symbols2 = new char[] { ' ', ',', '.', '?', '!', ':', ';', '№', '@', '-', '_' };
            string[] words2 = text2.Split(symbols2, StringSplitOptions.RemoveEmptyEntries);

            var result2 = words2.GroupBy(w => w)
                              .Where(w => w.Count() > 1)
                              .Select(w => new { Word = w.Key, Frequency = w.Count() });

            foreach (var item in result2)
            {
                Console.WriteLine("Слова повторяющиеся в статье: {0}", item.Word);
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Слово: {0}" + Environment.NewLine +
                    "2. Повторяется: {1}", item.Word, item.Frequency);
                Console.WriteLine("--------------------------------");
            }

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
                    "2. Повторяется: {1}", item.Word, item.Frequency);
                Console.WriteLine("--------------------------------");
            }

            Console.Write("Нажмите клавишу enter, чтобы ознакомиться с рекомендацией.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("С учетом полученных данных решите, от как слов по возможности стоит избавиться или пытаться использовать не так часто.");
            Console.ReadLine();
        }
    }
}
