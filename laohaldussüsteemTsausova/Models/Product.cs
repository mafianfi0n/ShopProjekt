using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laohaldussüsteemTsausova.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Toode { get; set; }
        public string Tellija { get; set; }
        public string Koostaja { get; set; }
        public DateTime Aeg { get; set; }

    }
}