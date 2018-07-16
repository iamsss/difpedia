using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using difpediaProject.Models;
using difpediaProject.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace difpediaProject.Controllers
{
     [Route("api/[controller]")]
    public class TokenController : Controller
    {
        
        private readonly difpediaProjectDbContext context;

        
        private IConfiguration _config;

        public TokenController(IConfiguration config, difpediaProjectDbContext context)
        {
            _config = config;
             this.context = context;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult CreateToken([FromBody]LoginModel login)
        {
            IActionResult response = Unauthorized();
            var user = Authenticate(login);

            if (user != null)
            {
                var tokenString = BuildToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }
        

        private string BuildToken(User user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              expires: DateTime.Now.AddMinutes(30),
              signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private User Authenticate(LoginModel login)
        {
           
             var user = context.Users.Find(login.Id);
             if(user != null && user.Password == login.Password) {
                return user;
            } 
            return user;  
        }

        public class LoginModel
        {
            public int Id { get; set; }
            public string Password { get; set; }
        }

       
    

    }
}