using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Domain.Repositories
{
    class PublisherRepository
    {
        public static List<Publisher> AllPublishers = new List<Publisher>()
        {
            new Publisher(1, "Penguin"),
            new Publisher(2, "Pearson"),
            new Publisher(3, "ThomsonReuters"),
            new Publisher(4, "Scholastic"),
            new Publisher(5, "Wiley"),
            new Publisher(5, "Cambridge University Press")
        };

    }
}
