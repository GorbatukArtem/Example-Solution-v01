using System;
using System.Collections.Generic;

namespace Database.Models.Content.OrgStructures
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual ICollection<Department> Departments { get; set; }

        public Company()
        {
            Departments = new HashSet<Department>();
        }
    }
}