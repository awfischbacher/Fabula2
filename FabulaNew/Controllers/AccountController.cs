﻿using Microsoft.AspNetCore.Mvc;

namespace Fabula.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}