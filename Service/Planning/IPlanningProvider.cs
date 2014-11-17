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
    public interface IPlanningProvider 
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "GetPlanningByUserID/{userID}")]
        PlanningDTO GetPlanningByUserID(string userID);
    }
}
