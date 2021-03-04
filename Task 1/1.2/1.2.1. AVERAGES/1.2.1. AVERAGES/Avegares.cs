using System;
using System.Text;

namespace _1._2._1._AVERAGES
{
    class Avegares
    {
        static void Main(string[] args)
        {
            GetStrings();
            Console.WriteLine();
        }
        static void GetStrings()
        {
            Console.WriteLine(" Введите слово: ");
            string N = Console.ReadLine();
            StringBuilder word = new StringBuilder();
            int f = 0;

            for (int i = 0; i < N.Length; i++)
            {
                if (char.IsLetterOrDigit(N[i]))
                    f++;//счетчик записывающий все символы
                if (!char.IsPunctuation(N[i]))
                {
                    word.Append(N[i]);// входят только буквы и цифры
                }
            }
            int g = word.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries).Length; // массив из количеста слов
            Console.WriteLine(" Средняя длина вашего слова равна :" + (f / g));
        }
    }
}
