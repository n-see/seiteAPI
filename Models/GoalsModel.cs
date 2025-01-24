using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seiteAPI.Models
{
    public class GoalsModel
    {   
        public int Id {get; set;}
        public int StudentId { get; set; }
        public string? Description { get; set; }
        public string? AreaOfNeed { get; set; }
        public string? MeasurableAnnualGoal { get; set; }
        public string? Baseline { get; set; }
        public bool IsDeleted { get; set;}
    }
}