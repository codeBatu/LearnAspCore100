using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Batu.Entites.Concrete
{
   public class MainPage
    {
        [Key]
        public int MainPageID { get; set; }
        public string   Header  { get; set; }
        public string   Name  { get; set; }
        public string  Title  { get; set; }
    }
}
