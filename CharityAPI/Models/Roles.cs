using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CharityAPI.Models
{
    public partial class Roles
    {
        public long RolePermissionId { get; set; }
        public long RoleTypeId { get; set; }
        public long UserId { get; set; }
        public long ModuleId { get; set; }
        public bool IsPermissionAdd { get; set; }
        public bool IsPermissionEdit { get; set; }
        public bool IsPermissionView { get; set; }
        public bool IsPermissionDelete { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? IsPublished { get; set; }

        public virtual Module Module { get; set; }
        public virtual RoleType RoleType { get; set; }
        public virtual UserData User { get; set; }
    }
}
