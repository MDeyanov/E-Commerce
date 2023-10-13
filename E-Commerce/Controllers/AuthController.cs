using E_Commerce.Core.Interfaces;
using E_Commerce.Core.Models;
using E_Commerce.Infrastructure.Data.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private  readonly IAuthService _authService;
       
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] AppUserModel model)
        {
            if (ModelState.IsValid)
            {
                 
                var isUserExists =  await _authService.IsUserExists(model.Email);
                if (isUserExists == false)
                {
                    BadRequest(new AuthResult()
                    {
                        Result = false,
                        Errors = new List<string>()
                        {
                            ""
                        }
                    });
                }
               BadRequest(ModelState);
            }

            return await _authService.RegisterUser(model);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var signInResult = await _authService.LoginAsync(model.Email, model.Password);

            if (signInResult.Succeeded)
            {
                // Login successful, you can return a success response or generate a JWT token here.
                return Ok("Login successful");
            }

            return Unauthorized("Login failed");
        }

        [HttpPost("logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _authService.LogoutAsync();

            // Logout successful, you can return a success response or perform other logout-related actions here.
            return Ok("Logout successful");
        }
    }
}


