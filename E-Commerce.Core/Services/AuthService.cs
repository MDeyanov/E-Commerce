using E_Commerce.Core.Interfaces;
using E_Commerce.Core.Models;
using E_Commerce.Infrastructure.Data.Entity;
using Microsoft.AspNetCore.Identity;


namespace E_Commerce.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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

        public async Task<SignInResult> LoginAsync(string username, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(username, password, false, lockoutOnFailure: false);
            return result;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
