// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 11: Creating MVC Applications
// AUTHOR: Steven Partlow
// DATE: 02/03/2023

using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            // Check if any of the three input parameters are null or empty then if
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml"); // they are return view error.cshtml
            } // End IF
            else
            {
                /* ENTITY FRAMEWORK DATABASE CALLS */

                // Create new connection to the newsletter database called db
                using (db_NewsletterEntities db = new db_NewsletterEntities())
                {
                    var signup = new SignUp(); // Create a new instance of the SignUp class called signup
                    signup.FirstName = firstName; // Assign the passed in parameter firstName to signup.FirstName
                    signup.LastName = lastName; // Assign the passed in parameter lastName to signup.LastName
                    signup.EmailAddress = emailAddress; // Assign the passed in parameter emailAddress to signup.EmailAddress

                    db.SignUps.Add(signup); // Add the signup instance to the SignUps table in our database
                    db.SaveChanges(); // Save the updated database
                } // End USING

                return View("Success"); // If all inputs are valid return view Success.cshtml
            } // End ELSE

        } // END SignUp METHOD

        public ActionResult Admin()
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

        } // End Admin METHOD

    }

}