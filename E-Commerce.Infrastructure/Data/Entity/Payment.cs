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
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [Required]
        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; } = null!;
        public DateTime PaymentDate { get; set; }

        [Precision(18, 2)]
        public decimal Amount { get; set; }

        [Required]
        public string PaymentMethod { get; set; } = null!;
        public string? TransactionID { get; set; } 
    }
}
