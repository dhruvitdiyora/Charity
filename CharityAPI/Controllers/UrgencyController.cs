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
    public class UrgencyController : ControllerBase
    {
        private readonly IUrgencyServices _urgencyServices;
        public UrgencyController(IUrgencyServices urgencyServices)
        {
            _urgencyServices = urgencyServices;
        }

        //Get Apis

        //Get all urgency
        // GET: api/urgency
        [HttpGet]
        public ActionResult<IEnumerable<Urgency>> GetUrgencys()
        {
            return Ok(_urgencyServices.GetAllUrgency());
        }

        //Get urgency by urgency id
        // GET: api/urgency/urgencyid
        [HttpGet("{Urgencyid}")]
        public ActionResult<Urgency> GetUrgency(int Urgencyid)
        {
            var urgency = _urgencyServices.GetUrgencyByUrgencyId(Urgencyid);

            if (urgency == null)
            {
                return NotFound();
            }

            return Ok(urgency);
        }

        //Get urgency by post id 
        // GET: api/urgency/postid
        [HttpGet("post/{PostId}")]
        public ActionResult<Urgency> GetCityByPostId(int PostId)
        {
            var urgency = _urgencyServices.GetUrgencyByPostId(PostId);

            if (urgency == null)
            {
                return NotFound();
            }

            return Ok(urgency);
        }

        //Get urgency by user id 
        // GET: api/urgency/userid
        [HttpGet("user/{UserId}")]
        public ActionResult<Urgency> GetCityByUserId(int UserId)
        {
            var urgency = _urgencyServices.GetUrgencyByPostId(UserId);

            if (urgency == null)
            {
                return NotFound();
            }

            return Ok(urgency);
        }

        //Post api
        // POST: api/urgency
        [HttpPost]
        //[Authorize(Roles = UserRoles.Admin)]
        public ActionResult<Cities> AddUrgrncy(Urgency urgency)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _urgencyServices.AddUrgency(urgency);

            return Ok();
        }


        // DELETE: api/urgency/urgencyid
        [HttpDelete("{Urgencyid}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteCity(int Urgencyid)
        {
            var urgency = _urgencyServices.GetUrgencyByUrgencyId(Urgencyid);
            if (urgency != null)
            {
                _urgencyServices.DeleteUrgency(Urgencyid);
                return Ok();
            }
            return NotFound();
        }
    }
}
