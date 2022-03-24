using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Batu.Entites.Concrete
{
   public class ContactEntity
    {[Key]
        public int ContactEntityID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; } = "+905345106219";
    }
}
