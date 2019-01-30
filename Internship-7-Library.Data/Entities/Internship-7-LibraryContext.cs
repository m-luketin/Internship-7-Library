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
        public LibraryContext(DbContextOptions options) : base(options)
        {}

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
                .HasForeignKey(me => me.Book);
            modelBuilder.Entity<Borrow>()
                .HasOne(brw => brw.Student)
                .WithMany(s => s.Borrows)
                .HasForeignKey(brw => brw.Student);

            modelBuilder.Entity<Book>()
                .HasOne(bk => bk.Author)
                .WithMany(au => au.Books)
                .HasForeignKey(bk => bk.Author);
            modelBuilder.Entity<Book>()
                .HasOne(bk => bk.Publisher)
                .WithMany(pb => pb.Books)
                .HasForeignKey(bk => bk.Publisher);
        }
    }
}
