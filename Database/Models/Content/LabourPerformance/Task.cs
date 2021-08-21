using Database.Models.Content.HumanResources;

namespace Database.Models.Content.LabourPerformance
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public int? EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}