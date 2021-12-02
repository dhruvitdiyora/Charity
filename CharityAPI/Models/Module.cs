using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CharityAPI.Models
{
    public partial class Module
    {
        public Module()
        {
            Roles = new HashSet<Roles>();
        }

        public long ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleType { get; set; }
        public bool? IsVerified { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? IsPublished { get; set; }

        public virtual ICollection<Roles> Roles { get; set; }
    }
}
