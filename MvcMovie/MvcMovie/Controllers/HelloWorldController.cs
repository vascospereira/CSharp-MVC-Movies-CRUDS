using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld. Index() Action method return models to views, file streams, 
        // redirect to other controllers, or whatever is necessary for the task at hand.
        public ActionResult Index()
        {
            return View();
        }

        //  HttpUtility.HtmlEncode to protect the application from malicious input (namely JavaScript).
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}