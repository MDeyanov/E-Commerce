using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }

        [Required(ErrorMessage = "UserID is required.")]
        public string UserID { get; set; } = null!;

        public DateTime OrderDate { get; set; }

        public string? Status { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "TotalAmount must be non-negative.")]
        public decimal TotalAmount { get; set; }

        public string ShippingAddress { get; set; } = null!;

    }
}
