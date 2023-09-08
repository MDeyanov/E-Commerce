using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Models
{
    public class PaymentModel
    {
        public int PaymentID { get; set; }

        [Required(ErrorMessage = "OrderID is required.")]
        public int OrderID { get; set; }

        public DateTime PaymentDate { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Amount must be non-negative.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "PaymentMethod is required.")]
        public string PaymentMethod { get; set; } = null!;

        public string? TransactionID { get; set; }

    }
}
