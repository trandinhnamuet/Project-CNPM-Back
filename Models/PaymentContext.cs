using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project_CNPM.Models
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {
        }

        public DbSet<Payment> Payments { get; set; }
    }
}
