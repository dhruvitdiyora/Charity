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
    public class PostController : ControllerBase
    {
        private readonly IPostServices _postServices;

        public PostController(IPostServices postServices)
        {
            _postServices = postServices;
        }

        //Get All Posts
        // GET: api/post
        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetPosts()
        {
            return Ok(_postServices.GetAllPost());
        }

        //Get Post by Post id
        // GET: api/post/postid
        [HttpGet("{PostId}")]
        public ActionResult<Post> GetPost(int PostId)
        {
            var post = _postServices.GetPostByPostId(PostId);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        //Get Post by User id
        // GET: api/post/userid
        [HttpGet("user/{UserId}")]
        public ActionResult<Post> GetPostByUserId(int UserId)
        {
            var post = _postServices.GetPostByUserId(UserId);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        //Get Post by Requirement Type id
        // GET: api/post/requirementtypeid
        [HttpGet("requirementtype/{RequirementTypeId}")]
        public ActionResult<Post> GetPostByRequirementTypeId(int RequirementTypeId)
        {
            var post = _postServices.GetPostByRequirementTypeId(RequirementTypeId);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        //Get Post by City id
        // GET: api/post/cityid
        [HttpGet("city/{CityId}")]
        public ActionResult<Post> GetPostByCityId(int CityId)
        {
            var post = _postServices.GetPostByCityId(CityId);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        //Get Post by State id
        // GET: api/post/requirementtypeid
        [HttpGet("{StateId}")]
        public ActionResult<Post> GetPostByStateId(int StateId)
        {
            var post = _postServices.GetPostByStateId(StateId);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        //Get Post by Pincode id
        // GET: api/post/pincodeid
        [HttpGet("pincode/{PincodeId}")]
        public ActionResult<Post> GetPostByPincodeId(int PincodeId)
        {
            var post = _postServices.GetPostByPincodeId(PincodeId);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        //Post api
        // POST: api/post
        [HttpPost]
        public ActionResult<Cities> CreatePost(Post post)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _postServices.CreatePost(post);

            return Ok();
        }

        // DELETE: api/urgency/urgencyid
        [HttpDelete("{PostId}")]
        public IActionResult DeletePost(int PostId)
        {
            var post = _postServices.GetPostByPostId(PostId);
            if (post != null)
            {
                _postServices.DeletePost(PostId);
                return Ok();
            }
            return NotFound();
        }

        // PUT: api/POST/5
        [HttpPut("{PostId}")]
        //[Authorize(Roles = UserRoles.Admin)]
        public IActionResult EditPincode(int PostId, Post post)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            var stateObject = _postServices.GetPostByPostId(PostId);
            if (stateObject != null)
            {
                _postServices.EditPost(post);
                return Ok();
            }
            return NotFound();
        }

    }
}
