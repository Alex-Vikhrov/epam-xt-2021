using System;
using System.IO;
using Epam.UserAndAwards.DAL.Interfaces;
using Epam.UserAndAwards.Entites;
using Newtonsoft.Json;

namespace Epam.UserAndAwards.JsonDAL
{
    public class UserJsonDAO : IUserDAO
    {
        public const string JsonFilesPath = @"C:\Users\vih_6\OneDrive\Рабочий стол\epam-xt-2021\Task 8\8.1.2. UI\Epam.Task.8.1.2.Users and Awards\Files";

        public void AddUser(User user)
        {
            string json = JsonConvert.SerializeObject(user);

            File.WriteAllText(GetFilePathByIId(user.ID), json);
        }

        public void RemoveUser(Guid id)
        {
            if(File.Exists(GetFilePathByIId(id)))
            {
                File.Delete(GetFilePathByIId(id));
            } 
            else
            {
                throw new FileNotFoundException(
                    string.Format("File with name {0} at path {1} isn't created!", id + ".json", JsonFilesPath));
            }
        }

        public void EditUser(Guid id, string newName, int newAge, string newDate)
        {
            if (File.Exists(GetFilePathByIId(id)))
            {
                throw new FileNotFoundException(
                    string.Format("File with name {0} at path {1} isn't created!", id, JsonFilesPath));
            }

            User user = JsonConvert.DeserializeObject<User>(File.ReadAllText(GetFilePathByIId(id)));

            user.EditName(newName);
            user.EditDateOfBirth(newDate);
            user.EditAge(newAge);

            File.WriteAllText(GetFilePathByIId(user.ID), JsonConvert.SerializeObject(user));
        }

        private string GetFilePathByIId(Guid id) => JsonFilesPath + id + ".json";
    }
}
