using BitlyDotNET.Implementations;
using BitlyDotNET.Interfaces;
using Nexmo.Api;
using SMS_Sender.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SMS_Sender.Controllers
{
    public class NexmoController : Controller
    {
        public ViewResult EnviarEncuesta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnviarEncuesta(Cliente cliente)
        {
            var codigo = "52" + cliente.Celular;
            var creds = new Nexmo.Api.Request.Credentials
            {
                ApiKey = "3310b41a",
                ApiSecret = "8IYAi7CQOyAPe3JL",
                ApplicationId = "1ca36d22-d425-4b02-82ba-2a22078fc431",
                ApplicationKey = "67d90464504effc"
            };

            var start = NumberVerify.Verify(new NumberVerify.VerifyRequest
            {
                number = codigo,
                brand = "NexmoQS"
            }, creds);
            Session["requestID"] = start.request_id;

            return RedirectToAction("LigaBitly");
        }

        public ActionResult LigaBitly()
        {

            //Bitly no acorta enlaces directos localhost a menos que se configure el nombre de dominio del puerto, que en este caso es 53790, cosa que solo funciona localmente
            //Referencia: https://stackoverflow.com/questions/10456174/oauth-how-to-test-with-local-urls

            //Esta es la implementación de la API de Bitly
            //IBitlyService bitly = new BitlyService("35a29086cec1b63e6b350ad0a09b2828167402af", "f294a395e5808f79cbf885ff71c935edc4852e86");

            //string link = bitly.Shorten("El Link");
            //ViewBag.Link = ligaCorta;


            //API TinyUrl
            Uri liga = new Uri("http://tinyurl.com/api-create.php?url=" + "http://localhost:53790/Encuestas/CrearCliente");
            WebClient cliente = new WebClient();
            string ligaCorta = cliente.DownloadString(liga);
            ViewBag.liga = ligaCorta;

            return View();
        }
    }
}