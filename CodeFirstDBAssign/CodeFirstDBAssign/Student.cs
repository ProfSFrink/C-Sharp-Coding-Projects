// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// FINAL PROJECT: Final Assignment - Code First Database Assignment
// AUTHOR: Steven Partlow
// DATE: 17/03/2023

// STUDENT CLASS DEFINITION

using System;

namespace CodeFirstDBAssign
{

    /* This Student class will be used as a template to create a student table in our database, will also have a one-to-many relationship with the grade table */

    class Student
    {

        public int StudentID { get; set; } // The Student ID property, an integer variable which will be the Student tables primary key
        public string StudentName { get; set; } // StudentName, a string property representing the students name
        public DateTime? DateOfBirth { get; set; } // DateOfBirth, DateTime property representing the students date of birth
        public byte[] Photo { get; set; } // Photo, an array of bytes to store an image, a picture of the student
        public decimal Height { get; set; } // Heigh, a decimal variable representing the students height
        public float Weight { get; set; } // Weight, a float variable representing the students weight

        public Grade Grade { get; set; } // Grade, an instance of the grade class repsresenting the students grades

    } // End Student CLASS

} // End CodeFirstDBAssign NAMESPACE
