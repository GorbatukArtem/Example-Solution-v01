using System;
using System.Collections.Generic;

namespace Database.Models.Content.OrgStructures
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? CompanyId { get; set; }
        public int? ParentDepartmentId { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual Company Company { get; set; }
        public virtual Department ParentDepartment { get; set; }
        public virtual ICollection<Department> Teams { get; set; }
        public virtual ICollection<Position> Positions { get; set; }

        public Department()
        {
            Teams = new HashSet<Department>();
            Positions = new HashSet<Position>();
        }
    }
}