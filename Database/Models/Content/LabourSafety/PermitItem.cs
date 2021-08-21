namespace Database.Models.Content.LabourSafety
{
    public class PermitItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Permit Permit { get; set; }
    }
}