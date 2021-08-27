using System.Collections.Generic;

namespace Database.Models.Content.LabourSafety
{
    public class IncidentType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Incident> Incidents { get; set; }

        public IncidentType()
        {
            Incidents = new HashSet<Incident>();
        }
    }
}