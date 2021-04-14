using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project_CNPM.Models
{
    public class Customer
    {
        [Key]
        public int CustomerCode { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public int PurchaseNumber { get; set; }

    }
}
