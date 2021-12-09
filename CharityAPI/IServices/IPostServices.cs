using CharityAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityAPI.IServices
{
    public interface IPostServices
    {
        public IEnumerable GetAllPost();
        
        public IEnumerable GetPostByPostId(int PostId);
         
        public IEnumerable GetPostByUserId(int UserId);
        
        public IEnumerable GetPostByRequirementTypeId(int RequirementTypeId);

        public IEnumerable GetPostByCityId(int CityId);

        public IEnumerable GetPostByStateId(int StateId);

        public IEnumerable GetPostByPincodeId(int PincodeId);

        public void CreatePost(Post post);

        public void EditPost(Post post);

        public void DeletePost(int PostId);
    }
}
