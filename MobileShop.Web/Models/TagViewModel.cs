using System.Collections.Generic;

namespace MobileShop.Web.Models
{
    public class TagViewModel
    {
        
      
        public string ID { get; set; }

        public string Name { get; set; }

       
        public string Type { get; set; }

        public virtual IEnumerable<PostTagViewModel> PostTags { set; get; }

        public virtual IEnumerable<ProductTagViewModel> ProductTags { set; get; }
    }
}