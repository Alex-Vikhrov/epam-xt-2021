using Epam.UserAndAwards.Entites;
using System;

namespace Epam.UserAndAwards.DAL.Interfaces
{
    public interface IAwardsDAO
    {
        void AddAwards(Awards awards);

        void RemoveAwards(Guid id);

        void EditAwards(Guid id, string newName);
    }
}
