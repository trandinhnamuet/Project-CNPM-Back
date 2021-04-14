using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_CNPM.Models
{
    public class Payment
    {
        [Key]
        public int PaymentCode { get; set; }
        public int OrderCode { get; set; }
        public int CustomerCode { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Amount { get; set; }
        public string PaymentType { get; set; }
    }
}
