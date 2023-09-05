using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Data.Entity
{
    public class Wishlist
    {
        public int WishlistID { get; set; }

        [Required]
        public string UserID { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserID))]
        public AppUser User { get; set; } = null!;
        public ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
    }
}
