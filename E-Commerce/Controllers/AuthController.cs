using E_Commerce.Core.Interfaces;
using E_Commerce.Core.Models;
using E_Commerce.Infrastructure.Data.Entity;
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
        public async Task<bool> RegisterUser(AppUserModel model)
        {
            if (!ModelState.IsValid)
            {
               BadRequest(ModelState);
            }

            return await _authService.RegisterUser(model);
        }
    }
}
