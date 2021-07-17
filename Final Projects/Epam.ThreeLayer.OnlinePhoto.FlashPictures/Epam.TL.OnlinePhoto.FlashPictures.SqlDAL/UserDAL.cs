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

        public bool Add(User user)
        {
            if (user == null)
            {
                return false;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commander = new SqlCommand("INSERT INTO [Users] ([Id],[Login],[Password],[Email]) VALUES(@Id,@Login,@Password,@Email)", connection);
                commander.Parameters.AddWithValue("@Login", user.Login);
                commander.Parameters.AddWithValue("@Password", user.Password);
                commander.Parameters.AddWithValue("@Id", user.Id);
                commander.Parameters.AddWithValue("@Email", user.Email);
                connection.Open();
                return commander.ExecuteNonQuery() > 0;
            }
            throw new NullReferenceException();
        }

        public string[] CheckUserAuthData(string login, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string[] result = new string[2];
                var Users_CheckLoginAndEmail = "SearchAuthData";
                SqlCommand command = new SqlCommand(Users_CheckLoginAndEmail, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (login == (string)reader[0])
                        result[0] = login;
                    if (email == (string)reader[1])
                        result[1] = email;
                    return result;
                }
                return result;
            }
        }

        public bool UserAuthentication(string login, string hpassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var Users_CheckLoginAndPassword = "ValidateAuthData";
                SqlCommand command = new SqlCommand(Users_CheckLoginAndPassword, connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", hpassword);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (login == (string)reader[0] && hpassword == (string)reader[1])
                        return true;
                }
                return false;
            }
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
