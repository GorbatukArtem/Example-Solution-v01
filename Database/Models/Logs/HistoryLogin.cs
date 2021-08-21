using System;
using Database.Models.Security.Authorization;

namespace Database.Models.Logs
{
    public class HistoryLogin
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateUtc { get; set; }

        public virtual User User { get; set; }
    }
}