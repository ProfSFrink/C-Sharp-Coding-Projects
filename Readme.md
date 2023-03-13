# C-Sharp Coding Projects
This repository covers the main projects done as part of the C# and .NET Framework course as part of my Advaced Software and Web Developer with Pitman Training / The Tech Academy.

## TwentyOne Game

## MVC Application - Students
An application developed over eleven parts to show our understanding of the Model-View-Controller desgin pattern and demonstrate what we learned in the MVC Tutorial.

## MVC Sample Application
A ten-part video series developing a MVC Web application that allows a user to sign up to a newsletter. We first setup the solution in Visual Studio and make adjustments to the default views then update to the current versions of jQuery and bootstrap before starting work on the application. First we create a web form so the user can sign up to our newsletter then we pass the data inputted to the server where we validate it then either return an error or success message. Then we create a database called Newsletter with a table called SignUps and then connect it to our application so we can add the information from a successful sign up to the table. Now we create a model that allows us to map the data from our database to a class so we can allow an admin to see all the signups that are in the database. We also implement a view model in our application so that we can only pass the information to the view that we need.

## Entity Framework
We then take the sample MVC application we refer to above and add the entity framework library to the application so we can use it to map the connection between our newsletter application and our newsletter database, after we add the entity framework library to the application we then refactor all of the ADO.NET database calls with entity framework ones. Then we move onto updating the database by adding a removed column as a datetime type so we can track when people requested to be removed from the mailing list and only send mails to people on the list were the removed property is NULL, then we create a admin controller and move our admin method from the home controller to the new admin controller, then create a new admin view and again move code from the admin view to the new one.

## ASP.NET MVC Entity Framework Assignment
An application that make use of both the MVC, Entity Framework and bootstrap to create a web application which generates a quote for a car insurance website and store the result into a database. We also have an Admin view to show the admin all the quotes that have been issued, (to access this enter: https://localhost:<localport>/Admin/Index in a browser URL). The business logic to generate the quote is a method within the Insuree Controller called GenerateQuote, and the Admin view utilises a View Model called QuotesVms to display all the quote to the site administrator.