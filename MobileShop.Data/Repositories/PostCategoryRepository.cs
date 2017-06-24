using MobileShop.Data.Infrastructure;
using MobileShop.Model.Models;

namespace MobileShop.Data.Repositories
{
    public class PostCategoryRepository : RepositoryBase<PostCategory>
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}