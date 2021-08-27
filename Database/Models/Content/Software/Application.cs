using System.Collections.Generic;
using Database.Models.Content.OrgStructures;

namespace Database.Models.Content.Software
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Position> Positions { get; set; }

        public Application()
        {
            Positions = new HashSet<Position>();
        }
    }
}