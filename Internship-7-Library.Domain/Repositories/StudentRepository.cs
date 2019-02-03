using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Domain.Repositories
{
    public class StudentRepository
    {
        public StudentRepository(LibraryContext context)
        {
            _context = context;
        }

        private readonly LibraryContext _context;

        public bool CreateStudent(Student studentToAdd)
        {
            if (Enumerable.Any(_context.Students, student => studentToAdd.FirstName == student.FirstName && studentToAdd.LastName == student.LastName))
                return false;

            _context.Students.Add(studentToAdd);
            _context.SaveChanges();
            return true;
        }

        public Student ReadStudent(int idToFind)
        {
            return _context.Students.Find(idToFind);
        }

        public bool UpdateStudent(int idOldStudent, Student newStudent)
        {
            var flag = DeleteStudent(idOldStudent);

            if(flag)
                CreateStudent(newStudent);

            return flag;
        }

        public bool DeleteStudent(int idToDelete)
        {
            if (_context.Students.Find(idToDelete) == null)
                return false;

            _context.Students.Remove(_context.Students.Find(idToDelete));
            _context.SaveChanges();
            return true;
        }
    }
}
