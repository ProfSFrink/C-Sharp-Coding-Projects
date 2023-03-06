// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 12: Continuing to Develop in C# and MVC
// AUTHOR: Steven Partlow
// DATE: 06/03/2023

using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {

        // GET: Admin
        public ActionResult Index()
        {

            /* ENTITY FRAMEWORK DATABASE CALLS */

            // Create new connection to the newsletter database called db
            using (db_NewsletterEntities db = new db_NewsletterEntities())
            {
                var signups = db.SignUps; // Take all the records from the db.SignUps table and assign them the list signups (This is a list of SignUp.cs class instances)

                var signupVms = new List<SignupVm>(); // Create list of SignupVm view model objects
                foreach (var signup in signups) // Take the signups list and iterate through it assigning each instance to a local variable signup
                {
                    var signupVm = new SignupVm(); // Create a local instance of the signupVm view model
                    signupVm.FirstName = signup.FirstName; // Map the current instance of signup.FirstName to signupVm.FirstName
                    signupVm.LastName = signup.LastName; // Map the current instance of signup.LastName to signupVm.LastName
                    signupVm.EmailAddress = signup.EmailAddress; // Map the current instance of signup.EmailAddress to signupVm.EmailAddress
                    signupVms.Add(signupVm); // Take the local instance signupVm and add it to our main signupVms list
                } // End FOREACH

                return View(signupVms); // Pass the signupVms to the view
            } // End USING

        } // End of Index() Method

    }  // End CLASS AdminController

} // End NewsletterAppMVC.Controllers