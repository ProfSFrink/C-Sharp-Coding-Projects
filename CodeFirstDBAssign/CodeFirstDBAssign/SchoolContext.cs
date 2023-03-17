// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// FINAL PROJECT: Final Assignment - Code First Database Assignment
// AUTHOR: Steven Partlow
// DATE: 17/03/2023

// SCHOOL CONTEXT CLASS DEFINITION

using System.Data.Entity;

namespace CodeFirstDBAssign
{

    class SchoolContext: DbContext // Inherit the DBContext class, so we can use the DbSet type
    {

        public SchoolContext(): base() // Class constructor
        {

        } // End SchoolContext CONSTRUCTOR

        public DbSet<Student> Students { get; set; } // Students, an array of the Student class, the DbSet data type indicates that we want this to be part of our database
        public DbSet<Grade> Grades { get; set; } // Grades, an array of the Grades class. the DbSet data type indicates that we want this to be part of our database

    } // End SchoolContext CLASS

} // End CodeFirstDBAssign NAMESPACE
