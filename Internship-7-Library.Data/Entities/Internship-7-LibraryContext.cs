using Internship_7_Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Internship_7_Library.Data.Entities
{
    public class LibraryContext : DbContext
    {

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LibraryDatabase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Borrow>()
                .HasOne(brw => brw.Book)
                .WithMany(bk => bk.Borrows)
                .HasForeignKey(me => me.BookId);
            modelBuilder.Entity<Borrow>()
                .HasOne(brw => brw.Student)
                .WithMany(s => s.Borrows)
                .HasForeignKey(brw => brw.StudentId);
            
        }
    }
}
