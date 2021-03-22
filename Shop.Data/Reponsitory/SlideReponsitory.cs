using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Reponsitory
{
    class SlideReponsitory : RepositoryBase<Slide>
    {
        public SlideReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
