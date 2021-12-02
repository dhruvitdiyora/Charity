using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityAPI.IServices;
using CharityAPI.Models;

namespace WebAPI.Services
{
    public class RoleTypeServices : IRoleTypeServices
    {
        private readonly CharityContext _context;
        public RoleTypeServices(CharityContext context)
        {
            _context = context;
        }
        public void AddRoleType(RoleType roleType)
        {
            _context.RoleType.Add(roleType);
            _context.SaveChanges();
        }

        public void DeleteRoleType(int roleTypeId)
        {
            var roleType = _context.RoleType
                .Where(s => s.RoleTypeId == roleTypeId)
                .SingleOrDefault();

            //context.EventVenues.Remove(eventVenue);
            roleType.IsPublished = false;
            _context.SaveChanges();
        }

        public void EditRoleType(RoleType roleType)
        {
            _context.RoleType.Update(roleType);
            _context.SaveChanges();
        }

        public IEnumerable GetRoleType(int roleTypeId)
        {
            var roleType = _context.RoleType.Where(x => x.IsPublished == true && x.RoleTypeId == roleTypeId);
            return roleType;
        }

        public IEnumerable GetAllRoleType()
        {
            var roleTypes = _context.RoleType.Where(x => x.IsPublished == true).ToList();
            return roleTypes;
        }
    }
}
