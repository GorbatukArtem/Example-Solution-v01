using System.Collections.Generic;
using Database.Models.Content.OrgPositions;

namespace Database.Models.Content.OrgProcesses
{
    public class ProcessCriticality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Process> Processes { get; set; }

        public ProcessCriticality()
        {
            Processes = new HashSet<Process>();
        }
    }
}