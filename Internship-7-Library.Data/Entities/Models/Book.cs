using System.Collections.Generic;
using Internship_7_Library.Data.Enums;

namespace Internship_7_Library.Data.Entities.Models
{
    public class Book
    {
        public Book(string name, Author author, Publisher publisher, int numberOfPages, int numberOfBooks, Genre genre)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
            NumberOfBooks = numberOfBooks;
            NumberOfPages = numberOfPages;
            Genre = genre;
        }
        public Book()
        {
            
        }
        public int BookId { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public int NumberOfPages { get; set; }
        public int NumberOfBooks { get; set; }
        public Genre Genre { get; set; }
        
        public ICollection<Borrow> Borrows { get; set; }


        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
