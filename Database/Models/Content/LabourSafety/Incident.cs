using System;
using Database.Models.Content.HumanResources;

namespace Database.Models.Content.LabourSafety
{
    public class Incident
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public DateTime DateTimeUtc { get; set; }
        public int? IncidentTypeId { get; set; }
        public int? ResponsibleId { get; set; }
        public int? ViolatorId { get; set; }
        

        public IncidentType IncidentType { get; set; }
        public Employee Responsible { get; set; }
        public Employee Violator { get; set; }
    }
}