using System;
using System.Text.RegularExpressions;

namespace _3._3._2._SUPER_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLanguage();
        }

        static string InputText()
        {
            Console.WriteLine("Please enter the text:");
            string text = Console.ReadLine();
            return text;
        }

        static void GetLanguage()
        {
            string txt = InputText();

            Regex english = new Regex("[A-Za-z]");
            Regex russian = new Regex("[А-Яа-яё]");
            Regex number = new Regex("[0-9]");
            Regex mixed = new Regex("[0-9A-Za-zА-яа-яё]");

            MatchCollection eng = english.Matches(txt);
            MatchCollection rus = russian.Matches(txt);
            MatchCollection num = number.Matches(txt);
            MatchCollection mix = mixed.Matches(txt);

            if(eng.Count == txt.Length)
            {
                Console.WriteLine("English");
            }

            if(rus.Count == txt.Length)
            {
                Console.WriteLine("Russian");
            }

            if (num.Count == txt.Length)
            {
                Console.WriteLine("Number");
            }

            if (mix.Count == txt.Length)
            {
                Console.WriteLine("Mixed");
            }
        }
    }
}
