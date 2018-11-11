using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Product
    {
        public Product()
        {
            this.InOrders = new HashSet<Order>();
        }
        
        // Primary key
        public int ProductId { get; set; }
        [Index(IsUnique= true)]
        [StringLength(450)]
        public String Name { get; set; }
        public int UnitsInStock { get; set; }
        // Foreign key
        public int CategoryId { get; set; }
        [Column(TypeName = "Money")]
        public decimal UnitPrice { get; set; }

        // Navigation properties
        public virtual Category Category { get; set; }
        public virtual ICollection<Order> InOrders { get; set; }
    }
}
