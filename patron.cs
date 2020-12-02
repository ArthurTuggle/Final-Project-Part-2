using System;
using System.Collections.Generic;

namespace RentalApp
{
    internal class Patron : Person
    {
        string libraryId;
        DateTime startDate;
        DateTime endDate;
        bool isAccountActive;
        List<Rental> rentalCart;
        int fineAmountDue;

        //Patron constructor that also calls base class constructor
        public Patron(string firstName, string lastName, string libraryId) : base(firstName, lastName)
        {
            //initializing values
            this.fineAmountDue = 0;
            this.libraryId = libraryId;
            this.startDate = DateTime.Today;
            this.isAccountActive = true;
            rentalCart = new List<Rental>();
        }

        //display method
        public void Display()
        {
            Console.WriteLine("Patron Id=" + this.libraryId + " Name=" + base.FirstName + " " + base.LastName);
        }

        //addToRentalCart method
        public void AddToRentalCart(Book book, DateTime dateDue)
        {
            //creating Rental object
            Rental obj = new Rental(book, dateDue);
            //adding to rentalCart list
            rentalCart.Add(obj);
            Console.WriteLine("Added to rental cart " + book.BookName + " Book " + book.BookId + " for Patron " + base.FirstName + " " + base.LastName);
        }

        //removeFromRentalCart method
        public void RemoveFromRentalCart(Book book)
        {
            for (int i = 0; i < rentalCart.Count; i++)
            {
                if (rentalCart[i].Book.BookId.Equals(book.BookId) && rentalCart[i].Book.BookName.Equals(book.BookName))
                {
                    //removing from rentalCart list
                    rentalCart.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine("Removed from rental cart " + book.BookName + " Book " + book.BookId + " for Patron " + base.FirstName + " " + base.LastName);
        }
    }
}