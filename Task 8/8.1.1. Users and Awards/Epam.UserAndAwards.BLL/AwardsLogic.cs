using System;
using Epam.UserAndAwards.BLL.Interfaces;
using Epam.UserAndAwards.DAL.Interfaces;
using Epam.UserAndAwards.Entites;

namespace Epam.UserAndAwards.BLL
{
    public class AwardsLogic: IAwardsLogic
    {
        private IAwardsDAO _awardsDAO;

        public AwardsLogic(IAwardsDAO awardsDAO)
        {
            _awardsDAO = awardsDAO;
        }

        public void AddAwards(Awards awards)
        {
            _awardsDAO.AddAwards(awards);
        }

        public void RemoveAwards(Guid id)
        {
            _awardsDAO.RemoveAwards(id);
        }

        public void RemoveAwards(Awards awards) => RemoveAwards(awards.ID);

        public void EditAwards(Guid id, string newName)
        {
            _awardsDAO.EditAwards(id, newName);
        }
    }
}
