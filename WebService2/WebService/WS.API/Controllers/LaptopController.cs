using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WS.Core;
using WS.DTO;
using WS.DTO.Laptop;

namespace WS.API.Controllers
{
    public class LaptopController : Controller
    {

        // GET: BO
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(LaptopDTOCreate bo)
        {
            ResponseDTO response = new ResponseDTO();
            try
            {
                int id = new LaptopCore().Create(bo);

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
               List<LaptopDTODetail> list = new LaptopCore().List();

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
                LaptopDTODetail bo = new LaptopCore().Get(id);

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

        [HttpPost]
        public ActionResult Update(LaptopDTOUpdate bo)
        {
            ResponseDTO response = new ResponseDTO();
            try
            {
                int result = new LaptopCore().Update(bo);
                if (result != 0)
                {
                    response.Message = "Actualizado correctamente";
                    response.StatusCode = 200;
                    response.ResponseObject = bo;
                }
                else {
                    response.Message = "Error: el registro no se actualizo";
                    response.StatusCode = 500;
                    response.ResponseObject = null;
                }
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
        public ActionResult Delete(int id)
        {
            ResponseDTO response = new ResponseDTO();
            try
            {
                bool isDelete = new LaptopCore().Delete(id);

                response.Message = isDelete ? "Registro eliminado" : "Registro no elimado";
                response.StatusCode = 200;
                response.ResponseObject = null;
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