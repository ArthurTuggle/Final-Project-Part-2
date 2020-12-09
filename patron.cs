using System;
using System.Collections.Generic;

namespace RentalApp
{
    internal class Patron:Person
    {
        string libraryId;
        DateTime startDate;
        DateTime endDate;
        bool isAccountActive;
        List<Rental> rentalCart;
        double fineAmountDue;
   
        public Patron(string firstName, string lastName, string libraryId) : base(firstName, lastName)
        {
            
            this.fineAmountDue = 0;
            this.libraryId = libraryId;
            this.startDate = DateTime.Today;
            this.isAccountActive = true;
            rentalCart = new List<Rental>();
        }        
        public void Display()
        {
         Console.WriteLine("Patron Id us=" + this.libraryId + " Name is=" + base.FirstName + " " + base.LastName);
        }
        public void AddToRentalCart(Book book, DateTime dateDue)
        {
            
            Rental obj = new Rental(book, dateDue);
            
            rentalCart.Add(obj);
            Console.WriteLine("Added to the rental cart " + book.BookName + " Book " + book.BookId + " for the Patron " + base.FirstName + " " + base.LastName);
        }        
        public void RemoveFromRentalCart(Book book)
        {
            for (int i = 0; i < rentalCart.Count; i++)
            {
                if (rentalCart[i].Book.BookId.Equals(book.BookId) && rentalCart[i].Book.BookName.Equals(book.BookName))
                {
                    
                    rentalCart.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine("Removed from rental cart " + book.BookName + " Book " + book.BookId + " for Patron " + base.FirstName + " " + base.LastName);
        }
    }
}