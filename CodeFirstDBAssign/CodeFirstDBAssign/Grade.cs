// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// FINAL PROJECT: Final Assignment - Code First Database Assignment
// AUTHOR: Steven Partlow
// DATE: 17/03/2023

// GRADE CLASS DEFINITION

using System.Collections.Generic;

namespace CodeFirstDBAssign
{

    /* The Grade class will be a template to create a Grade table in our database, and have a relationship to the Student table */
    class Grade
    {

        public int GradeId { get; set; } // GradeId, a integer variable which will be the Grade tables primary key
        public string GradeName { get; set; } // GradeName, a string variable which will be the name the of the subject that the student has been graded for
        public string Section { get; set; } // Section, a string variable

        public ICollection<Student> Students { get; set; } // Students, A ICollection Interface collection to represent the Students in our database

    } // End Grade CLASS 

} // End CodeFirstDBAssign NAMESPACE
