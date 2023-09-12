using E_Commerce.Core.Interfaces;
using E_Commerce.Core.Models;
using E_Commerce.Infrastructure.Data.Entity;
using Microsoft.AspNetCore.Identity;


namespace E_Commerce.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> RegisterUser(AppUserModel appUserModel)
        {
          

            var user = new AppUser
            {
                UserName = appUserModel.UserName,
                FirstName = appUserModel.FirstName,
                LastName = appUserModel.LastName,
                DateOfBirth = appUserModel.DateOfBirth,
                RegisteredAt = appUserModel.RegisteredAt,
                ProfileImageURL = appUserModel.ProfileImageURL,
                Email = appUserModel.Email,            
            };

            var result = await _userManager.CreateAsync(user, appUserModel.Password);
        
            return result.Succeeded;
        }
    }
}
