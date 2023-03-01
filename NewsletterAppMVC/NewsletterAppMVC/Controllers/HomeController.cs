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
                // Our connection string so we can connect to our database
                string connectionString = @"Data Source=PROFSFRINK-PC\SQLEXPRESS;Initial Catalog=db_Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                // A SQL query store as a string will add the three method input parameters to the matching columns in our SignUps table in our Newsletter database
                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                                        (@FirstName, @LastName, @EmailAddress)";

                // OPEN a new SqlConnection called connection using our connectionString
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a new SQL command object using the connection created and the queryString defined above
                    SqlCommand command = new SqlCommand(queryString, connection);

                    // Define the parameters used within our queryString
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar); // Define this parameter as a SQL VarChar data type
                    command.Parameters.Add("@LastName", SqlDbType.VarChar); // Define this parameter as a SQL VarChar data type
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar); // Define this parameter as a SQL VarChar data type

                    command.Parameters["@FirstName"].Value = firstName; // Set SQL Query parameter FirstName equal to the value of C# variable firstName
                    command.Parameters["@LastName"].Value = lastName; // Set SQL Query parameter LastName equal to the value of C# variable lastName
                    command.Parameters["@EmailAddress"].Value = emailAddress; // Set SQL Query parameter EmailAddress equal to the value of C# variable emailAddress

                    connection.Open(); // Open the SQL connection to the db_Newsletter database
                    command.ExecuteNonQuery(); // Execute the SQL query defined in command
                    connection.Close(); // Close the SQL connection to the db_Newsletter database
                } // CLOSE SqlConnection

                return View("Success"); // If all inputs are valid return view Success.cshtml
            } // End ELSE

        } // END SignUp METHOD

        public ActionResult Admin()
        {
            return View();
        } // End Admin METHOD

    }

}