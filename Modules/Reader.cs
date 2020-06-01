using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LibaryV1._0.Modules
{
    public class Reader
    {
        public User user { get; set; }
        public Book book { get; set; }
        public int page { get; set; }
    }
}
