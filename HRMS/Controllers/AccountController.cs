using HRMS.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HRMS.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration iconfiguration;
        public AccountController(IConfiguration iconfiguration)
        {
            this.iconfiguration = iconfiguration;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(Users users)
        {
            Dictionary<string, string> UsersRecords = new Dictionary<string, string>
                {
                    { "user1","password1"},
                    { "user2","password2"},
                    { "user3","password3"},
                };

            if (!UsersRecords.Any(x => x.Key == users.Name && x.Value == users.Password))
            {
                return Ok();
            }

            // Else we generate JSON Web Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(iconfiguration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
              {
                 new Claim(ClaimTypes.Name, users.Name)
              }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var data = new Tokens { Token = tokenHandler.WriteToken(token) };
            return Ok(data);

        }
    }
}
