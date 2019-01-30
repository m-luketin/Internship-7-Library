using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Domain.Repositories
{
    public class PublisherRepository
    {

        public PublisherRepository(LibraryContext context)
        {
            _context = context;
        }

        private readonly LibraryContext _context;

        public void CreatePublisher(Publisher publisherToAdd)
        {
            _context.Publishers.Add(publisherToAdd);
            _context.SaveChanges();
        }

        public Publisher ReadPublisher(int idToFind)
        {
           return _context.Publishers.Find(idToFind);
        }

        public bool UpdatePublisher(int idOldPublisher, Publisher newPublisher)
        {
            var flag = DeletePublisher(idOldPublisher);

            if(flag)
                CreatePublisher(newPublisher);

            return flag;
        }

        public bool DeletePublisher(int idToDelete)
        {
            if (_context.Publishers.Find(idToDelete) == null)
                return false;
            
            _context.Publishers.Remove(_context.Publishers.Find(idToDelete));
            _context.SaveChanges();
            return true;
        }

        
    }
}
