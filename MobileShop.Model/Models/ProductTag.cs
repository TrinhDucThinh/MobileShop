using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key, Column(Order =0)]
        public int ProductID { get; set; }

        [Key,Column(Order=1)]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}