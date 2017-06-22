using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileShop.Model.Models
{
    [Table("Feedbacks")]
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MyProperty { get; set; }
        
        [Required]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Email { get; set; }

        [Required]
        [MaxLength(256)]
        public string Message { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}