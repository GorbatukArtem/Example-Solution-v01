using Database.Models.Security.Authorization;
using System;

namespace Database.Models.Security.Access
{
    public class RequestedRole
    {
        public int Id { get; set; }
        public int? RequestId { get; set; }
        public int? RoleId { get; set; }
        public int? RequestTypeId { get; set; }
        public int? RequestStatusId { get; set; }
        public string Reason { get; set; }
        public int? ApproverId { get; set; }
        public DateTime? ProcessedUtc { get; set; }

        public virtual Request Request { get; set; }
        public virtual Role Role { get; set; }
        public virtual RequestType RequestType { get; set; }
        public virtual RequestStatus RequestStatus { get; set; }
        public virtual User Approver { get; set; }
    }
}