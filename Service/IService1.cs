using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Service;

namespace Service
{
    [ServiceContract]
    public interface IService1 :IPlanningProvider,IClientProvider,IUserProvider,IPlanningDayProvider,ICityProvider
    {

    }
}
