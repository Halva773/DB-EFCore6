using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibaryV1._0.Modules
{
    public class Book
    {
        public Author author { get; set; }
        public string name { get; set; }
        public int year { get; set; }
    }
}
