using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CharityAPI.Models
{
    public partial class UserData
    {
        public UserData()
        {
            CharityEvent = new HashSet<CharityEvent>();
            ClusterLocations = new HashSet<ClusterLocations>();
            Organisation = new HashSet<Organisation>();
            Post = new HashSet<Post>();
            Roles = new HashSet<Roles>();
            Spam = new HashSet<Spam>();
            Urgency = new HashSet<Urgency>();
            Volunteer = new HashSet<Volunteer>();
        }

        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string ProfileImage { get; set; }
        public string UserDescription { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
        public long MobileNo { get; set; }
        public long TotalPostCount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? IsPublished { get; set; }
        public bool IsOrganisation { get; set; }
        public bool? IsVerified { get; set; }
        public long CityId { get; set; }
        public long StateId { get; set; }
        public long PincodeId { get; set; }

        public virtual Cities City { get; set; }
        public virtual Pincode Pincode { get; set; }
        public virtual States State { get; set; }
        public virtual ICollection<CharityEvent> CharityEvent { get; set; }
        public virtual ICollection<ClusterLocations> ClusterLocations { get; set; }
        public virtual ICollection<Organisation> Organisation { get; set; }
        public virtual ICollection<Post> Post { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<Spam> Spam { get; set; }
        public virtual ICollection<Urgency> Urgency { get; set; }
        public virtual ICollection<Volunteer> Volunteer { get; set; }
    }
}
