using System;
using System.Collections.Generic;
using Internship_7_Library.Data.Enums;

namespace Internship_7_Library.Data.Entities.Models
{
    public class Student
    {
        public Student(string firstName, string lastName, DateTime birthDate, Sex sex, Class inClass)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Sex = sex;
            Class = inClass;
        }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; } 
        public Class Class { get; set; }
        public ICollection<Borrow> Borrows { get; set; }
    }
}
