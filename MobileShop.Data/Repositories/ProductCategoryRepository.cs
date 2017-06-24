using MobileShop.Data.Infrastructure;
using MobileShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobileShop.Data.Repositories
{
    public interface IProductCategoryRepository: IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);

        ProductCategory GetByFistAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }

        public ProductCategory GetByFistAlias(string alias)
        {
            return this.DbContext.ProductCategories.FirstOrDefault(x => x.Alias == alias);
        }
    }
}