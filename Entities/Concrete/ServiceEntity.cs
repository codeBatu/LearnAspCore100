using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Batu.Entites.Concrete
{
   public class ServiceEntity
    {
        [Key]
        public int ServiceEntityID { get; set; }
        public string Title { get; set; }
        public string Title2 { get; set; } = "";
        public string ImageUrl { get; set; }
    }
}
