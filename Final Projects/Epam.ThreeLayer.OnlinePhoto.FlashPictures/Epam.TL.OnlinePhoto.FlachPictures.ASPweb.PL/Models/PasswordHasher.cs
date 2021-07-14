using System;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Epam.TL.OnlinePhoto.FlachPictures.ASPweb.PL.Models
{
    public class PasswordHasher
    {
        public string GetHash(string password)
        {
            var sha = SHA256.Create();
            var hpassword = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hpassword);
        }
    }
}