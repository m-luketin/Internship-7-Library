using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Domain.Repositories
{
    public class BorrowRepository
    {
        public BorrowRepository(LibraryContext context)
        {
            _context = context;
        }

        private readonly LibraryContext _context;

        public void CreateBorrow(Borrow borrowToAdd)
        {
            _context.Borrows.Add(borrowToAdd);
            _context.SaveChanges();
        }

        public Borrow ReadBorrow(int idToFind)
        {
            return _context.Borrows.Find(idToFind);
        }

        public bool UpdateBorrow(int idOldBorrow, Borrow newBorrow)
        {
            var flag = DeleteBorrow(idOldBorrow);

            if(flag)
                CreateBorrow(newBorrow);

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
    }
}
