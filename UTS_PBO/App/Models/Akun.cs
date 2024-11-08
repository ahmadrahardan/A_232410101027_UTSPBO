﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO.App.Models
{
    public class Akun
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        public string password { get; set; }
    }
}
