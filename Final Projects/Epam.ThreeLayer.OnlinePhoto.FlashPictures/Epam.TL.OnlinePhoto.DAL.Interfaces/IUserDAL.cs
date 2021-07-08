using System;
using System.Collections.Generic;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;

namespace Epam.TL.OnlinePhoto.FlashPictures.DAL.Interfaces
{
    public interface IUserDAL
    {
        bool Add(User data);

        bool Remove(string login);

        User Get(string login);

        User GetById(Guid id);

        IEnumerable<User> GetALL();
    }
}
