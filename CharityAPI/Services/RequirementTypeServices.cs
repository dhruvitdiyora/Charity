using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityAPI.IServices;
using CharityAPI.Models;

namespace CharityAPI.Services
{
    public class RequirementTypeServices : IRequirementTypeServices
    {
        private readonly CharityContext _context;
        public RequirementTypeServices(CharityContext context)
        {
            _context = context;
        }
        public void AddRequirementType(RequirementType requirementType)
        {
            _context.RequirementType.Add(requirementType);
            _context.SaveChanges();
        }

        public void DeleteRequirementType(int requirementTypeId)
        {
            var requirementType = _context.RequirementType
                .Where(s => s.RequirementTypeId == requirementTypeId)
                .SingleOrDefault();

            //context.EventVenues.Remove(eventVenue);
            requirementType.IsPublished = false;
            _context.SaveChanges();
        }

        public void EditRequirementType(RequirementType requirementType)
        {
            _context.RequirementType.Update(requirementType);
            _context.SaveChanges();
        }

        public IEnumerable GetRequirementType(int requirementTypeId)
        {
            var requirementType = _context.RequirementType.Where(x => x.IsPublished == true && x.RequirementTypeId == requirementTypeId);
            return requirementType;
        }

        public IEnumerable GetAllRequirementTypes()
        {
            var requirementTypes = _context.RequirementType.Where(x => x.IsPublished == true).ToList();
            return requirementTypes;
        }
    }
}
