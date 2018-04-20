using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CungbanShop.Data.Infrastructure;
using CungbanShop.Model.Models;


namespace CungbanShop.Data.Repositories
{
    class ProductRepository : RepositoryBase<Product>
    {
        protected ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
