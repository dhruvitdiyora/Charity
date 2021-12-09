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
    public class PincodeController : ControllerBase
    {
        private readonly IPincodeServices _pincodeServices;

        public PincodeController(IPincodeServices pincodeServices)
        {
            _pincodeServices = pincodeServices;
        }

        //Get Apis

        //Get all pincode
        // GET: api/pincode
        [HttpGet]
        public ActionResult<IEnumerable<Pincode>> GetPincode()
        {
            return Ok(_pincodeServices.GetAllPincode());
        }


        //Get pincode by pincode id
        // GET: api/pincode/pincodeid
        [HttpGet("{PincodeId}")]
        public ActionResult<Pincode> GetPincodeByPincodeId(int PincodeId)
        {
            var pincode = _pincodeServices.GetPincodeByPincodeId(PincodeId);

            if (pincode == null)
            {
                return NotFound();
            }

            return Ok(pincode);
        }

        //Get pincode by city id 
        // GET: api/pincode/city/cityid
        [HttpGet("city/{PostId}")]
        public ActionResult<Pincode> GetPincodeByCityId(int CityId)
        {
            var pincode = _pincodeServices.GetPincodeByCityId(CityId);

            if (pincode == null)
            {
                return NotFound();
            }

            return Ok(pincode);
        }

        //Get pincode by state id 
        // GET: api/pincode/state/stateid
        [HttpGet("state/{StateId}")]
        public ActionResult<Pincode> GetPincodeByStateId(int StateId)
        {
            var pincode = _pincodeServices.GetPincodeByStateId(StateId);

            if (pincode == null)
            {
                return NotFound();
            }

            return Ok(pincode);
        }

        //Get pincode by postoffice name 
        // GET: api/pincode/postoffice/postofficeName
        [HttpGet("postoffice/{StateId}")]
        public ActionResult<Pincode> GetPincodeByPostOfficeName(string PostofficeName)
        {
            var pincode = _pincodeServices.GetPincodeByPostOfficeName(PostofficeName);

            if (pincode == null)
            {
                return NotFound();
            }

            return Ok(pincode);
        }

        //Get pincode by district name 
        // GET: api/pincode/district/districtname
        [HttpGet("district/{StateId}")]
        public ActionResult<Pincode> GetPincodeByDistric(string District)
        {
            var pincode = _pincodeServices.GetPincodeByDistric(District);

            if (pincode == null)
            {
                return NotFound();
            }

            return Ok(pincode);
        }

        //Get district by pincodeid 
        // GET: api/pincode/district/pincodeid
        [HttpGet("district/{PincodeId}")]
        public ActionResult<Pincode> GetDistrictByPincodeId(int PincodeId)
        {
            var district = _pincodeServices.GetDistrictByPincodeId(PincodeId);

            if (district == null)
            {
                return NotFound();
            }

            return Ok(district);
        }




        //Post api
        // POST: api/pincode
        [HttpPost]
        //[Authorize(Roles = UserRoles.Admin)]
        public ActionResult<Pincode> AddUrgrncy(Pincode pincode)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _pincodeServices.AddPincode(pincode);

            return Ok();
        }

        // DELETE: api/pincode/pincodeid
        [HttpDelete("{PincodeId}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeletePincode(int PincodeId)
        {
            var urgency = _pincodeServices.GetPincodeByPincodeId(PincodeId);
            if (urgency != null)
            {
                _pincodeServices.DeletePincode(PincodeId);
                return Ok();
            }
            return NotFound();
        }

        // PUT: api/pincode/5
        [HttpPut("{PincodeId}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult EditPincode(int PincodeId, Pincode pincode)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            var stateObject = _pincodeServices.GetPincodeByPincodeId(PincodeId);
            if (stateObject != null)
            {
                _pincodeServices.EditPincode(pincode);
                return Ok();
            }
            return NotFound();
        }
    }
}
