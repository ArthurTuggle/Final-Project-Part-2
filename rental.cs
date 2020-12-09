using System;
using System;
namespace RentalApp
{
    internal class Rental
    {
        public Book Book;
        public DateTime DateRented;
        public DateTime DateDue;

        
        public Rental(Book book, DateTime dateDue)
        {
            Book = book;
            DateRented = DateTime.Today;
            DateDue = dateDue;
        }
    }
}