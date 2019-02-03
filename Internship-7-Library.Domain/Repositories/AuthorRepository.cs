using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Domain.Repositories
{
    public class AuthorRepository
    {
        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }

        private readonly LibraryContext _context;

        public bool CreateAuthor(string firstName, string lastName)
        {
            if (Enumerable.Any(_context.Authors, author => firstName == author.FirstName && lastName == author.LastName))
                return false;

            _context.Authors.Add(new Author(firstName, lastName));
            _context.SaveChanges();
            return true;
        }

        public Author ReadAuthor(string firstName, string lastName)
        {
            return Enumerable.FirstOrDefault(_context.Authors, author => firstName == author.FirstName && lastName == author.LastName);
        }

        

        public bool UpdateAuthor(string oldFirstName, string oldLastName, string newFirstName, string newLastName)
        {
            var flag = false;
            foreach (var author in _context.Authors)
            {
                if (oldFirstName == author.FirstName && oldLastName == author.LastName)
                {
                    flag = true;
                    author.FirstName = newFirstName;
                    author.LastName = newLastName;
                }
            }

            _context.SaveChanges();
            return flag;
        }

        public bool DeleteAuthor(string firstName, string lastName)
        {
            var flag = false;
            if (ReadAuthor(firstName, lastName) != null)
            {
                _context.Authors.Remove(ReadAuthor(firstName,lastName));
                _context.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public List<Author> GetAuthorList()
        {
            return _context.Authors.Select(s => new Author(s.FirstName, s.LastName)).ToList();
        }
    }
}
