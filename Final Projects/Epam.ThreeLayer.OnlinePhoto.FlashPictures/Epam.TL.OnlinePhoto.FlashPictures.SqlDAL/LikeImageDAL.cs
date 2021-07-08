using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;
using Epam.TL.OnlinePhoto.FlashPictures.DAL.Interfaces;

namespace Epam.TL.OnlinePhoto.FlashPictures.SqlDAL
{
    public class LikeImageDAL: ILikeImageDAL
    {
        private string connectionString;

        public LikeImageDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        }

        public bool Add(LikeImage data)
        {
            if (data == null)
            {
                return false;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commander = new SqlCommand("INSERT INTO [LikeImageRels] ([UserId],[ImageId]) VALUES(@UserId,@ImageId)", connection);
                commander.Parameters.AddWithValue("@UserId", data.UserId);
                commander.Parameters.AddWithValue("@ImageId", data.ImageId);
                connection.Open();
                return commander.ExecuteNonQuery() > 0;
            }
            throw new NullReferenceException();
        }

        public LikeImage Get(Guid userId, Guid imageId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commander = new SqlCommand("SELECT [UserId],[ImageId] FROM [LikeImageRels] WHERE ([UserId]=@UserId AND [ImageId] = @ImageId)", connection);
                commander.Parameters.AddWithValue("@UserId", userId);
                commander.Parameters.AddWithValue("@ImageId", imageId);
                connection.Open();
                var reader = commander.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }
                return new LikeImage()
                {
                    UserId = (Guid)reader["UserId"],
                    ImageId = (Guid)reader["ImageId"]
                };
            }
            throw new Exception();
        }

        public IEnumerable<LikeImage> GetALL()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commander = new SqlCommand("SELECT [UserId],[Imageid] FROM [LikeImageRels]", connection);
                connection.Open();
                var reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    yield return new LikeImage()
                    {
                        UserId = (Guid)reader["UserId"],
                        ImageId = (Guid)reader["ImageId"]
                    };
                }
            }
        }

        public bool Remove(Guid userId, Guid imageId)
        {
            LikeImage todo;
            try
            {
                todo = Get(userId, imageId);
            }
            catch (Exception e)
            {
                throw e;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand commander = new SqlCommand("DELETE FROM [LikeImage] WHERE ([UserId]=@UserId AND [ImageId] = @ImageId)", connection);
                commander.Parameters.AddWithValue("@UserId", userId);
                commander.Parameters.AddWithValue("@ImageId", imageId);
                connection.Open();
                return commander.ExecuteNonQuery() > 0;
            }
        }
    }
}
