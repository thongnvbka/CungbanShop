using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CungbanShop.Data.Infrastructure
{
   public interface IDbFactory : IDisposable
    {
        CungbanShopDbContext Init();
        
    }
}
