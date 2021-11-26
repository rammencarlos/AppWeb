using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WS.Core;
using WS.DTO.BranchOffie;

namespace WS.API.Controllers
{
    public class BOController : Controller
    {
        // GET: BO
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int Create(BODTOCreate bo)
        {
            BOCore boCore = new BOCore();
            //boCore.Create(bo);


            return boCore.Create(bo);

        }

    }
}