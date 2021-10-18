using Microsoft.AspNetCore.Mvc;
using P3.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities.Persistence;

namespace P3.CRUD.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// Retorna la vista Index.cshtml
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            List<UserViewModel> users = UserRespository.Instance._users;

            return View(users);
        }

        /// <summary>
        /// Retorna la vista AddOrEdit.cshtml
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult AddOrEdit(int id)
        {
            UserViewModel user = new UserViewModel();
            if (id != 0)
            {
               user =  UserRespository.Instance.GetUser(id);
            }

            return View(user);
        }


        /// <summary>
        /// No retorna una vista, solo ejecuta una acción
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult AddOrEdit([FromForm] UserViewModel user)
        {
            if (user.Id == 0)
            {
                if (ModelState.IsValid)
                {
                    UserRespository.Instance.CreateUser(user);
                }
                else
                {
                    return View(user);
                }
            }
            else
            {
                UserRespository.Instance.UpdateUser(user);
            }

            return RedirectToAction("Index");
        }

        /// <summary>
        /// No retorna una vista, solo ejecuta una acción
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            UserViewModel user = new UserViewModel();
            if (id != 0)
            {
              UserRespository.Instance.DeleteUser(id);
            }

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Retorna la vista Detail.cshtml
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Detail(int id)
        {
            UserViewModel user = new UserViewModel();
            if (id != 0)
            {
                user = UserRespository.Instance.GetUser(id);
            }

            return View(user);
        }

    }
}
