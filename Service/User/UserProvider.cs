using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO.Containers;
using System.Web.Script.Serialization;

namespace Service
{
    public partial class Service1 : IUserProvider
    {
        public UserDTO GetUserByLogin(string login, string password)
        {
            UserDTO user = new UserDTO();
            user.Email = "mahmoud.elajmi@live.fr";
            user.FirstName = "mahmoud";
            user.LastName = "EL AJMI";
            user.UserID = "1";
            user.Login = "mah";
            user.Password = "mah";

            //JavaScriptSerializer js = new JavaScriptSerializer();
            //return js.Serialize(user);
            return user;
        }
    }
}
