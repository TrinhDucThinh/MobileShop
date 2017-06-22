using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key, Column(Order = 0)]
        public int OrderID { get; set; }

        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        [Required]
        public int Quanitty { get; set; }

        [Required]
        public decimal Price { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}