using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO.Containers;


namespace Service
{
    public partial class Service1 : IClientProvider
    {
        public List<ClientDTO> GetListClientByUserID(string userID)
        {
            List<ClientDTO> lst = new List<ClientDTO>();
            var D = 1;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    ClientDTO client = new ClientDTO();
                    client.ClientID = D.ToString();
                    client.Description = "client avec un ID = " + D;
                    client.FirstName = "name" + D;
                    client.LastName = "lastName" + D;
                    client.Address = "Rue 7303 menzah 9B Residence Essanauber";
                    client.CityID = j.ToString();
                    client.City = GetListCityByUserID(null).Where(c => c.CityID == j.ToString()).FirstOrDefault();
                    client.ZipCode = "1013";
                    client.Longitude = "36.851990";
                    client.Latitude = "10.147494";
                    lst.Add(client);
                    D++;
                }
            }
            return lst;
        }
    }
}
