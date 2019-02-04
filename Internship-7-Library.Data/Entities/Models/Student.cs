using System;
using System.Collections.Generic;
using Internship_7_Library.Data.Enums;

namespace Internship_7_Library.Data.Entities.Models
{
    public class Student
    {
        public Student(string firstName, string lastName, DateTime birthDate, Sex sex, Grade grade)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Sex = sex;
            Grade = grade;
        }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; } 
        public Grade Grade { get; set; }
        public ICollection<Borrow> Borrows { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
