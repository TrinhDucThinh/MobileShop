using MobileShop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MobileShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        [Column(TypeName ="xml")]
        public string MoreImages { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int? Warranty { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool HotFlag { get; set; }

        public int? ViewCount { get; set; }

        public string Tags { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int OriginalPrice { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }
         
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}