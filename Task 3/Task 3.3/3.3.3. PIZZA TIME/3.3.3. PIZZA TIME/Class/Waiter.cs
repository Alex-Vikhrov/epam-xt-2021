using System;

namespace _3._3._3._PIZZA_TIME
{
    public class Waiter: Personnel, ICanWorkWithMenu
    {
        public Waiter(string firstName, string lastName, int age): base(firstName, lastName, age)
        {

        }
        public override void ShowMessage()
        {
            Console.WriteLine($"Hello my name is {this.FirstName} {this.LastName}, {this.Age} today I am your waiter");
            Console.WriteLine("Choose a pizza from the menu");
        }

        public void GetOrderNumber()
        {
            Console.WriteLine("Please tell me your name:");
            string myName = Console.ReadLine();

            int [] number = new int [1000];
            Random random = new Random ();

            int num = 0;

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(1000);
                num = number[i];
            }
            Console.WriteLine("{0} Your order number:{1}", myName, num);
        }

        public void SuggestMenu()
        {
            Menu menu = new Menu();
            menu.AddPizza();
            GetOrderNumber();
            Console.ReadLine();
        }
    }
}
