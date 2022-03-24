using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Batu.Entites.Concrete
{
  public  class PortfolioEntity
    {[Key]
        public  int PortfolioEntityID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
