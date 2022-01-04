using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SoulFire.Entities;
using SoulFire.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace SoulFire.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration config;
        private readonly Context context;
        private readonly IAuthProvider authProvider;

        public AuthController(IConfiguration config, Context context, IAuthProvider authProvider)
        {
            this.config = config;
            this.context = context;
            this.authProvider = authProvider;
        }

        private string GenerateJSONWebToken(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(config["Jwt:Issuer"],
              config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost(nameof(Login))]
        public async Task<IActionResult> Login([FromBody] AuthRequest data)
        {
            IActionResult response = Unauthorized();
            var user = await authProvider.AuthenticateUser(data);
            if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { Token = tokenString, Message = "Success", UserId = user.Id, Username = user.Username });
            }
            return response;
        }

        [AllowAnonymous]
        [HttpPost(nameof(Register))]
        public async Task<IActionResult> Register([FromBody] RegisterRequest data)
        {

            User userData = new User { Id= new Guid(), Username = data.Username, Password = data.Password, CharacterType = data.CharacterType };
            userData.AutoThoughts = new List<UserAutoThought>();
            userData.MiddleThoughts = new List<UserMiddleThought>();
            userData.DeepThoughts = new List<UserDeepThought>();

            userData.AutoThoughts.AddRange(from string? autoThought in data.AutoThoughts
                                           select new UserAutoThought { Id = new Guid(), UserId = userData.Id, Content = autoThought });
            userData.MiddleThoughts.AddRange(from string? middleThought in data.MiddleThoughts
                                             select new UserMiddleThought { Id = new Guid(), UserId = userData.Id, Content = middleThought });
            userData.DeepThoughts.AddRange(from string? deepThought in data.DeepThoughts
                                           select new UserDeepThought { Id = new Guid(), UserId = userData.Id, Content = deepThought });


            IActionResult response = BadRequest();
            var user = await authProvider.RegisterUser(userData);
            if (user != null)
            {
                response = Ok(user);
            }
            return response;
        }

        [HttpGet(nameof(Get))]
        public async Task<IEnumerable<string>> Get()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");

            return new string[] { accessToken };
        }
    }
}
