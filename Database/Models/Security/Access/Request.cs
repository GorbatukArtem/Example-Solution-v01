using Database.Models.Security.Authorization;
using System.Collections.Generic;
using System;

namespace Database.Models.Security.Access
{
    public class Request
    {
        public int Id { get; set; }
        public int? ConsumerId { get; set; }
        public int? RequesterId { get; set; }
        public DateTime? CreatedUtc { get; set; }

        public virtual User Consumer { get; set; }
        public virtual User Requester { get; set; }

        public virtual ICollection<RequestedRole> RequestedRoles { get; set; }

        public Request()
        {
            RequestedRoles = new HashSet<RequestedRole>();
        }
    }
}