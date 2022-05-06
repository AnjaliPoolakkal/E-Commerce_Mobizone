using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProductCatalog.API.DTO;
using ProductCatalog.Domain.Customers;
using ProductCatalog.Domain.DataBase;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.API.Controllers
{
    
    [Route("[Controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly CatalogDBContext context;
        private readonly JWTSetting _jWTSetting;
        public LoginController(CatalogDBContext _context,IOptions<JWTSetting> options)
        {
            context = _context;
            _jWTSetting = options.Value;
        }

        [AllowAnonymous]
        [HttpPost("Authenticate")]
       public IActionResult Authenticate([FromBody] UserLogin credential)
        {
            var _user = context.User.FirstOrDefault(o => o.UserName == credential.UserName && o.Password == credential.password);
            if (_user == null)
                return Unauthorized();
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_jWTSetting.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name,_user.UserName),
                        
                    }
                ),
                Expires=DateTime.Now.AddSeconds(60),
                SigningCredentials=new SigningCredentials(new SymmetricSecurityKey(tokenKey),SecurityAlgorithms.HmacSha256)
            };
            var token = tokenhandler.CreateToken(tokenDescriptor);
            string finalToken = tokenhandler.WriteToken(token);
            return Ok(finalToken);
        }
    }
}
