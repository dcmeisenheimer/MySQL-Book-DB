using System;
using MySQLVideo.models;

namespace MySQLVideo.interfaces
{
    public interface ISaveBook //Interface to allow us to save book
    {
        public void CreateBook(Book myBook);
        public void SaveBook(Book myBook);
    }
}
