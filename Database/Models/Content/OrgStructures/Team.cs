using System.Collections.Generic;

namespace Database.Models.Content.OrgStructures
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Position> Positions { get; set; }

        public Team()
        {
            Positions = new HashSet<Position>();
        }
    }
}