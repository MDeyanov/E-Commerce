using E_Commerce.Core.Models;
using E_Commerce.Infrastructure.Data.Entity;
using Microsoft.AspNetCore.Identity;


namespace E_Commerce.Core.Interfaces
{
    public interface IAuthService
    {
        string GenerateToken(AppUser appUser);
        Task<bool> IsUserExists(string email);
        Task<AuthResult> RegisterUser(AppUserModel appUserModel);
        Task<SignInResult> LoginAsync(string username, string password);
        Task LogoutAsync();
    }
}
