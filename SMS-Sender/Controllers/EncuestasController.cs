using System.Net;
using System.Web.Mvc;
using FluentValidation.Results;
using SMS_Sender.Core.Interfaces;
using SMS_Sender.Core.Models;
using SMS_Sender.Data;
using SMS_Sender.Data.ImplementacionesInterfaces;
using SMS_Sender.Validaciones;

namespace SMS_Sender.Controllers
{
    public class EncuestasController : Controller
    {
        private IUnifOfWork _unitOfWork = new UnitOfWork(new SMS_SenderContext());

        public ActionResult DetallesCliente(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Cliente cliente = _unitOfWork.Clientes.Get((int)id);
            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

        public ViewResult CrearCliente()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearCliente(Cliente cliente)
        {
            ClienteValidation validar = new ClienteValidation();
            ValidationResult model = validar.Validate(cliente);
            if (model.IsValid)
            {
                _unitOfWork.Clientes.Add(cliente);
                _unitOfWork.Complete();
                return RedirectToAction("DetallesCliente");
            }
            else
            {
                foreach (ValidationFailure _error in model.Errors)
                {
                    ModelState.AddModelError(_error.PropertyName, _error.ErrorMessage);
                }
            }

            return View(cliente);
        }

        public ActionResult EditarCliente(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Cliente cliente = _unitOfWork.Clientes.Get((int)id);
            if (cliente == null)
                return HttpNotFound();
            
            return View(cliente);
        }

        public ActionResult EliminarCliente(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Cliente cliente = _unitOfWork.Clientes.Get((int)id);
            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarCliente(int id)
        {
            Cliente cliente = _unitOfWork.Clientes.Get(id);
            _unitOfWork.Clientes.Remove(cliente);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}
