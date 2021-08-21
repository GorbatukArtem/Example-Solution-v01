using System;
using Database.Models.Content.OrgProcesses;

namespace Database.Models.Content.OrgPositions
{
    public class Process
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? ComplexityId { get; set; }
        public int? CriticalityId { get; set; }
        public int? FrequencyId { get; set; }

        public int? PositionId { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual ProcessComplexity Complexity { get; set; }
        public virtual ProcessCriticality Criticality { get; set; }
        public virtual ProcessFrequency Frequency { get; set; }
    }
}