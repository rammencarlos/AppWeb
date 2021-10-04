using Microsoft.AspNetCore.Mvc;
using P2.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2.MVC.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel userVM = new UserViewModel();
            userVM.Id = 1;
            userVM.Name = "Carlos";
            userVM.IsEnabled = true;

            return View(userVM);
        }


    }
}
