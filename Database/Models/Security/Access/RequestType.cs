using System.Collections.Generic;

namespace Database.Models.Security.Access
{
    public class RequestType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RequestedRole> RequestedRoles { get; set; }

        public RequestType()
        {
            RequestedRoles = new HashSet<RequestedRole>();
        }
    }
}