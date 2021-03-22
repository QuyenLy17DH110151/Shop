using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Reponsitory
{
    public class MenuGroupReponsitory : RepositoryBase<MenuGroup>
    {
        public MenuGroupReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
