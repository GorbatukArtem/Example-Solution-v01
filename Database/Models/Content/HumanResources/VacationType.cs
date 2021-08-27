using System.Collections.Generic;

namespace Database.Models.Content.HumanResources
{
    public class VacationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Vacation> Vacations { get; set; }

        public VacationType()
        {
            Vacations = new HashSet<Vacation>();
        }
    }
}