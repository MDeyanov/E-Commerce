using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Models
{
    public class CartModel
    {
        public int CartID { get; set; }

        [Required(ErrorMessage = "UserID is required.")]
        public string UserID { get; set; } = null!;

        public ICollection<CartItemModel> CartItems { get; set; } = new List<CartItemModel>();
    }
}
