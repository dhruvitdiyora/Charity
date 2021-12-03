using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityAPI.Models;

namespace CharityAPI.IServices
{
    public interface IRequirementTypeServices
    {
        public IEnumerable GetAllRequirementTypes();
        public IEnumerable GetRequirementType(int requirementTypeId);
        public void AddRequirementType(RequirementType requirementType);
        public void EditRequirementType(RequirementType requirementType);
        public void DeleteRequirementType(int requirementTypeId);
    }
}
