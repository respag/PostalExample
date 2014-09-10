using Postal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Postal_Example.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            dynamic email = new Email("Example");
            email.To = "respag@hotmail.com, rspagnuolo@ultimus.com, panamap@outlook.com";
            email.FunnyLink = "http://blog.respag.net";
            email.Fecha = DateTime.Now.ToString(@"dddd, dd \de MMMM \de yyyy");
            email.Send();
            return View();
        }
    }
}