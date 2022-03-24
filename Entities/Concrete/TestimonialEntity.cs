using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Batu.Entites.Concrete
{
  public  class TestimonialEntity
    {
        [Key]
        public int TestimonialEntityID { get; set; }
        public string ClientName { get; set; }
        public string Cmd { get; set; }
        public string ImageUrl { get; set; }
        public string Company { get; set; }
    }
}
