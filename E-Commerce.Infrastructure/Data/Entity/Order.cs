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
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public string UserID { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserID))]
        public AppUser User { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public string? Status { get; set; }

        [Precision(18, 2)]
        public decimal TotalAmount { get; set; }
        public string? ShippingAddress { get; set; }
    }
}
