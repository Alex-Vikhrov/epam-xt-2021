using System;
using System.Text;

namespace _1._2._2._DOUBLER
{
    class Doubler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Doubler ***");
            getDoubler();
        }

        static void getDoubler()
        {
            Console.WriteLine("ВВОД 1:");
            string originalText = "написать программу, которая";
            Console.WriteLine(originalText);

            Console.WriteLine("ВВОД 2:");
            string word = "описание";
            Console.WriteLine(word);

            Console.WriteLine("ВЫВОД:");
            var doubler = new StringBuilder(); 

            for (int i = 0; i < originalText.Length; i++)
            {
                doubler.Append(originalText[i]);
                if (word.Contains(originalText[i]))
                {
                    doubler.Append(originalText[i]);
                }
            }
            Console.WriteLine(doubler);
            Console.ReadLine();
        }
    }
}
