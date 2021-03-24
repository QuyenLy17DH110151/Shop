using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Reponsitory
{
    public interface IPostCategoryReponsitory : IRepository<PostCategory>
    {

    }
    public class PostCategoryReponsitory : RepositoryBase<PostCategory>, IPostCategoryReponsitory
    {
        public PostCategoryReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
