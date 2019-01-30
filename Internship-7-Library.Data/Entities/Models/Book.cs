using System.Collections.Generic;
using Internship_7_Library.Data.Enums;

namespace Internship_7_Library.Data.Entities.Models
{
    public class Book
    {
        public Book(string name, int numberOfPages, int numberOfBooks)
        {
            Name = name;
            NumberOfBooks = numberOfBooks;
            NumberOfPages = numberOfPages;
        }
        public int BookId { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }
        public int NumberOfBooks { get; set; }
        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Borrow> Borrows { get; set; }
    }
}
