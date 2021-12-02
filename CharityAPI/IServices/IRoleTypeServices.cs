using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityAPI.Models;

namespace CharityAPI.IServices
{
    public interface IRoleTypeServices
    {
        public IEnumerable GetAllRoleTypes();
        public IEnumerable GetRoleType(int roleTypeId);
        public void AddRoleType(RoleType roleType);
        public void EditRoleType(RoleType roleType);
        public void DeleteRoleType(int roleTypeId);
    }
}
