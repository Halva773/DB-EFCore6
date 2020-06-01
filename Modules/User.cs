using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibaryV1._0.Modules
{
    public class User
    { 
        public int ID { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
