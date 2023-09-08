using System.ComponentModel.DataAnnotations;
using static E_Commerce.Infrastructure.Data.Common.ValidationConstants.UserConstraints;

namespace E_Commerce.Core.Models
{
    public class AppUserModel
    {
    
        public string? UserId { get; set; }

        [Required]
        [StringLength(UserNameMaxLength,
                ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = UserNameMinLength)]
        public string UserName { get; set; } = null!;

        [Required]  
        [StringLength(FirstNameMaxLength,
                ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength,
                ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = LastNameMinLength)]        
        public string LastName { get; set; } = null!;

        [Required]
        public DateTime DateOfBirth { get; set; }


        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
        public string? ProfileImageURL { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required]
        public string PasswordConfirmed { get; set; } = null!;


        public ICollection<AddressModel> Addresses { get; set; } = new List<AddressModel>();
        public ICollection<ReviewModel> Reviews { get; set; } = new List<ReviewModel>();
        public ICollection<OrderModel> Orders { get; set; } = new List<OrderModel>();
    }
}
