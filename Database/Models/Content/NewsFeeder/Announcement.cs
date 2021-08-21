using System;
using Database.Models.Content.HumanResources;

namespace Database.Models.Content.NewsFeeder
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Article { get; set; }
        public DateTime DateTimeUtc { get; set; }
        public int? CreatedById { get; set; }
        public virtual Employee CreatedBy { get; set; }
    }
}