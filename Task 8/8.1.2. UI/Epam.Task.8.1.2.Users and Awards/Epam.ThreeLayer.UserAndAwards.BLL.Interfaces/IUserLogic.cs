using Epam.UserAndAwards.Entites;
using System;


namespace Epam.UserAndAwards.BLL.Interfaces
{
    public interface IUserLogic
    {
        void AddUser(User user);

        void RemoveUser(Guid id);

        void RemoveUser(User user);

        void EditUser(Guid id, string newName, int newAge, string newDate);
    }
}
