using SMS_Sender.Core.Interfaces;
using SMS_Sender.Data;
using SMS_Sender.Data.ImplementacionesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS_Sender.Controllers
{
    public class HomeController : Controller
    {
        private IUnifOfWork _unitOfWork = new UnitOfWork(new SMS_SenderContext());

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Encuestas()
        {
            var clientes = _unitOfWork.Clientes.GetAll();
            return View(clientes);
        }

        public ContentResult Acerca()
        {
            return Content("En construcción");
        }
    }
}