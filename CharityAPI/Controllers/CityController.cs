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
    public class CityController : ControllerBase
    {
        private readonly ICityServices _cityServices;
        public CityController(ICityServices cityServices)
        {
            _cityServices = cityServices;
        }
        // GET: api/City
        [HttpGet]
        public ActionResult<IEnumerable<Cities>> GetCities()
        {
            return Ok(_cityServices.GetAllCities());
        }

        [HttpGet("{id}")]
        public ActionResult<Cities> GetCity(int id)
        {
            var city = _cityServices.GetCityById(id);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }
        [HttpGet("states/{id}")]
        public ActionResult<Cities> GetCityByState(int id)
        {
            var city = _cityServices.GetByStateId(id);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

        // PUT: api/City/5
        [HttpPut("{id}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult PutCity(int id, Cities city)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            var cityObject = _cityServices.GetCityById(id);
            if (cityObject != null)
            {
                _cityServices.EditCity(city);
                return Ok();
            }
            return NotFound();

            
        }

        // POST: api/City
        [HttpPost]
        //[Authorize(Roles = UserRoles.Admin)]
        public ActionResult<Cities> AddCity(Cities city)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _cityServices.AddCity(city);

            return Ok();
        }

        // DELETE: api/City/id
        [HttpDelete("{id}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteCity(int id)
        {
            var cityObject = _cityServices.GetCityById(id);
            if (cityObject != null)
            {
                _cityServices.DeleteCity(id);
                return Ok();
            }
            return NotFound();
        }

    }
}
