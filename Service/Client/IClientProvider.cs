using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO.Containers;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Service
{
    [ServiceContract]
    public interface IClientProvider
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "GetListClientByUserID/{userID}")]
        List<ClientDTO> GetListClientByUserID(string userID);
    }
}
