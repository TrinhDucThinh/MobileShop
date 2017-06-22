using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        public int GroupID { get; set; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }

        public string Target { get; set; }

        public bool Status { get; set; }
    }
}
