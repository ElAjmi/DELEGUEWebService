using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO.Containers;
using Service;

namespace Service
{
    public partial class Service1 : IPlanningDayProvider 
    {

        public List<PlanningDayDTO> GetPlanningDayByUserID(string userID)
        {
            List<PlanningDayDTO> lst = new List<PlanningDayDTO>();
            var D = 1;
            for (int i = 1; i <= 7; i++)
            {
                
                for (int j = 1; j <= 3; j++)
                {
                    PlanningDayDTO planningDay = new PlanningDayDTO();
                    planningDay.DayNumber = i.ToString();
                    planningDay.PlanningDayID = D.ToString();
                    planningDay.ClientID = D.ToString();
                    planningDay.Client = GetListClientByUserID(null).ElementAt(D - 1);
                    lst.Add(planningDay);
                    D++;
                }
            }
            return lst;
        }
    }
}
