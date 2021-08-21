using System;
using Database.Models.Content.HumanResources;
using Database.Models.Content.OrgStructures;

namespace Database.Models.Content.OrgPositions
{
    public class Assignment
    {
        public int Id { get; set; }

        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int EmployeeId { get; set; }

        public double FullTimeEmployee { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual Employee Employee { get; set; }
    }
}