using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PaymentAppAngularDemo.Models
{
    public class PaymentDetailContext : DbContext 
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        {
            
        }

        public DbSet<PaymentDetails> PaymentDetails { get; set; }
    }
}
