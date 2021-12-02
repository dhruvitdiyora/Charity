using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityAPI.Models;

namespace CharityAPI.IServices
{
    public interface IStateServices
    {
        public IEnumerable GetAllStates();
        public IEnumerable GetById(int stateId);
        public void AddState(States state);
        public void EditState(States state);
        public void Deletestate(int cityId);
    }
}
