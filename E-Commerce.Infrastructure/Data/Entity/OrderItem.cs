using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Data.Entity
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [Required]
        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; } = null!;

        [Required]
        public int ProductID { get; set; }

        [Required]
        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }
    }
}
