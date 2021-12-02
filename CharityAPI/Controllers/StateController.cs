using CharityAPI.IServices;
using CharityAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateServices _stateServices;
        public StateController(IStateServices stateServices)
        {
            _stateServices = stateServices;
        }
        // GET: api/state
        [HttpGet]
        public ActionResult<IEnumerable<States>> GetStates()
        {
            return Ok(_stateServices.GetAllStates());
        }
        [HttpGet("{id}")]
        public ActionResult<States> GetState(int id)
        {
            var state = _stateServices.GetById(id);

            if (state == null)
            {
                return NotFound();
            }

            return Ok(state);
        }
        // PUT: api/state/5
        [HttpPut("{id}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult EditState(int id, States state)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            var stateObject = _stateServices.GetById(id);
            if (stateObject != null)
            {
                _stateServices.EditState(state);
                return Ok();
            }
            return NotFound();


        }

        // POST: api/state
        [HttpPost]
        //[Authorize(Roles = UserRoles.Admin)]
        public ActionResult<States> AddState(States state)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _stateServices.AddState(state);

            return   Ok();
        }

        // DELETE: api/state/id
        [HttpDelete("{id}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteState(int id)
        {
            var stateObject = _stateServices.GetById(id);
            if (stateObject != null)
            {
                _stateServices.Deletestate(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
