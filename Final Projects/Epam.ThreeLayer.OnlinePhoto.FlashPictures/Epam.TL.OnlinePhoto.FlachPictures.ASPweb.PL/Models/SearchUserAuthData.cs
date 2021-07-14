using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epam.TL.OnlinePhoto.FlachPictures.ASPweb.PL.Models
{
    public class SearchUserAuthData
    {
        public bool LoginIsFound { get; private set; }

        public bool EmailIsFound { get; private set; }

        public void LoginStatus(bool result)
        {
            LoginIsFound = result;
        }

        public void EmailStatus(bool result)
        {
            EmailIsFound = result;
        }
    }
}