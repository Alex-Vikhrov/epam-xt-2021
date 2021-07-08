using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;
using Epam.TL.OnlinePhoto.FlashPictures.DAL.Interfaces;

namespace Epam.TL.OnlinePhoto.FlashPictures.SqlDAL
{
    public class UserDAL: IUserDAL
    {
        private string connectionString;
        public UserDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        }

        public bool Add(User data)
        {
            if (data == null)
            {
                return false;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commander = new SqlCommand("INSERT INTO [Users] ([Id],[Login],[Password],[Email]) VALUES(@Id,@Login,@Password,@Email)", connection);
                commander.Parameters.AddWithValue("@Login", data.Login);
                commander.Parameters.AddWithValue("@Password", data.Password);
                commander.Parameters.AddWithValue("@Id", data.Id);
                commander.Parameters.AddWithValue("@Email", data.Email);
                connection.Open();
                return commander.ExecuteNonQuery() > 0;
            }
            throw new NullReferenceException();
        }

        public User Get(string login)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commander = new SqlCommand("SELECT [Id],[Login],[Password],[Email] FROM [Users] WHERE [Login]=@Login", connection);
                commander.Parameters.AddWithValue("@Login", login);
                connection.Open();

                var reader = commander.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }
                return new User()
                {
                    Id = (Guid)reader["Id"],
                    Login = (string)reader["Login"],
                    Password = (string)reader["Password"],
                    Email = (string)reader["Email"]
                };
            }
            throw new Exception();
        }

        public IEnumerable<User> GetALL()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commander = new SqlCommand("SELECT [Id],[Login],[Password],[Email], FROM [Users]", connection);
                connection.Open();

                var reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    yield return new User()
                    {
                        Id = (Guid)reader["Id"],
                        Login = (string)reader["Login"],
                        Password = (string)reader["Password"],
                        Email = (string)reader["Email"],
                    };
                }
            }
        }

        public User GetById(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commander = new SqlCommand("SLECT [Id],[Login],[Passwor],[Email] FROM [Users] WHERE [Id]=@Id", connection);
                commander.Parameters.AddWithValue("@Id", id);
                connection.Open();
                var reader = commander.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }
                return new User()
                {
                    Id = (Guid)reader["Id"],
                    Login = (string)reader["Login"],
                    Password = (string)reader["Password"],
                    Email = (string)reader["Email"]
                };
            }
            throw new Exception();
        }

        public bool Remove(string login)
        {
            User todo;
            try
            {
                todo = Get(login);
            }
            catch (Exception e)
            {
                throw e;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commander = new SqlCommand("DELETE FROM [USER] WHERE [Login]=@Login", connection);
                commander.Parameters.AddWithValue("@Login", login);
                connection.Open();
                return commander.ExecuteNonQuery() > 0;
            }
        }
    }
}
