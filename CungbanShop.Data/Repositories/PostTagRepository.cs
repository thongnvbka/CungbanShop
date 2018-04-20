using CungbanShop.Data.Infrastructure;
using CungbanShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CungbanShop.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
    }

    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
