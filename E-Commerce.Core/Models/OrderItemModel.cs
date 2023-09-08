using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Models
{
    public class OrderItemModel
    {
        public int OrderItemID { get; set; }

        [Required(ErrorMessage = "OrderID is required.")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "ProductID is required.")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be non-negative.")]
        public decimal Price { get; set; }
    }
}
