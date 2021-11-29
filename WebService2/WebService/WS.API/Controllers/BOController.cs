using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WS.Core;
using WS.DTO;
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
        public ActionResult Create(BODTOCreate bo)
        {
            ResponseDTO response = new ResponseDTO();
            try
            {
                int id = new BOCore().Create(bo);

                response.Message = "Registro creado exitosamente";
                response.StatusCode = 200;
                response.ResponseObject = id;
            }
            catch (Exception ex)
            {
                response.Message = "Error: " + ex.Message;
                response.StatusCode = 500;
                response.ResponseObject = null;
            }
            return Json(response);
        }

        [HttpGet]
        public ActionResult List()
        {
            ResponseDTO response = new ResponseDTO();
            try
            {
               List<BODTODetail> list = new BOCore().List();

                response.Message = "Listado correctamente";
                response.StatusCode = 200;
                response.ResponseObject = list;
            }
            catch (Exception ex)
            {
                response.Message = "Error: " + ex.Message;
                response.StatusCode = 500;
                response.ResponseObject = null;
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            ResponseDTO response = new ResponseDTO();
            try
            {
                BODTODetail bo = new BOCore().Get(id);

                response.Message = "Listado correctamente";
                response.StatusCode = 200;
                response.ResponseObject = bo;
            }
            catch (Exception ex)
            {
                response.Message = "Error: " + ex.Message;
                response.StatusCode = 500;
                response.ResponseObject = null;
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }

    }
}