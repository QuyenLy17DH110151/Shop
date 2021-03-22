using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Reponsitory
{
    public interface IProductCategoryReponsitory
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryReponsitory : RepositoryBase<ProductCategory>,IProductCategoryReponsitory
    {
        public ProductCategoryReponsitory(IDbFactory dbFactory):base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
