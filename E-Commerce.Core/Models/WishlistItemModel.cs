using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Models
{
    public class WishlistItemModel
    {
        public int WishlistItemId { get; set; }

        [Required(ErrorMessage = "WishlistID is required.")]
        public int WishlistID { get; set; }

        [Required(ErrorMessage = "ProductID is required.")]
        public int ProductID { get; set; }

    }
}
