using System.Collections.Generic;

namespace Internship_7_Library.Data.Entities.Models
{
    public class Author
    {
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
