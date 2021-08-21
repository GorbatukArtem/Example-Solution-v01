using System.Collections.Generic;
using Database.Models.Content.OrgPositions;

namespace Database.Models.Content.OrgProcesses
{
    public class ProcessFrequency
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Process> Processes { get; set; }

        public ProcessFrequency()
        {
            Processes = new HashSet<Process>();
        }
    }
}