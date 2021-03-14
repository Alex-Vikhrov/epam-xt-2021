using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1._2._Custom_Paint
{
    class User
    {
        // Поля данных
      /*  private */ public string userName;

        // Конструкторы 
        //public User() { }
        public User(string name)
        {
            Console.WriteLine("Enter User Name:");
            name = Console.ReadLine();// перенести в мейн
            userName = name;
        }
        // Свойства
        public string Name
        {
            get { return userName; }
            set
            {
                if (value.Length > 20)
                {
                    Console.WriteLine("Error! Name length exceeds 20 characters"); // Ошибка ! Длина имени превышает 20 символов 
                }
                else
                {
                    userName = value;
                }
            }
        }

        public void DisplayStats()
        {
            Console.WriteLine("User Name: {0}", userName);
        }
    }
}
