using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO.Containers;
using Service;

namespace Service
{
    public partial class Service1 : IPlanningProvider 
    {

        public PlanningDTO GetPlanningByUserID(string userID)
        {
            PlanningDTO planning = new PlanningDTO();
            planning.StartDate = DateTime.Now.ToString("dd/MM/yyyy");
            planning.EndDate = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            planning.Lundi = GetPlanningDayByUserID(null).Where(p=>p.DayNumber == "1").ToList();
            planning.Mardi = GetPlanningDayByUserID(null).Where(p => p.DayNumber == "2").ToList();
            planning.Mercredi = GetPlanningDayByUserID(null).Where(p => p.DayNumber == "3").ToList();
            planning.Jeudi = GetPlanningDayByUserID(null).Where(p => p.DayNumber == "4").ToList();
            planning.Vendredi = GetPlanningDayByUserID(null).Where(p => p.DayNumber == "5").ToList();
            planning.Samedi = GetPlanningDayByUserID(null).Where(p => p.DayNumber == "6").ToList();
            planning.Dimanche = GetPlanningDayByUserID(null).Where(p => p.DayNumber == "7").ToList();
            return planning;
        }
    }
}
