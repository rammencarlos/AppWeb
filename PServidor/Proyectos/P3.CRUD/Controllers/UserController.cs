using Microsoft.AspNetCore.Mvc;
using P3.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P3.CRUD.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<UserViewModel> users = new List<UserViewModel>();
            
            UserViewModel userModel = new UserViewModel();
            userModel.Id = 1;
            userModel.UserName = "carlos.ramos";
            userModel.Name = "Carlos Ramos";
            userModel.Password = "1234";
            userModel.CreatedDate = DateTime.Now;
            users.Add(userModel);

            return View(users);
        }

        public IActionResult AddOrEdit(int id)
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult FormAddOrEdit([FromForm] UserViewModel user)
        {
            return View();
        }

    }
}
