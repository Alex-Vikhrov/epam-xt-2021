using System;
using System.Collections.Generic;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;

namespace Epam.TL.OnlinePhoto.FlashPictures.DAL.Interfaces
{
    public interface IImageDAL
    {
        bool Add(Image image);

        bool Remove(Guid id);

        bool Update(Image data);

        Image Get(Guid id);

        IEnumerable<Image> GetALL();
    }
}
