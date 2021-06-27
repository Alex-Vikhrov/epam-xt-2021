using System;
using Epam.UserAndAwards.Dependencies;
using Epam.UserAndAwards.BLL;
using Epam.UserAndAwards.Entites;
using System.Collections.Generic;

namespace Epam.UserAndAwards.ConsolePL
{
    public class ConsolePl
    {
        static void Main(string[] args)
        {
            var bllUser = DependencyResolver.Intanse.UserLogic;
            var bllAvards = DependencyResolver.Intanse.AwardsLogic;

            Console.WriteLine("Введите имя:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            var age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату рождения:");
            var date = Console.ReadLine();

            bllUser.AddUser(new User(name, age, new Guid(), date));
            Console.WriteLine("----------");

            Console.WriteLine("Введите награду");
            var awardsName = Console.ReadLine();

            bllAvards.AddAwards(new Awards(awardsName, new Guid()));
        }
    }
}
