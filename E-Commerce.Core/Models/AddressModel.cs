using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Models
{
    public class AddressModel
    {

        [Required]
        public int AddressID { get; set; }

        [Required]
        public string UserID { get; set; } = null!;

        [Required(ErrorMessage = "Street is required.")]
        public string Street { get; set; } = null!;

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; } = null!;

        [Required(ErrorMessage = "PostalCode is required.")]
        public string PostalCode { get; set; } = null!;

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; } = null!;


        public bool? IsBillingAddress { get; set; }
        public bool? IsShippingAddress { get; set; }
    }
}
