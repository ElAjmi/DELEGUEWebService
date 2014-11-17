using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO.Containers
{
    public class PlanningDTO
    {
        public string PlanningID;
        public string StartDate;
        public string EndDate;
        public List<PlanningDayDTO> Lundi = new List<PlanningDayDTO>();
        public List<PlanningDayDTO> Mardi = new List<PlanningDayDTO>();
        public List<PlanningDayDTO> Mercredi = new List<PlanningDayDTO>();
        public List<PlanningDayDTO> Jeudi = new List<PlanningDayDTO>();
        public List<PlanningDayDTO> Vendredi = new List<PlanningDayDTO>();
        public List<PlanningDayDTO> Samedi = new List<PlanningDayDTO>();
        public List<PlanningDayDTO> Dimanche = new List<PlanningDayDTO>();
    }
}
