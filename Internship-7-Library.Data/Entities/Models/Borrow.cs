using System;

namespace Internship_7_Library.Data.Entities.Models
{
    public class Borrow
    {
        public Borrow(Student student, Book book, DateTime borrowDate, DateTime? returnDate)
        {
            StudentId = student.StudentId;
            Student = student;
            BookId = book.BookId;
            Book = book;
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
        }

        public Borrow()
        {

        }

        public int BorrowId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
