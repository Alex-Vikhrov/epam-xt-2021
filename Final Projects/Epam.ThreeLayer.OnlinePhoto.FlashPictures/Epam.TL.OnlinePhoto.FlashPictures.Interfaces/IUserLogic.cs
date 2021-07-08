using System;
using System.Collections.Generic;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;

namespace Epam.TL.OnlinePhoto.FlashPictures.BLL.Interfaces
{
    public interface IUserLogic
    {
        bool Add(User data);

        bool Remove(string login);

        bool LiceImage(Guid userId, Guid imageId);

        User Get(string login);

        User GetById(Guid id);

        IEnumerable<User> GetALL();

    }
}
