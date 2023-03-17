// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// FINAL PROJECT: Final Assignment - Code First Database Assignment
// AUTHOR: Steven Partlow
// DATE: 17/03/2023

using System;
using CodeFirstDBAssign;

namespace CodeFirstDbAssign
{

    class Program
    {

        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {

                var stud = new Student() { StudentName = "Steven" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.WriteLine("Student successfully added to the database.");
                Console.ReadKey();   

            } // End USING

        } // End MAIN

    } // End Program CLASS

} // End CodeFirstDbAssign NAMESPACE
