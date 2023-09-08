using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Models
{
    public class WishlistModel
    {
        public int WishlistID { get; set; }

        [Required(ErrorMessage = "UserID is required.")]
        public string UserID { get; set; }
    }
}
