using POSProfessional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSProfessional.Repositories
{
    public interface authRepository
    {
       
            Task<List<Category>> GetCategories();

            //Task<PostViewModel> GetPost(int? postId);

            //Task<int> AddPost(Post post);

            //Task<int> DeletePost(int? postId);

            //Task UpdatePost(Post post);
        
    }
}
