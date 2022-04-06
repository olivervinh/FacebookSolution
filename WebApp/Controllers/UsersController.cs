using Facebook.Application.Services.UserServices;
using Market.Domain.Users.DTO.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserService _userService;
        public UsersController(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            var result = await _userService.UserRegisterAsync(registerRequest);
            if (result)
                return View();
            return View();
        }
        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
