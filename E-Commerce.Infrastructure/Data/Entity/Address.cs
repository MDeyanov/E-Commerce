using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Data.Entity
{
    public class Address
    {
        [Key]   
        public int AddressID { get; set; }

        [Required]
        public string UserID { get; set; }

        [Required]
        [ForeignKey(nameof(UserID))]
        public AppUser User { get; set; } = null!;
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public bool? IsBillingAddress { get; set; }
        public bool? IsShippingAddress { get; set; }
    }
}
