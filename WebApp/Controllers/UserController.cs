using Microsoft.AspNetCore.Mvc;
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


        [HttpGet]
        public IActionResult UserRegister()
        {
            return View();
        }
    }
    }

