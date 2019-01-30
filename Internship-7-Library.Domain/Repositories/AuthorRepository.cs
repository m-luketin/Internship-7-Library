using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Domain.Repositories
{
    public class AuthorRepository
    {
        public static List<Author> AllAuthors = new List<Author>()
        {
            new Author(1, "Mark", "Twain"),
            new Author(2, "Stephen", "King"),
            new Author(3, "Fyodor", "Dostoevsky"),
            new Author(4, "Jordan", "Peterson"),
            new Author(5, "Khalil", "Gibran"),
            new Author(5, "Carlos", "Castaneda"),
            new Author(6, "Neil", "Tyson")
        };
        
            
        
    }
}
