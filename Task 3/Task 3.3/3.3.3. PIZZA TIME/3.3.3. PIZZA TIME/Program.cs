using System;

namespace _3._3._3._PIZZA_TIME
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonnelCollection person = new PersonnelCollection();
            //person.UsePersonnelCollection();
            Waiter personnel = new Waiter("Olga", "Nesterova", 24);
            personnel.ShowMessage();
            Console.WriteLine("----------------------------");
            person.UUsePersonnelCollection();
            
        }
    }
}
