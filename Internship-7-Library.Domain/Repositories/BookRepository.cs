using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Domain.Repositories
{
    public class BookRepository
    {
        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        private readonly LibraryContext _context;

        public void CreateBook(Book bookToAdd)
        {
            _context.Books.Add(bookToAdd);
            _context.SaveChanges();
        }

        public Book ReadBook(int idToFind)
        {
            return _context.Books.Find(idToFind);
        }

        public bool UpdateBook(int idOldBook, Book newBook)
        {
            var flag = DeleteBook(idOldBook);

            if(flag)
                CreateBook(newBook);

            return flag;
        }

        public bool DeleteBook(int idToDelete)
        {
            if (_context.Books.Find(idToDelete) == null)
                return false;

            _context.Books.Remove(_context.Books.Find(idToDelete));
            _context.SaveChanges();
            return true;
        }
    }
}
