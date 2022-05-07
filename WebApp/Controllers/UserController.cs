using Microsoft.AspNetCore.Mvc;
using ProductCatalog.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService catalogService;

        public UserController(IUserService catalogService)
        {
            this.catalogService = catalogService;
        }

        public async Task<IActionResult> UserData()
        {
            var items = await catalogService.GetUserItemsAsync();
            return View(items);
        }
<<<<<<< HEAD
         public async Task<IActionResult> UserRegistration()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserRegistration(UserRegister user)
        {
            if (catalogService.RegisterUser(user).Result)
            {
                return Redirect("/");
            }
            return View();
        }


=======
        public ActionResult Login()
        {
            return View();
        }  
          
>>>>>>> 8017bc3558f40a7044716b348b1d09cfc2af8c89
    }
    }

