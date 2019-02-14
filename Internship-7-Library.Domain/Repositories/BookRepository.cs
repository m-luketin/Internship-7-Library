using System.Collections.Generic;
using System.Linq;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;
using Internship_7_Library.Data.Enums;

namespace Internship_7_Library.Domain.Repositories
{
    public class BookRepository
    {
        public BookRepository()
        {
            _context = new LibraryContext();
        }

        private readonly LibraryContext _context;

        public bool CreateBook(string bookName, Author author, Publisher publisher, int numberOfPages, int numberOfBooks, Genre genre)
        {
            if (Enumerable.Any(_context.Books, book => bookName == book.Name))
                return false;

            _context.Books.Add(new Book(bookName, _context.Authors.Find(author.AuthorId), _context.Publishers.Find(publisher.PublisherId),numberOfPages, numberOfBooks, genre));
            _context.SaveChanges();
            return true;
        }

        public Book ReadBook(string nameToFind)
        {
            foreach (var book in _context.Books)
            {
                if (book.Name == nameToFind)
                    return book;
            }

            return null;
        }

        public bool UpdateBook(string oldName, string newName, Author newAuthor, Publisher newPublisher, int newNumberOfPages, int newNumberOfCopies, Genre newGenre)
        {
            var flag = false;
            
            foreach (var book in _context.Books)
            {
                if (oldName == book.Name)
                {
                    book.Name = newName;
                    book.Author = _context.Authors.Find(newAuthor.AuthorId);
                    book.Publisher = _context.Publishers.Find(newPublisher.PublisherId);
                    book.NumberOfPages = newNumberOfPages;
                    book.NumberOfBooks = newNumberOfCopies;
                    book.Genre = newGenre;
                    flag = true;
                }
            }

            _context.SaveChanges();
            return flag;
        }

        public bool DeleteBook(string nameToDelete)
        {
            var flag = false;
            foreach (var book in _context.Books)
            {
                if (nameToDelete == book.Name)
                {
                    flag = true;
                    _context.Books.Remove(book);

                }
            }

            _context.SaveChanges();
            return flag;
        }

        public List<Book> GetBooksList()
        {
            return _context.Books.Select(s => new Book(s.Name, s.Author, s.Publisher, s.NumberOfPages, s.NumberOfBooks, s.Genre)).ToList();
        }
    }
}
