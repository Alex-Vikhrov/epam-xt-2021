using System;
using System.Collections.Generic;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;

namespace Epam.TL.OnlinePhoto.FlashPictures.DAL.Interfaces
{
    public interface ILikeImageDAL
    {
        bool Add(LikeImage data);

        LikeImage Get(Guid userId, Guid imageId);

        bool Remove(Guid userId, Guid imageId);

        IEnumerable<LikeImage> GetALL();
    }
}
