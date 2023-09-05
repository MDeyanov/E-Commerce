using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Data.Entity
{
    public class Cart
    {
        public int CartID { get; set; }

        [Required]
        public string UserID { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserID))]
        public AppUser User { get; set; } = null!;
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
