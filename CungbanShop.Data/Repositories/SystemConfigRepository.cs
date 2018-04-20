using CungbanShop.Data.Infrastructure;
using CungbanShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CungbanShop.Data.Repositories
{
    public interface ISystemConfigRepository : IRepository<SystemConfig>
    {
    }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
