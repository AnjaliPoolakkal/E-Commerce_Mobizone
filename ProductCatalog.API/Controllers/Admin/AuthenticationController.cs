using Microsoft.AspNetCore.Mvc;
using ProductCatalog.API.DTO;
using ProductCatalog.BusinessObject.Admin.Authentication;
using ProductCatalog.Domain.Customers;
using ProductCatalog.Domain.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.API.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationBO _authenticationBO;
        public AuthenticationController(IAuthenticationBO authenticationBO)
        {
            _authenticationBO = authenticationBO;
        }
        [HttpPost("UserCreate")]
        public async Task<UserDetails> UserCreate([FromBody] UserRegister usersRegister)
        {
            UserDetails userDetail = new UserDetails();
            userDetail.FirstName = usersRegister.FirstName;
            userDetail.LastName = usersRegister.LastName;
            userDetail.Email = usersRegister.Email;
            User user = new User();
            user.UserName = usersRegister.FirstName +" " + usersRegister.LastName;
            user.Password = usersRegister.PassWord;
            Roles role = new Roles();
            role.UserRole = "User";
            user.Role = role;
            role.ModifiedAtUTC = DateTime.Now;
            role.CreatedAtUTC = DateTime.Now;
            role.CreatedBy = usersRegister.FirstName;
            role.ModifiedBy = usersRegister.FirstName;
            userDetail.User = user;
            user.ModifiedOnUTC = DateTime.Now;
            user.CreatedOnUTC = DateTime.Now;
            user.CreatedBy = usersRegister.FirstName;
            user.ModifiedBy = usersRegister.FirstName;
            user.ForgotToken = "kiyughinfgksuimo8i7dyukihhfinsfgosi";
            var result = _authenticationBO.AddUserRegistration(userDetail).Result;
            if (result == null)
                return null;
            return userDetail;
        }
    }
}
