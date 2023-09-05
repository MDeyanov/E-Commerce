using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Data.Entity
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public int CartID { get; set; }

        [Required]
        [ForeignKey(nameof(CartID))]
        public Cart Cart { get; set; } = null!;

        [Required]
        public int ProductID { get; set; }

        [Required]
        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
