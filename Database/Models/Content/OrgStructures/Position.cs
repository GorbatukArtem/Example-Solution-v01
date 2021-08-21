using System;
using System.Collections.Generic;
using Database.Models.Content.HumanEducations;
using Database.Models.Content.OrgPositions;
using Database.Models.Content.Software;

namespace Database.Models.Content.OrgStructures
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? DepartmentId { get; set; }
        public int? ManagerId { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual Department Department { get; set; }
        public virtual Position Manager { get; set; }

        public virtual ICollection<Position> Subordinates { get; set; }
        public virtual ICollection<Process> Processes { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Backup> Backups { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Access> Accesses { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<Application> Applications { get; set; }

        public Position()
        {
            Subordinates = new HashSet<Position>();
            Processes = new HashSet<Process>();
            Assignments = new HashSet<Assignment>();
            Backups = new HashSet<Backup>();
            Documents = new HashSet<Document>();
            Accesses = new HashSet<Access>();
            Skills = new HashSet<Skill>();
            Applications = new HashSet<Application>();
        }
    }
}