using MobileShop.Data.Infrastructure;
using MobileShop.Model.Models;

namespace MobileShop.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post>
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}