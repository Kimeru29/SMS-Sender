using System.Net;
using System.Web.Mvc;
using SMS_Sender.Core.Interfaces;
using SMS_Sender.Core.Models;
using SMS_Sender.Data;
using SMS_Sender.Data.ImplementacionesInterfaces;

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
            if (ModelState.IsValid)
            {
                _unitOfWork.Clientes.Add(cliente);
                _unitOfWork.Complete();
                return RedirectToAction("DetallesCliente");
            }

            return View(cliente);
        }

        // GET: Encuestas/Edit/5
        public ActionResult EditarCliente(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = _unitOfWork.Clientes.Get((int)id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Encuestas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = _unitOfWork.Clientes.Get((int)id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Encuestas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = _unitOfWork.Clientes.Get(id);
            _unitOfWork.Clientes.Remove(cliente);
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
