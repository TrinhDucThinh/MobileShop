using MobileShop.Data.Infrastructure;
using MobileShop.Model.Models;

namespace MobileShop.Data.Repositories
{
    public class SystemConfigRepository : RepositoryBase<SystemConfig>
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}