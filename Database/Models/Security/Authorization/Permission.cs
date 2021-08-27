namespace Database.Models.Security.Authorization
{
    public class Permission
    {
        public int? RoleId { get; set; }
        public int? UserId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}