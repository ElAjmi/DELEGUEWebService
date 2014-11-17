using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using DTO.Containers;

namespace Service
{
    [ServiceContract]
    public interface IPlanningDayProvider 
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "GetPlanningDayByUserID/{userID}")]
        List<PlanningDayDTO> GetPlanningDayByUserID(string userID);
    }
}
