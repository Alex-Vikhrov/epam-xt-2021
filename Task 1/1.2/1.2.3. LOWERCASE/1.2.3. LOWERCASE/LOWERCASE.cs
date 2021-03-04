using System;
using System.Text;

namespace _1._2._3._LOWERCASE
{
    class LOWERCASE
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** LOWERCASE ***");
            calcLowercase();
        }

        static void calcLowercase()
        {
            Console.WriteLine(" Введите предложение: ");
            string text = Console.ReadLine();
            int g = 0;
            char [] symbol = new char[] { ' ', ',', '.' };
            string [] words = text.Split(symbol, StringSplitOptions.RemoveEmptyEntries);// words Записывает слова

            for (int i = 0; i < words.Length; i++)
            {
                char firstChar = words[i][0]; // Смотрит первый символ
                if (char.IsLower(firstChar))
                {
                    g++;
                }
            }
            Console.WriteLine("Слова написанные с маленькой буквы: " + (g));
        }
    }
}









//if (char.IsLetterOrDigit(text[i]))
//    f++;
//if (!char.IsPunctuation(text[i]) && char.IsLower(text[i]))
//{
//    word.Append(text[i]);
//}
////if (char.IsUpper(text[i]))// проверку на верхний регистр 
////{
////    word.Remove(text)
////}