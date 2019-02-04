using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;
using Internship_7_Library.Data.Enums;

namespace Internship_7_Library.Domain.Repositories
{
    public class StudentRepository
    {
        public StudentRepository(LibraryContext context)
        {
            _context = context;
        }

        private readonly LibraryContext _context;

        public bool CreateStudent(string firstName, string lastName, DateTime dateOfBirth, Sex sex, Grade grade)
        {
            if (Enumerable.Any(_context.Students, student => firstName == student.FirstName && lastName == student.LastName))
                return false;

            _context.Students.Add(new Student(firstName, lastName, dateOfBirth, sex, grade));
            _context.SaveChanges();
            return true;
        }

        public Student ReadStudent(string fullNameToFind)
        {
            var name = ParseStudent(fullNameToFind);
            return Enumerable.FirstOrDefault(_context.Students, student => name[0] == student.FirstName && name[1] == student.LastName);
        }

        public bool UpdateStudent(string fullOldName, Student newStudent)
        {
            var flag = false;
            var oldName = ParseStudent(fullOldName);
            foreach (var student in _context.Students)
            {
                if (oldName[0] == student.FirstName && oldName[1] == student.LastName)
                {
                    flag = true;
                    student.FirstName = newStudent.FirstName;
                    student.LastName = newStudent.LastName;
                    student.BirthDate = newStudent.BirthDate;
                    student.Sex = newStudent.Sex;
                    student.Grade = newStudent.Grade;
                }
            }

            _context.SaveChanges();
            return flag;
        }

        public bool DeleteStudent(string fullNameToDelete)
        {
            var name = ParseStudent(fullNameToDelete);
            var flag = false;
            
            if (ReadStudent($"{name[0]} {name[1]}") != null)
            {
                _context.Students.Remove(ReadStudent($"{name[0]} {name[1]}"));
                _context.SaveChanges();
                flag = true;
            }

            return flag;
        }
        public List<Student> GetStudentsList()
        {
            return _context.Students.Select(s => new Student(s.FirstName, s.LastName, s.BirthDate, s.Sex, s.Grade)).ToList();
        }
        public List<string> ParseStudent(string fullName)
        {
            var parts = fullName.Split(' ');
            return new List<string> { string.Join(" ", parts.Take(parts.Length - 1)), parts.LastOrDefault() };
        }
    }
}
