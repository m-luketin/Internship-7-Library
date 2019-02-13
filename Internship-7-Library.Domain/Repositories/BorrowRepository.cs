using System;
using System.Collections.Generic;
using System.Linq;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Domain.Repositories
{
    public class BorrowRepository
    {
        public BorrowRepository()
        {
            _context = new LibraryContext();
        }

        private readonly LibraryContext _context;

        public void CreateBorrow(Student borrowingStudent, Book borrowedBook, DateTime dateOfBorrow)
        {
            _context.Borrows.Add(new Borrow(borrowingStudent.StudentId, borrowedBook.BookId, dateOfBorrow));
            _context.SaveChanges();
        }

        public bool ReturnBorrow(int studentId, int bookId, DateTime returnDate)
        {
            var flag = false;
            foreach (var borrow in _context.Borrows)
            {
                if (borrow.BookId == bookId && studentId == borrow.StudentId)
                {
                    borrow.ReturnDate = returnDate;
                    flag = true;
                }
            }

            if (flag)
                _context.SaveChanges();

            return flag;
        }

        public bool DeleteBorrow(int idToDelete)
        {
            if (_context.Borrows.Find(idToDelete) == null)
                return false;

            _context.Borrows.Remove(_context.Borrows.Find(idToDelete));
            _context.SaveChanges();
            return true;
        }

        public List<Borrow> GetBorrowsList()
        {
            return _context.Borrows.Select(s => new Borrow(s.Student, s.Book, s.BorrowDate)).ToList();
        }
    }
}
