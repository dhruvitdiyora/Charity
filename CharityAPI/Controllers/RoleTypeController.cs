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
    public class RoleTypeController : ControllerBase
    {
        private readonly IRoleTypeServices _roleTypeServices;
        public RoleTypeController(IRoleTypeServices roleTypeServices)
        {
            _roleTypeServices = roleTypeServices;
        }
        // GET: api/state
        [HttpGet]
        public ActionResult<IEnumerable<RoleType>> GetRoleTypes()
        {
            return Ok(_roleTypeServices.GetAllRoleTypes());
        }
        [HttpGet("{id}")]
        public ActionResult<RoleType> GetRoleType(int id)
        {
            var state = _roleTypeServices.GetRoleType(id);

            if (state == null)
            {
                return NotFound();
            }

            return Ok(state);
        }
        // PUT: api/state/5
        [HttpPut("{id}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult EditRoleType(int id, RoleType roleType)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            var roleTypeObject = _roleTypeServices.GetRoleType(id);
            if (roleTypeObject != null)
            {
                _roleTypeServices.EditRoleType(roleType);
                return Ok();
            }
            return NotFound();


        }

        // POST: api/state
        [HttpPost]
        //[Authorize(Roles = UserRoles.Admin)]
        public ActionResult<RoleType> AddRoleType(RoleType roleType)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _roleTypeServices.AddRoleType(roleType);

            return Ok();
        }

        // DELETE: api/state/id
        [HttpDelete("{id}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteRoleType(int id)
        {
            var roleTypeObject = _roleTypeServices.GetRoleType(id);
            if (roleTypeObject != null)
            {
                _roleTypeServices.DeleteRoleType(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
