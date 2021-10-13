using System;
using MySQLVideo.database;
using MySQLVideo.interfaces;

namespace MySQLVideo.models
{
    public class Book //properties of book 
    {
        public string Title{get; set;}
        public string Author{get; set;}

        public ISaveBook Save {get; set;}

        public Book()
        {
            Save = new SaveBook();
        }
    }
}
