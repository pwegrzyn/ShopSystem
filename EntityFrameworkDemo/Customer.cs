using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Customer
    {
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }
        
        // Primary key
        [Key]
        public String CompanyName { get; set; }
        public String Description { get; set; }

        // Navigation Properties
        public virtual ICollection<Order> Orders { get; set; }
    }
}
