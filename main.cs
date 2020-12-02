using System;

namespace RentalApp
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
            //creating 3 books
            var book1 = new Book(1, "Harry Potter");
            var book2 = new Book(2, "Harry Potter");
            var book3 = new Book(3, "Harry Potter");
            //creating 5 patrons
            var p1 = new Patron("Tim", "Smith", "1111");
            var p2 = new Patron("Connor", "Walsh", "2222");
            var p3 = new Patron("Ken", "Adams", "3333");
            var p4 = new Patron("Cisco", "Ramon", "4444");
            var p5 = new Patron("Oliver", "Queen", "5555");
            p1.AddToRentalCart(book3, DateTime.Parse("12/08/2020"));
            //adding book 1 to patron 1's rental cart
            p1.AddToRentalCart(book1, DateTime.Parse("12/15/2020"));
            //removing book 3 from patron 1's rental cart
            p1.RemoveFromRentalCart(book3);
            //displaying patron info
            p1.Display();

            Console.Read();
        }
    }
}