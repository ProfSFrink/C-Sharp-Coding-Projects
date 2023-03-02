// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 11: Creating MVC Applications
// AUTHOR: Steven Partlow
// DATE: 02/03/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterAppMVC.ViewModels
{

    public class SignupVm
    {
        public string FirstName { get; set; } // A string variable to match to our FirstName column
        public string LastName { get; set; } // A string variable to match to our LastName column
        public string EmailAddress { get; set; } // A string variable to match to our EmailAddress column
    } // End SignupVm CLASS

} // End NewsletterAppMVC.ViewModels NAMESPACE