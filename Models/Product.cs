using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_CNPM.Models
{
    public class Product
    {
        [Key]
        public int ProductCode { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime EntryDay { get; set; }
        public string ProductType { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
        public string ImageLink { get; set; }
        public int QuantityInStock { get; set; }
    }
}
