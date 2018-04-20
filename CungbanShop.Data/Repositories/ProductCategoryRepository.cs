using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CungbanShop.Data.Infrastructure;
using CungbanShop.Model.Models;


namespace CungbanShop.Data.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        protected ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
    
}
