using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CungbanShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private CungbanShopDbContext dbContext;

        public CungbanShopDbContext Init()
        {
            return dbContext ?? (dbContext = new CungbanShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
