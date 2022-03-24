using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Entites.Concrete
{
  public  class About
    {
        [Key]
        public int AboutID { get; set; }
        public string Title { get; set; } = "Batu";
        public string Desc { get; set; }
        public string Age { get; set; } = "24";
        public string Mail { get; set; } = "batuerkenn@gmail.com";
        public string Phone { get; set; } = "+905345106219";
        public string Adress { get; set; }
        public string ImageUrl { get; set; }
    }
}
