using System;

namespace Epam.UserAndAwards.Entites
{
    public class User
    {
        public User(string name, int age, Guid id, string date)
        {
            ID = id; // генерирует уникальный индификатор 
            Name = name;
            DateOfBirth = date;
            DateOfCreation = DateTime.Now;
            Age = age;
        }

        public Guid ID { get; }

        public string Name { get; private set; }

        public string DateOfBirth { get; private set; }

        public DateTime DateOfCreation { get; }

        public int Age { get; private set; }

        public void EditName(string newName)
        {
            if (newName == null)
            {
                throw new ArgumentException("str", "Name string cannot be null!");
            }

            Name = newName;
        }

        public void EditDateOfBirth(string newDate)
        {
            DateOfBirth = newDate;
        }

        public void EditAge(int newAge)
        {
            Age = newAge;
        }
    }
}
