using System;
using System.Collections.Generic;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;

namespace Epam.TL.OnlinePhoto.FlashPictures.DAL.Interfaces
{
    public interface IUserDAL
    {
        string[] CheckUserAuthData(string login, string email);

        bool UserAuthentication(string login, string hpassword);

        bool Add(User user);

        bool Remove(string login);

        User Get(string login);

        User GetById(Guid id);

        IEnumerable<User> GetALL();
    }
}
