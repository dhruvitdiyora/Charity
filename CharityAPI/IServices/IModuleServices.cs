using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityAPI.Models;

namespace CharityAPI.IServices
{
    public interface IModuleServices
    {
        public IEnumerable GetAllModules();
        public IEnumerable GetModule(int moduleId);
        public void AddModule(Module module);
        public void EditModule(Module module);
        public void DeleteModule(int moduleId);
    }
}
