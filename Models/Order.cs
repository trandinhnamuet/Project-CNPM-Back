using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_CNPM.Models
{
    public class Order
    {
        [Key]
        public int OrderCode { get; set; }
        public int CustomerCode { get; set; }
        public int ProductCode { get; set; }
        public int QuantityOrdered { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string Status { get; set; }
    }
}
