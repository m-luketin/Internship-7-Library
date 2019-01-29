using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_7_Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Internship_7_Library.Data.Entities
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BloggingContext"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Borrow>()
                .HasOne(me => me.Book)
                .WithMany(m => m.Borrows)
                .HasForeignKey(me => me.BookId);
            modelBuilder.Entity<Borrow>()
                .HasOne(me => me.Student)
                .WithMany(m => m.Borrows)
                .HasForeignKey(me => me.StudentId);
        }
    }
}
