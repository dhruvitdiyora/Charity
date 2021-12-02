using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CharityAPI.Models
{
    public partial class CharityEvent
    {
        public long EventId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public long EventOrganiserId { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public bool IsVerified { get; set; }
        public string EventType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public long PincodeId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? IsPublished { get; set; }
        public bool IsCompleted { get; set; }

        public virtual UserData EventOrganiser { get; set; }
        public virtual Pincode Pincode { get; set; }
    }
}
