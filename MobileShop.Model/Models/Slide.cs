using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Model.Models
{
    [Table("Slide")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }

        [Required]
        [MaxLength(256)]
        public string Image { get; set; }

        [MaxLength(256)]
        public string Url { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public bool Status { get; set; }

        public string Content { get; set; }
    }
}
