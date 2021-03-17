using System;

namespace UsefulConsoleTool
{
    public class ConsoleHelper
    {
        public static int ReadIntValue()
        {
            do
            {
                string value = Console.ReadLine();

                if (Int32.TryParse(value, out int result))
                {
                    return result;
                }
            } while (true);
        }
    }
}
