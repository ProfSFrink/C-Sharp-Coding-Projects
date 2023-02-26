// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 11: Creating MVC Applications
// AUTHOR: Steven Partlow
// DATE: 26/02/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        } // END Index

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        } // END About

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - Academy of Learning";

            return View();
        } // END Contact

        public ActionResult Instructor(int id) // Take parameter taken in from browser URL and store value as integer id
        {
            ViewBag.Id = id; // Add value of id to ViewBag dictionary

            return View(); // Return Instructor view
        } // END Instructor
         
        public ActionResult Instructors()
        {
            return View();
        } // END Instructors
    }
}