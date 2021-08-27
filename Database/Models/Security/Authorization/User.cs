using System.Collections.Generic;
using Database.Models.Logs;

namespace Database.Models.Security.Authorization
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<HistoryLogin> HistoryLogins { get; set; }

        public User()
        {
            Permissions = new HashSet<Permission>();
            HistoryLogins = new HashSet<HistoryLogin>();
        }
    }
}