// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 11: Creating MVC Applications
// AUTHOR: Steven Partlow
// DATE: 01/03/2023

// NewsletterSignUp CLASS DEFINITION

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterAppMVC.Models
{

    public class NewsletterSignUp
    {
        /* PROPERTIES */

        // These four properties are to match up to the four columns in the dbo_Newsletter\SignUps table
        public int Id { get; set; } // A integer variable Id to match up to our Id column
        public string FirstName { get; set; } // A string variable to match to our FirstName column
        public string LastName { get; set; } // A string variable to match to our LastName column
        public string EmailAddress { get; set; } // A string variable to match to our EmailAddress column

    } // End NewsletterSignUp CLASS

} // END of NewsLetterAppMVC.Models NAMESPACE