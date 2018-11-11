using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Order
    {
        public Order()
        {
            this.Products = new HashSet<Product>();
        }

        // Primary key
        public int OrderId { get; set; }
        // Foreign key
        public string CustomerId { get; set; }
        [MaxLength(256)]
        public virtual string Notes { get; set; }
        public virtual DateTime OrderedDateTime { get; set; }

        // Navigation properties
        public virtual ICollection<Product> Products { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
