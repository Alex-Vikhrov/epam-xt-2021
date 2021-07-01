using Epam.UserAndAwards.BLL;
using Epam.UserAndAwards.BLL.Interfaces;
using Epam.UserAndAwards.DAL.Interfaces;
using Epam.UserAndAwards.JsonDAL;
using Epam.UserAndAwards.Sql.DAL;
using System;

namespace Epam.ThreeLayer.UserAndAwards.Dependencies
{
    public class DependencyResolver
    {
        #region SINGLTONE
        private static DependencyResolver _instance;

        public static DependencyResolver Intanse
        {
            get
            {
                return _instance = new DependencyResolver();
            }
        }
        #endregion

        public IUserDAO UserDAO => new UserJsonDAO();

        public IUserLogic UserLogic => new UserLogic(UserDAO);

        public IAwardsDAO AwardsDAO => new AwardsJsonDAO();

        public IAwardsLogic AwardsLogic => new AwardsLogic(AwardsDAO);
    }
}
