using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Batu.Entites.Concrete
{
  public  class MessageEntity
    {
        [Key]
        public int MessageEntityID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Contact { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
