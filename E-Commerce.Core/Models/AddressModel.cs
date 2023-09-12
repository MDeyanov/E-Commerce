using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static E_Commerce.Infrastructure.Data.Common.Messages.AddressMessages;


namespace E_Commerce.Core.Models
{
    public class AddressModel
    {

        [Required]
        public int AddressID { get; set; }

        [Required]
        public string UserID { get; set; } = null!;

        [Required(ErrorMessage = StreetMessage)]
        public string Street { get; set; } = null!;

        [Required(ErrorMessage = CityMessage)]
        public string City { get; set; } = null!;

        [Required(ErrorMessage = PostalCodeMessage)]
        public string PostalCode { get; set; } = null!;

        [Required(ErrorMessage = CountryMessage)]
        public string Country { get; set; } = null!;


        public bool? IsBillingAddress { get; set; }
        public bool? IsShippingAddress { get; set; }
    }
}
