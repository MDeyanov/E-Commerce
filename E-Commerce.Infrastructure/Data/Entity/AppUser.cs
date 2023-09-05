using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static E_Commerce.Infrastructure.Data.Common.ValidationConstants.UserConstraints;

namespace E_Commerce.Infrastructure.Data.Entity
{
    public class AppUser : IdentityUser
    {
        [StringLength(FirstNameMaxLength)]
        public string? FirstName { get; set; }

        [StringLength(LastNameMaxLength)]
        public string? LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string? ProfileImageURL { get; set; }
        public DateTime RegisteredAt { get; set; }

        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
