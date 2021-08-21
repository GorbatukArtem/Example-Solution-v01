using System;
using System.Collections.Generic;
using Database.Models.Content.HumanResources;

namespace Database.Models.Content.LabourSafety
{
    public class Permit
    {
        public int Id { get; set; }
        public DateTime DateTimeUtc { get; set; }

        public int PermitTypeId { get; set; }
        public int IssuerId { get; set; }
        public int RecipientId { get; set; }
        
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }


        public PermitType PermitType { get; set; }
        public Employee Issuer { get; set; }
        public Employee Recipient { get; set; }

        public ICollection<PermitItem> PermitItems { get; set; }

        public Permit()
        {
            PermitItems = new HashSet<PermitItem>();;
        }
    }
}