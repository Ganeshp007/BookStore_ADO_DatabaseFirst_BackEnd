﻿namespace BookStore_ADO_DatabaseFirst.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}