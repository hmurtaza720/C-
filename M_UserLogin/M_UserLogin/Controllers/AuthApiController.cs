using M_UserLogin.Models;
using M_UserLogin.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace M_UserLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthApiController : ControllerBase
    {
        private readonly UserManager<Users> _userManager;
        private readonly IConfiguration _config;

        // ✅ Constructor - Inject UserManager and Configuration
        public AuthApiController(UserManager<Users> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }

        // 🔹 STEP 1: Login Endpoint (returns JWT token)
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Find user by email
            var user = await _userManager.FindByEmailAsync(model.Email ?? "");
            if (user == null)
                return Unauthorized("Invalid credentials");

            // Validate password
            var passwordValid = await _userManager.CheckPasswordAsync(user, model.Password ?? "");
            if (!passwordValid)
                return Unauthorized("Invalid credentials");

            // Generate JWT Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.UserName!),
                    new Claim(ClaimTypes.Email, user.Email!)
                }),
                Expires = DateTime.UtcNow.AddMinutes(60),
                Issuer = _config["Jwt:Issuer"],
                Audience = _config["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);

            // ✅ Return token in response
            return Ok(new { token = jwtToken });
        }

        // 🔹 STEP 2: Protected Endpoint (test JWT access)
        [HttpGet("profile")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult GetUserProfile()
        {
            var userName = User.Identity?.Name;
            return Ok(new { message = $"Welcome {userName}! You are authorized 🎉" });
        }
    }
}
