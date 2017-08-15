using System.Collections.Generic;
using System.Linq;

namespace MobileShop.Web.Infrastructure.Core
{
    public class PaginationSet<T>
    {
        public int Count
        {
            get
            {
                return (Items != null) ? Items.Count() : 0;
            }
        }

        public int Page { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public int MaxPage { set; get; }
        public IEnumerable<T> Items { get; set; }
    }
}