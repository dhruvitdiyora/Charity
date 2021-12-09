using CharityAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityAPI.IServices
{
    public interface IUrgencyServices
    {
        public IEnumerable GetAllUrgency();
        public IEnumerable GetUrgencyByUrgencyId(int UrgencyId);
        public IEnumerable GetUrgencyByPostId(int PostId);
        public IEnumerable GetUrgencyByUserId(int UserId);
        public void AddUrgency(Urgency urgency);
        public void EditUrgency(Urgency urgency);
        public void DeleteUrgency(int UrgencyId);
    }
}
