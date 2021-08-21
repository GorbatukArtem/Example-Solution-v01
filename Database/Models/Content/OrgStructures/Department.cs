using System;
using System.Collections.Generic;

namespace Database.Models.Content.OrgStructures
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? CompanyId { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public ICollection<Team> Teams { get; set; }

        public Department()
        {
            Teams = new HashSet<Team>();
        }
    }
}