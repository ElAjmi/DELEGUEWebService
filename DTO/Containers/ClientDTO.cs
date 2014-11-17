using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO.Containers
{
    public class ClientDTO
    {
        public string ClientID;
        public string Description;
        public string FirstName;
        public string LastName;
        public string Address ;
        public string CityID ;
        public CityDTO City ;
        public string ZipCode ;
        public string Longitude ;
        public string Latitude;
    }
}
