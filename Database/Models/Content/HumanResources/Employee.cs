using System;
using System.Collections.Generic;
using Database.Models.Content.OrgPositions;

namespace Database.Models.Content.HumanResources
{
    public class Employee
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }

        public double FullTimeEmployee { get; set; }

        public int? BirthDay { get; set; }
        public int? BirthMonth { get; set; }

        public int? ManageId { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        //public virtual ICollection<Assignment> Assignments { get; set; }
        //public virtual ICollection<Backup> Backups { get; set; }
        //public virtual ICollection<Vacation> Vacations { get; set; }

        public Employee()
        {
            //Assignments = new HashSet<Assignment>();
            //Backups = new HashSet<Backup>();
            //Vacations = new HashSet<Vacation>();
        }
    }
}