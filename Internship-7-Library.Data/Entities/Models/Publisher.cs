using System.Collections.Generic;

namespace Internship_7_Library.Data.Entities.Models
{
    public class Publisher
    {
        public Publisher(int publisherId, string name)
        {
            PublisherId = publisherId;
            Name = name;
        }
        public int PublisherId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
