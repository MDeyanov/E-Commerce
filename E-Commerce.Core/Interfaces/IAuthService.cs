using E_Commerce.Core.Models;
using Microsoft.AspNetCore.Identity;


namespace E_Commerce.Core.Interfaces
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(AppUserModel appUserModel);
        Task<SignInResult> LoginAsync(string username, string password);
        Task LogoutAsync();
    }
}
