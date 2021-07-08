using System;
using System.Collections.Generic;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;

namespace Epam.TL.OnlinePhoto.FlashPictures.BLL.Interfaces
{
    public interface IImageLogic
    {
        bool Add(Image data);

        bool Remove(Guid id);

        bool Update(Image data);

        Image Get(Guid id);

        IEnumerable<Image> GetALL();

        IEnumerable<Image> GetAllByUser(User user);

        int GetLikesCount(Guid imageId);
    }
}
