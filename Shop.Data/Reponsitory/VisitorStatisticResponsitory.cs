using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Reponsitory
{
    public class VisitorStatisticResponsitory: RepositoryBase<VisitorStatistic>
    {
        public VisitorStatisticResponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
