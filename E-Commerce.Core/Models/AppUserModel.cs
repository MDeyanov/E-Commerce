using System.ComponentModel.DataAnnotations;
using static E_Commerce.Infrastructure.Data.Common.ValidationConstants.UserConstraints;
using static E_Commerce.Infrastructure.Data.Common.Messages.UserMessages;

namespace E_Commerce.Core.Models
{
    public class AppUserModel
    {
    
        public string? UserId { get; set; }

        [Required]
        [StringLength(UserNameMaxLength,
                ErrorMessage = NamesLenght,
                MinimumLength = UserNameMinLength)]
        public string UserName { get; set; } = null!;

        [Required]  
        [StringLength(FirstNameMaxLength,
                ErrorMessage = NamesLenght,
                MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength,
                ErrorMessage = NamesLenght,
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
    }
}
