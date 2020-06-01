using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LibaryV1._0.Modules
{
    public class Author
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string middleName { get; set; }
        public int born { get; set; }
    }
}
