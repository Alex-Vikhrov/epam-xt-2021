using System;
using System.Collections.Generic;
using System.Linq;
using Epam.TL.OnlinePhoto.FlashPictures.BLL.Interfaces;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;
using Epam.TL.OnlinePhoto.FlashPictures.DAL.Interfaces;

namespace Epam.TL.OnlinePhoto.FlashPictures.BLL
{
    public class ImageLogic: IImageLogic
    {
        IImageDAL imageDal;
        ILikeImageDAL likeDal;
        public ImageLogic(IImageDAL imageDal, ILikeImageDAL likeDal)
        {
            this.imageDal = imageDal;
            this.likeDal = likeDal;
        }

        public bool Add(Image image)
        {
            return imageDal.Add(image);
        }

        public Image Get(Guid id)
        {
            return imageDal.Get(id);
        }

        public IEnumerable<Image> GetALL()
        {
            return imageDal.GetALL().ToArray();
        }

        public IEnumerable<Image> GetAllByUser(User user)
        {
            return GetALL().Where(x => x.CreationId == user.Id).ToArray();
        }

        public int GetLikesCount(Guid imageId)
        {
            return likeDal.GetALL().Where(x => x.ImageId == imageId).Count();
        }

        public bool Remove(Guid Id)
        {
            var rels = likeDal.GetALL().Where(x => x.ImageId == Id);

            foreach(var link in rels)
            {
                likeDal.Remove(link.UserId, link.ImageId);
            }
            return imageDal.Remove(Id);
        }

        public bool Update(Image data)
        {
            return imageDal.Update(data);
        }
    }
}
