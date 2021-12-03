using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityAPI.IServices;
using CharityAPI.Models;

namespace CharityAPI.Services
{
    public class ModuleServices : IModuleServices
    {
        private readonly CharityContext _context;
        public ModuleServices(CharityContext context)
        {
            _context = context;
        }
        public void AddModule(Module module)
        {
            _context.Module.Add(module);
            _context.SaveChanges();
        }

        public void DeleteModule(int moduleId)
        {
            var module = _context.Module
                .Where(s => s.ModuleId == moduleId)
                .SingleOrDefault();

            //context.EventVenues.Remove(eventVenue);
            module.IsPublished = false;
            _context.SaveChanges();
        }

        public void EditModule(Module module)
        {
            _context.Module.Update(module);
            _context.SaveChanges();
        }

        public IEnumerable GetModule(int moduleId)
        {
            var module = _context.Module.Where(x => x.IsPublished == true && x.ModuleId == moduleId);
            return module;
        }

        public IEnumerable GetAllModules()
        {
            var modules = _context.Module.Where(x => x.IsPublished == true).ToList();
            return modules;
        }
    }
}
