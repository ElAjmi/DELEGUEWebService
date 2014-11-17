using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO.Containers;


namespace Service
{
    public partial class Service1 : ICityProvider
    {
        public List<CityDTO> GetListCityByUserID(string userID)
        {
            List<CityDTO> lst = new List<CityDTO>();
           
            for (int j = 1; j <= 3; j++)
            {
                CityDTO city = new CityDTO();
                city.CityID = j.ToString();
                city.Name = "ville avec un ID = " + j;

                lst.Add(city);
                
            }
            
            return lst;
        }
    }
}
