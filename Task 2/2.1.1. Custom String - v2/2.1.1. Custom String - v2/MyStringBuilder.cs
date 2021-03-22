using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1._1._Custom_String___v2
{
    class MyStringBuilder
    {
        public char[] symbol;

        // Метод конкатенации символов: используем конструктор
        public MyStringBuilder(string value)
        {
            this.symbol = value.ToCharArray();
        }
        public void Concatenate(string text) 
        {
            char[] temp = new char[symbol.Length + text.Length];

            for (int i = 0; i < symbol.Length; i++)
            {
                temp[i] = symbol[i];
            }
            int index = 0;
            for (int y = symbol.Length; y < temp.Length; y++)
            {
                temp[y] = text[index];
                index++;
            }
            symbol = temp;
        }
        // Метод сравнения символов
        public bool Comparison(char [] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                if (symbol[i] != result [i])
                {
                    return false;
                }  
            }
            return true;
        }
        // Метод поиска символов 
        public void SearchChar(char txt)
        {
            for (int i = 0; i < symbol.Length; i++)
            {
                if (symbol[i] == txt)
                    Console.WriteLine(i);
            }
        }
        // Метод конвертации из/в массив символов
        public void ConversionChar()
        {

        }

        public void PrintResult()
        {
            foreach(char a in symbol)
            {
                Console.WriteLine(a);
            }
        }
    }
}
