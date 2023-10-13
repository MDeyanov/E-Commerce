using E_Commerce.Core.Interfaces;
using E_Commerce.Core.Models;
using E_Commerce.Infrastructure.Data.Entity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace E_Commerce.Core.Services
{
    public class AuthService : IAuthService
    {
        //D.I.
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        //token secret (not for this place)
        private const string TokenSecret = "ForSecureLoad";
        private static readonly TimeSpan TokenLifetime = TimeSpan.FromHours(5);

        public AuthService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }



        public async Task<AuthResult> RegisterUser(AppUserModel appUserModel)
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

            if (result.Succeeded)
            {
                var token = GenerateToken(user);

                return new AuthResult()
                {
                    Result = true,
                    Token = token

                };
            }

            return new AuthResult()
            {
                Errors = new List<string>()
                {
                    "Server error"
                },
                Result = false,
            };
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

        public string GenerateToken(AppUser appUser)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(TokenSecret);

            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.Sub, appUser.Email),
                new(JwtRegisteredClaimNames.Email, appUser.Email),
                new("Id", appUser.Id.ToString())
               
            };

            //foreach (var claim in appUserModel.Claims)
            //{
            //    if (C) 
            //    {

            //    }
            //    var jsonElement = (JsonElement)claim.Value;
            //    var valueType = jsonElement.ValueKind switch
            //    {
            //        JsonValueKind.True => ClaimValueTypes.Boolean,
            //        JsonValueKind.False => ClaimValueTypes.Boolean,
            //        JsonValueKind.Number => ClaimValueTypes.Double,
            //        _ => ClaimValueTypes.String
            //    };
                
            //    var claim = new Claim(claim.Key, claim.Value.ToString()!, valueType);
            //    claims.Add(claim);
            //}

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(TokenLifetime),
                Issuer = "random123",
                Audience = "random123",
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwt = tokenHandler.WriteToken(token);

            return (jwt);
        }

        public async Task<bool> IsUserExists(string email)
        {
            var result = await _userManager.FindByEmailAsync(email);

            if (result != null)
            {
                return true;
            }

            return false;
        }
    }
}
