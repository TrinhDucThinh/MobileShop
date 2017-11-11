using MobileShop.Data.Infrastructure;
using MobileShop.Model.Models;

namespace MobileShop.Data.Repositories
{
    interface IMenuGroupRepository : IRepository<MenuGroup>
    {

    }


    public class MenuGroupRepository : RepositoryBase<MenuGroup>,IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}