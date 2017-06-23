using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Data.Infrastructure
{
    public class DbFactory: Disposable,IDbFactory
    {
        private MobileShopDbContext dbContext;

        public MobileShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MobileShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
