using System;
using MySQLVideo.database;
using MySQLVideo.models;

namespace MySQLVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            // DeleteBook.DropBookTable();
            // SaveBook.CreateBookTable();

            Book myBook = new Book(){Title = "Oathbringer", Author = "Brandon Sanderson"};

            myBook.Save.CreateBook(myBook);
        }
    }
}
