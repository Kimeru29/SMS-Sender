using Nexmo.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS_Sender.Controllers
{
    public class SmsController : Controller
    {
        // GET: Sms
        public ActionResult Index()
        {
            var results = SMS.Send(new SMS.SMSRequest
            {
                from = "NEXMO",
                to = "528188057188",
                text = "Esto es una prueba"
            });

            return null;
        }
    }
}