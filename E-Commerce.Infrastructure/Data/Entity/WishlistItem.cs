using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Data.Entity
{
    public class WishlistItem
    {
        [Key]
        public int WishlistItemId { get; set; }

        [Required]
        public int WishlistID { get; set; }

        [Required]
        [ForeignKey(nameof(WishlistID))]
        public Wishlist Wishlist { get; set; } = null!;

        [Required]
        public int ProductID { get; set; }

        [Required]
        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; } = null!;
    }
}
