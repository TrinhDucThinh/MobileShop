using MobileShop.Data.Infrastructure;
using MobileShop.Model.Models;

namespace MobileShop.Data.Repositories
{
    public class PageRepository : RepositoryBase<Page>
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}