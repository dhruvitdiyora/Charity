using CharityAPI.IServices;
using CharityAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityAPI.Services
{
    public class PostServices:IPostServices
    {
        private readonly CharityContext _context;
        public PostServices(CharityContext context)
        {
            _context = context;
        }

        //Get All Post Method
        public IEnumerable GetAllPost()
        {
            var post = _context.Post.Where(x => x.IsPublished == true);
            return post;
        }

        //Get Post by Postid
        public IEnumerable GetPostByPostId(int PostId)
        {
            var post = _context.Post.Where(x => x.IsPublished == true && x.PostId == PostId);
            return post;
        }

        //Get Post by UserId
        public IEnumerable GetPostByUserId(int UserId)
        {
            var post = _context.Post.Where(x => x.IsPublished == true && x.UserId == UserId);
            return post;
        }

        //Get Post by RequirementTypeId
        public IEnumerable GetPostByRequirementTypeId(int RequirementTypeId)
        {
            var post = _context.Post.Where(x => x.IsPublished == true && x.RequirementTypeId == RequirementTypeId);
            return post;
        }

        //Get Post by CityId
        public IEnumerable GetPostByCityId(int CityId)
        {
            var post = _context.Post.Where(x => x.IsPublished == true && x.CityId == CityId);
            return post;
        }

        //Get Post by StateId
        public IEnumerable GetPostByStateId(int StateId)
        {
            var post = _context.Post.Where(x => x.IsPublished == true && x.StateId == StateId);
            return post;
        }

        //Get Post by PincodeId
        public IEnumerable GetPostByPincodeId(int PincodeId)
        {
            var post = _context.Post.Where(x => x.IsPublished == true && x.PincodeId == PincodeId);
            return post;
        }

        //Add Post
        public void CreatePost(Post post)
        {
            _context.Post.Add(post);
            _context.SaveChanges();
        }

        //Delete Post
        public void DeletePost(int PostId)
        {
            var post = _context.Post
                .Where(s => s.PostId == PostId)
                .SingleOrDefault();


            post.IsPublished = false;
            _context.SaveChanges();
        }

        //Edit Post
        public void EditPost(Post post)
        {
            _context.Post.Update(post);
            _context.SaveChanges();
        }

    }
}
