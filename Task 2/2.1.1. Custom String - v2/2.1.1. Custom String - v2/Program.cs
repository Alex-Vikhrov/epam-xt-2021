using System;
using System.Text;
namespace _2._1._1._Custom_String___v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** My StringBuilder App ***");
            MyStringBuilder strings = new MyStringBuilder("привет");
            strings.Concatenate(" )");
            strings.PrintResult();
            strings.Comparison(new char[] {'п','р','и'});
            
        }
    }
}
