using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TravelDeskProject.IRepo;
using TravelDeskProject.Models;
using TravelDeskProject.Repo;
using TravelDeskProject.ViewModel;

namespace TravelDeskProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LoginController : ControllerBase
    {
        ILoginRepo _loginRepo;
        IConfiguration _config;
        IUserRepo _userRepo;

        public LoginController(ILoginRepo loginRepo,IConfiguration config,IUserRepo userRepo)
        {
            _loginRepo = loginRepo;
            _config = config;
            _userRepo = userRepo;
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(LoginViewModel loginuser)
        {
            IActionResult response = Unauthorized();
            if (_loginRepo.Login(loginuser))
            {
                int roleId = _userRepo.GetRoleId(loginuser);
                string role = _userRepo.GetRoleName(roleId);
                var userId = _userRepo.GetUserId(loginuser);
                var claims = new List<Claim>();
                claims.Add(new Claim("email", loginuser.Email));
                claims.Add(new Claim("role", role));
                claims.Add(new Claim("userId",userId.ToString()));

                var tokenString = GenerateJSONWebToken(claims.ToArray());
                return Ok(new { token = tokenString });
            }
            return BadRequest();
        }

        private string GenerateJSONWebToken(Claim[] claims)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Audience"],

              expires: DateTime.Now.AddMinutes(120),
              claims: claims,
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
