using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string MyProperty { get; set; }

        [MaxLength(50)]
        public string Department { get; set; }

        [MaxLength(50)]
        public string Skype { get; set; }

        [Required]
        public bool Status { get; set; }

        public int? DisplayOrder { get; set; }


    }
}