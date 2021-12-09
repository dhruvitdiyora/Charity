using CharityAPI.IServices;
using CharityAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityAPI.Services
{
    public class UrgencyServices : IUrgencyServices
    {
        private readonly CharityContext _context;
        public UrgencyServices(CharityContext context)
        {
            _context = context;
        }
        //Get all urgency method
        public IEnumerable GetAllUrgency()
        {
            var urgency = _context.Urgency.Where(x => x.IsPublished == true);
            return urgency;
        }

        //Get urgency by urgencyid
        public IEnumerable GetUrgencyByUrgencyId(int UrgencyId)
        {
            var urgency = _context.Urgency.Where(x => x.IsPublished == true && x.UrgencyId == UrgencyId);
            return urgency;
        }

        //Get urgency by postid
        public IEnumerable GetUrgencyByPostId(int PostId)
        {
            var urgency = _context.Urgency.Where(x => x.IsPublished == true && x.PostId == PostId);
            return urgency;
        }

        //get urgency by userid
        public IEnumerable GetUrgencyByUserId(int UserId)
        {
            var urgency = _context.Urgency.Where(x => x.IsPublished == true && x.UserId == UserId);
            return urgency;
        }
        //add urgency
        public void AddUrgency(Urgency urgency)
        {
            _context.Urgency.Add(urgency);
            _context.SaveChanges();
        }
        
        //delete urgency
        public void DeleteUrgency(int UrgencyId)
        {
            var urgency = _context.Urgency
                .Where(s => s.UrgencyId == UrgencyId)
                .SingleOrDefault();

   
            urgency.IsPublished = false;
            _context.SaveChanges();
        }
        
        //edit urgency
        public void EditUrgency(Urgency urgency)
        {
            _context.Urgency.Update(urgency);
            _context.SaveChanges();
        }



    }
}

