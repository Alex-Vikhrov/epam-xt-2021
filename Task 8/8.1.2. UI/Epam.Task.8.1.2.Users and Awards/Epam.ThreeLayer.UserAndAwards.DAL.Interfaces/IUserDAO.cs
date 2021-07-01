using Epam.UserAndAwards.Entites;
using System;

namespace Epam.UserAndAwards.DAL.Interfaces
{
    public interface IUserDAO
    {
        void AddUser(User user);
        
        void RemoveUser(Guid id);

        void EditUser(Guid id, string newName, int newAge, string newDate);
    }
}
