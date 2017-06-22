using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.Model.Abstract
{
    public class Auditable : IAuditable
    {

        public  DateTime CreatedDate { set; get; }

        public  string CreatedBy { set; get; }

        public DateTime UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        [Required]
        public bool Status { set; get; }

    }
}
