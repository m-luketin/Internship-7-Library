using System.Collections.Generic;
using System.Linq;
using Internship_7_Library.Data.Entities;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Domain.Repositories
{
    public class PublisherRepository
    {

        public PublisherRepository()
        {
            _context = new LibraryContext();
        }

        private readonly LibraryContext _context;

        public bool CreatePublisher(string publisherNameToAdd)
        {
            if (Enumerable.Any(_context.Publishers, publisher => publisherNameToAdd == publisher.Name))
                return false;
          
            _context.Publishers.Add(new Publisher(publisherNameToAdd));

            _context.SaveChanges();
            return true;
        }

        public Publisher ReadPublisher(string nameToFind)
        {
            return Enumerable.FirstOrDefault(_context.Publishers, publisher => publisher.Name == nameToFind);
        }

        public bool UpdatePublisher(string oldName, string newName)
        {
            var flag = false;
            foreach (var publisher in _context.Publishers)
            {
                if (oldName == publisher.Name)
                {
                    flag = true;
                    publisher.Name = newName;
                }
            }

            _context.SaveChanges();
            return flag;
        }

        public bool DeletePublisher(string nameToDelete)
        {
            var flag = false;
            foreach (var publisher in _context.Publishers)
            {
                if (nameToDelete == publisher.Name)
                {
                    flag = true;
                    _context.Publishers.Remove(publisher);
                    
                }    
            }

            _context.SaveChanges();
            return flag;
        }

        public List<Publisher> GetPublisherList()
        {
            return _context.Publishers.Select(s => new Publisher(s.Name)).ToList(); 
        }
    }
}
