using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO.App.Models
{
    public class Kontak
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nama { get; set; }
        public string email { get; set; }
        public string no_hp { get; set; }
    }

}
