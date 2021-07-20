using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Epam.TL.OnlinePhoto.FlashPictures.DAL.Interfaces;
using Epam.TL.OnlinePhoto.FlashPictures.Entites;

namespace Epam.TL.OnlinePhoto.FlashPictures.SqlDAL
{
    public class ImageDAL: IImageDAL
    {
        private string connectionString;

        public ImageDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        }

        public bool Add(Image image)
        {
            if (image == null)
            {
                return false;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var AddImage = "AddImage";
                SqlCommand commander = new SqlCommand(AddImage/*"INSERT INTO [Image] ([Id],[CreationId][CreationDate],[ContentType],[Date]) VALUES(@Id,@CreationId,@CreationDate,@ContentType,@Date)"*/, connection);
                commander.Parameters.AddWithValue("@Id", image.Id);
                commander.Parameters.AddWithValue("@CreationId", image.CreationId);
                commander.Parameters.AddWithValue("@ContentType", image.ContentType);
                commander.Parameters.AddWithValue("@CreationDate", image.CreationDate);
                commander.Parameters.AddWithValue("@Date", image.Date);
                connection.Open();
                return commander.ExecuteNonQuery() > 0
;            }
            throw new NullReferenceException();
        }

        public Image Get(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var ImageGetById = "ImageGetById";
                SqlCommand commander = new SqlCommand(ImageGetById/*"SELECT[Id],[CreationId],[CreationDate],[ContentType],[Date] FROM [Image] WHERE [Id]=@id"*/, connection);
                commander.Parameters.AddWithValue("@id", id);
                connection.Open();

                var reader = commander.ExecuteReader();
                if (!reader.Read())
                {
                    return null;
                }
                return new Image()
                {
                    CreationId = (Guid)reader["CreationId"],
                    CreationDate = (DateTime)reader["CreationDate"],
                    ContentType = (string)reader["ContentType"],
                    Id = (Guid)reader["Id"],
                    Date = reader["Date"] as byte[]
                };
            }
            throw new Exception();
        }

        public IEnumerable<Image> GetALL()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var GetAllImage = "GetAllImage";
                SqlCommand commander = new SqlCommand(GetAllImage/*"SELECT [Id],[CreationId],[CreationDate],[ContentType],[Date] FROM [Image]"*/, connection);
                connection.Open();

                var reader = commander.ExecuteReader();
                while (reader.Read())
                {
                    yield return new Image()
                    {
                        CreationId = (Guid)reader["CreationId"],
                        CreationDate = (DateTime)reader["CreationDate"],
                        ContentType = (string)reader["ContentType"],
                        Id = (Guid)reader["Id"],
                        Date = reader["Date"] as byte[]
                    };
                }
            }
        }

        public bool Remove(Guid id)
        {
            Image todo;
            try
            {
                todo = Get(id);
            }
            catch (Exception e)
            {
                throw e;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var DeleteImage = "DeleteImage";
                SqlCommand commander = new SqlCommand(DeleteImage/*"DELETE FROM [Image] WHERE [Id]=@id"*/, connection);
                commander.Parameters.AddWithValue("@id", id);
                connection.Open();
                return commander.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(Image data)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var UpdateImage = "UpdateImage";
                SqlCommand commander = new SqlCommand(UpdateImage/*"UPDATE SET [ContentType] = @ContentType,[Date] = @Date WHERE [Id]=@id"*/, connection);
                commander.Parameters.AddWithValue("@Id", data.Id);
                commander.Parameters.AddWithValue("@ContentType", data.ContentType);
                commander.Parameters.AddWithValue("@Date", data.Date);
                connection.Open();
                return commander.ExecuteNonQuery() > 0;
            }
        }
    }
}
