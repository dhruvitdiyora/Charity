using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityAPI.IServices;
using CharityAPI.Models;

namespace CharityAPI.Services
{
    public class StateServices : IStateServices
    {
        private readonly CharityContext _context;
        public StateServices(CharityContext context)
        {
            _context = context;
        }
        public void AddState(States state)
        {
            _context.States.Add(state);
            _context.SaveChanges();
        }

        public void Deletestate(int stateId)
        {
            var state = _context.States
                .Where(s => s.StateId == stateId)
                .SingleOrDefault();

            //context.EventVenues.Remove(eventVenue);
            state.IsPublished = false;
            _context.SaveChanges();
        }

        public void EditState(States state)
        {
            _context.States.Update(state);
            _context.SaveChanges();
        }

        public IEnumerable GetById(int stateId)
        {
            var state = _context.States.Where(x => x.IsPublished == true && x.StateId == stateId);
            return state;
        }

        public IEnumerable GetAllStates()
        {
            var states = _context.States.Where(x => x.IsPublished == true);
            return states;
        }
    }
}
