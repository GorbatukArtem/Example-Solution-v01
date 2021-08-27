using System;

namespace Database.Models.Content.HumanResources
{
    public class Vacation
    {
        public int Id { get; set; }

        public int VacationTypeId { get; set; }
        public int EmployeeId { get; set; }

        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        
        public virtual VacationType VacationType { get; set; }
        public virtual Employee Employee { get; set; }
    }
}