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
    public class RequirementTypeController : ControllerBase
    {
        private readonly IRequirementTypeServices _requirementTypeServices;
        public RequirementTypeController(IRequirementTypeServices requirementTypeServices)
        {
            _requirementTypeServices = requirementTypeServices;
        }
        // GET: api/state
        [HttpGet]
        public ActionResult<IEnumerable<RequirementType>> GetRequirementTypes()
        {
            return Ok(_requirementTypeServices.GetAllRequirementTypes());
        }
        [HttpGet("{id}")]
        public ActionResult<RequirementType> GetRequirementType(int id)
        {
            var requirementType = _requirementTypeServices.GetRequirementType(id);

            if (requirementType == null)
            {
                return NotFound();
            }

            return Ok(requirementType);
        }
        // PUT: api/state/5
        [HttpPut("{id}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult EditRequirementType(int id, RequirementType requirementType)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            var requirementTypeObject = _requirementTypeServices.GetRequirementType(id);
            if (requirementTypeObject != null)
            {
                _requirementTypeServices.EditRequirementType(requirementType);
                return Ok();
            }
            return NotFound();


        }

        // POST: api/state
        [HttpPost]
        //[Authorize(Roles = UserRoles.Admin)]
        public ActionResult<RequirementType> AddRequirementType(RequirementType requirementType)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _requirementTypeServices.AddRequirementType(requirementType);

            return Ok();
        }

        // DELETE: api/state/id
        [HttpDelete("{id}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteRequirementType(int id)
        {
            var requirementTypeObject = _requirementTypeServices.GetRequirementType(id);
            if (requirementTypeObject != null)
            {
                _requirementTypeServices.DeleteRequirementType(id);
                return Ok();
            }
            return NotFound();
        }
    }
}

