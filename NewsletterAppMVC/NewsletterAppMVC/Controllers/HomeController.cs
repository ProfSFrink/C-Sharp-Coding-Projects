using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost] // The below method is a post

        // Take the three inputs from the Sign Up web form and map them into each input parameter
        public ActionResult SignUp(string FirstName, string LastName, string EmailAddress)
        {
            return null;
        } // END SignUp METHOD

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}