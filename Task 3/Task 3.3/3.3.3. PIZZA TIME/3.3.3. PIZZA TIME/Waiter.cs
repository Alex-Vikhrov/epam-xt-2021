using System;
using System.Collections.Generic;
using System.Text;

namespace _3._3._3._PIZZA_TIME
{
    class Waiter: Personnel
    {
        public void ShowMessage()
        {
            Console.WriteLine("Hello my name is{0} today I am your waiter");
            Console.WriteLine("Choose a pizza from the menu");
        }

        public void GetOrderNumber()
        {
            Console.WriteLine("Please tell me your name:");

            int [] number = new int [1000];
            Random random = new Random ();

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(1000);
            }
            Console.WriteLine("{0} Your order number:{1}" /*myname*/, number);
        }
    }
}
