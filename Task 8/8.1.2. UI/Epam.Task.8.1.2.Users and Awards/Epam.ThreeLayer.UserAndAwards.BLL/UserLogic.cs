using System;
using Epam.UserAndAwards.BLL.Interfaces;
using Epam.UserAndAwards.DAL.Interfaces;
using Epam.UserAndAwards.Entites;
using Epam.UserAndAwards.JsonDAL;

namespace Epam.UserAndAwards.BLL
{
    public class UserLogic: IUserLogic
    {
        private IUserDAO _usersDAO;
        public UserLogic(IUserDAO userDAO)
        {
            _usersDAO = userDAO;
        }

        public void AddUser(User user)
        {
            _usersDAO.AddUser(user);
        }

        public void RemoveUser(Guid id)
        {
            _usersDAO.RemoveUser(id);
        }

        public void RemoveUser(User user) => RemoveUser(user.ID);

        public void EditUser(Guid id, string newName, int newAge, string newDate)
        {
            _usersDAO.EditUser(id, newName, newAge, newDate);
        } 
    }
}
