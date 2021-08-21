using System.Collections.Generic;

namespace Database.Models.Content.LabourSafety
{
    public class PermitType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Permit> Permits { get; set; }

        public PermitType()
        {
            Permits = new HashSet<Permit>();
        }
    }
}