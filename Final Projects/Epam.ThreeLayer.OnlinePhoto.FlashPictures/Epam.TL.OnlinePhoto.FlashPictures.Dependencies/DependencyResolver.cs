using System;
using Epam.TL.OnlinePhoto.FlashPictures.BLL;
using Epam.TL.OnlinePhoto.FlashPictures.BLL.Interfaces;
using Epam.TL.OnlinePhoto.FlashPictures.SqlDAL;
using Epam.TL.OnlinePhoto.FlashPictures.DAL.Interfaces;

namespace Epam.TL.OnlinePhoto.FlashPictures.Dependencies
{
    public class DependencyResolver
    {
        #region SINGLTONE
        private static DependencyResolver _instance;

        public static DependencyResolver Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DependencyResolver();
                }

                    return _instance;
            }
        }
        #endregion

        public IUserDAL UserDAL => new UserDAL();

        public IImageDAL ImageDAL => new ImageDAL();

        public ILikeImageDAL LikeImageDAL => new LikeImageDAL();

        public IUserLogic UserLogic => new UserLogic(UserDAL, LikeImageDAL);

        public IImageLogic ImageLogic => new ImageLogic(ImageDAL, LikeImageDAL);

    }
}
