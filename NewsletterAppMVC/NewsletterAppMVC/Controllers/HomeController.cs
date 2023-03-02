// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 11: Creating MVC Applications
// AUTHOR: Steven Partlow
// DATE: 02/03/2023

using NewsletterAppMVC.Models;
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
        // Our connection string so we can connect to our database
        private readonly string connectionString = @"Data Source=PROFSFRINK-PC\SQLEXPRESS;Initial Catalog=db_Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress FROM SignUps"; // This queryString will select all records within the database

            List<NewsletterSignUp> signups = new List<NewsletterSignUp>(); // An empty list containing instances of our NewsletterSignUp model (class)

            using (SqlConnection connection = new SqlConnection(connectionString)) // Open a new SQL connectio using our connectionString
            {
                SqlCommand command = new SqlCommand(queryString, connection); // Create a new SqlCommand object using queryString and connection

                connection.Open(); // Open the SQL connection

                SqlDataReader reader = command.ExecuteReader(); // Create a new SqlDataReader object and store the data retrieved by our SQL command within it 

                while (reader.Read()) // Keep iterating until there are no more records to read
                {
                    var signup = new NewsletterSignUp(); // Create a new instance of the NewsLetterSignUp model and call it signup

                    signup.Id = Convert.ToInt32(reader["Id"]); // Take the current records Id column and assign to the signup.Id property after casting it to a integer
                    signup.FirstName = reader["FirstName"].ToString(); // Take the current records FirstName column and assign to the signup.FirstName property after casting it to a string
                    signup.LastName = reader["LastName"].ToString(); // Take the current records LastName column and assign to the signup.LastName property after casting it to a string
                    signup.EmailAddress = reader["EmailAddress"].ToString(); // Take the current records EmailAddress column and assign to the signup.EmailAddress property after casting it to a string

                    signups.Add(signup); // Add the signup instance of the NewsletterSignUp model to the signups list
                } // End WHILE
            }

            return View(signups);
        } // End Admin METHOD

    }

}