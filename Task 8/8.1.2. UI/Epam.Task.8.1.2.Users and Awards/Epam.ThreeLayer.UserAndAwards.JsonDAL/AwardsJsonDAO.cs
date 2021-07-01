using System;
using System.IO;
using Epam.UserAndAwards.DAL.Interfaces;
using Epam.UserAndAwards.Entites;
using Newtonsoft.Json;

namespace Epam.UserAndAwards.JsonDAL
{
    public class AwardsJsonDAO: IAwardsDAO
    {
        public const string JsonFilesPath = @"C:\Users\vih_6\OneDrive\Рабочий стол\epam-xt-2021\Task 8\8.1.1. Users and Awards\Awards";

        public void AddAwards(Awards awards)
        {
            string json = JsonConvert.SerializeObject(awards);

            File.WriteAllText(GetFilePathByIId(awards.ID), json);
        }

        public void RemoveAwards(Guid id)
        {
            if (File.Exists(GetFilePathByIId(id)))
            {
                File.Delete(GetFilePathByIId(id));
            }
            else
            {
                throw new FileNotFoundException(
                    string.Format("File with name {0} at path {1} isn't created!", id + ".json", JsonFilesPath));
            }
        }

        public void EditAwards(Guid id, string newName)
        {
            if (File.Exists(GetFilePathByIId(id)))
            {
                throw new FileNotFoundException(
                    string.Format("File with name {0} at path {1} isn't created!", id, JsonFilesPath));
            }

            Awards awards = JsonConvert.DeserializeObject<Awards>(File.ReadAllText(GetFilePathByIId(id)));

            awards.EditName(newName);

            File.WriteAllText(GetFilePathByIId(awards.ID), JsonConvert.SerializeObject(awards));
        }

        private string GetFilePathByIId(Guid id) => JsonFilesPath + id + ".json";
    }
}
