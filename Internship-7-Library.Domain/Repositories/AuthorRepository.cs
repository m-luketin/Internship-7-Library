﻿using System;
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

        public void CreateAuthor(Author authorToAdd)
        {
            _context.Authors.Add(authorToAdd);
            _context.SaveChanges();
        }

        public Author ReadAuthor(int idToFind)
        {
            return _context.Authors.Find(idToFind);
        }

        public bool UpdateAuthor(int idOldAuthor, Author newAuthor)
        {
            var flag = DeleteAuthor(idOldAuthor);

            if(flag)
                CreateAuthor(newAuthor);

            return flag;
        }

        public bool DeleteAuthor(int idToDelete)
        {
            if (_context.Authors.Find(idToDelete) == null)
                return false;

            _context.Authors.Remove(_context.Authors.Find(idToDelete));
            _context.SaveChanges();
            return true;
        }

    }
}