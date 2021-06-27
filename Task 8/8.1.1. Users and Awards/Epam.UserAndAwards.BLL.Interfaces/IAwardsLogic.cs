using Epam.UserAndAwards.Entites;
using System;

namespace Epam.UserAndAwards.BLL.Interfaces
{
    public interface IAwardsLogic
    {
        void AddAwards(Awards awards);

        void RemoveAwards(Guid id);

        void EditAwards(Guid id, string newName);
    }
}
