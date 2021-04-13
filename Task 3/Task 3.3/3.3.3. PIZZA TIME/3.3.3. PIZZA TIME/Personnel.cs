using System;
using System.Collections.Generic;
using System.Text;

namespace _3._3._3._PIZZA_TIME
{
    public class Personnel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Personnel(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual void ShowMessage()
        {
            Console.WriteLine($"Hello my name is {this.FirstName} {this.LastName}, {this.Age} today I am your personnel");
        }
        public override string ToString()
        {
            return $"Name:{FirstName} {LastName}, Age:{Age}";
        }
    }
}
