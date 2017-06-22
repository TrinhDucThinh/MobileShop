using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string MyProperty { get; set; }

        public string Content { get; set; }
    }
}
