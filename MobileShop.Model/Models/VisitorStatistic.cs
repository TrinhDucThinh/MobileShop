using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity]
        public int ID { get; set; }

        [Required]
        public DateTime VisitedDate { get; set; }

        [MaxLength(50)]
        public  string IPAddress { get; set; }
    }
}
