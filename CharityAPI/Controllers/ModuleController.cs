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
    public class ModuleController : ControllerBase
    {
        private readonly IModuleServices _moduleServices;
        public ModuleController(IModuleServices moduleServices)
        {
            _moduleServices = moduleServices;
        }
        // GET: api/state
        [HttpGet]
        public ActionResult<IEnumerable<Module>> GetModules()
        {
            return Ok(_moduleServices.GetAllModules());
        }

        [HttpGet("{id}")]
        public ActionResult<Module> GetModule(int id)
        {
            var module = _moduleServices.GetModule(id);

            if (module == null)
            {
                return NotFound();
            }

            return Ok(module);
        }
        // PUT: api/state/5
        [HttpPut("{id}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult EditModule(int id, Module module)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            var moduleObject = _moduleServices.GetModule(id);
            if (moduleObject != null)
            {
                _moduleServices.EditModule(module);
                return Ok();
            }
            return NotFound();
        }

        // POST: api/state
        [HttpPost]
        //[Authorize(Roles = UserRoles.Admin)]
        public ActionResult<Module> AddModule(Module module)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _moduleServices.AddModule(module);

            return Ok();
        }

        // DELETE: api/state/id
        [HttpDelete("{id}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteModule(int id)
        {
            var moduleObject = _moduleServices.GetModule(id);
            if (moduleObject != null)
            {
                _moduleServices.DeleteModule(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
