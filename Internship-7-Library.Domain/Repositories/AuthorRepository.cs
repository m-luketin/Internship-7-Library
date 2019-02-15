using System.Collections.Generic;
using System.Linq;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Domain.Repositories
{
    public class AuthorRepository
    {
        public AuthorRepository()
        {
            _context = new LibraryContext();
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

        public Author ReadAuthor(string fullName)
        {
            var name = ParseAuthor(fullName);
            return Enumerable.FirstOrDefault(_context.Authors, author => name[0] == author.FirstName && name[1] == author.LastName);
        }

        public bool UpdateAuthor(string fullOldName, string fullNewName)
        {
            var flag = false;
            var oldName = ParseAuthor(fullOldName);
            var newName = ParseAuthor(fullNewName);

            foreach (var author in _context.Authors)
            {
                if (oldName[0] == author.FirstName && oldName[1] == author.LastName)
                {
                    flag = true;
                    author.FirstName = newName[0];
                    author.LastName = newName[1];
                }
            }

            _context.SaveChanges();
            return flag;
        }

        public bool DeleteAuthor(string fullName)
        {
            var flag = false;
            var name = ParseAuthor(fullName);

            if (ReadAuthor($"{name[0]} {name[1]}") != null)
            {
                _context.Authors.Remove(ReadAuthor($"{name[0]} {name[1]}"));
                _context.SaveChanges();
                flag = true;
            }

            return flag;
        }

        public List<Author> GetAuthorList()
        {
            return _context.Authors.Select(s => new Author(s.FirstName, s.LastName)).ToList();
        }

        public List<string> ParseAuthor(string fullName)
        {
            var parts = fullName.Split(' ');
            return new List<string>{ string.Join(" ", parts.Take(parts.Length - 1)) , parts.LastOrDefault()};
        }
    }
}
