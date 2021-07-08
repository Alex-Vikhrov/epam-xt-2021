using System;
using System.Collections.Generic;
using System.Linq;
using Epam.TL.OnlinePhoto.FlashPictures.BLL.Interfaces;
using Epam.TL.OnlinePhoto.FlashPictures.DAL.Interfaces;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;


namespace Epam.TL.OnlinePhoto.FlashPictures.BLL
{
    public class UserLogic: IUserLogic
    {
        IUserDAL userDal;
        ILikeImageDAL likeDal;
        public UserLogic(IUserDAL userDal, ILikeImageDAL likeDal)
        {
            this.userDal = userDal;
            this.likeDal = likeDal;
        }

        public bool Add(User data)
        {
            return userDal.Add(data);
        }

        public User Get(string login)
        {
            return userDal.Get(login);
        }

        public User GetById(Guid id)
        {
            return userDal.GetById(id);
        }

        public IEnumerable<User> GetALL()
        {
            return userDal.GetALL().ToArray();
        }

        public bool Remove(string login)
        {
            return userDal.Remove(login);
        }

        public bool LiceImage(Guid userId, Guid imageId)
        {
            if (likeDal.GetALL().FirstOrDefault(x => x.UserId == userId && x.ImageId == imageId) == null)
            {
                return likeDal.Add(new LikeImage { UserId = userId, ImageId = imageId });
            }
            else
            {
                return likeDal.Remove(userId, imageId);
            }
        }
    }
}
