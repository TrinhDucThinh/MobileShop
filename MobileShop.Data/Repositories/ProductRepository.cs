using MobileShop.Data.Infrastructure;
using MobileShop.Model.Models;

namespace MobileShop.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }
    }
}