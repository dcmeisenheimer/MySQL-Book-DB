using System;
using MySql.Data.MySqlClient;
using MySQLVideo.interfaces;
using MySQLVideo.models;

namespace MySQLVideo.database
{
    public class SaveBook : ISaveBook
    {
        public static void CreateBookTable()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE books(id INTEGER PRIMARY KEY AUTO_INCREMENT, title TEXT, author TEXT)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
        }
        public void CreateBook(Book myBook)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO books(title, author) VALUES(@title, @author)";//are parameters that can pass (title, author)

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@title", myBook.Title);
            cmd.Parameters.AddWithValue("@author", myBook.Author);

            cmd.Prepare();

            cmd.ExecuteNonQuery();

        }

        void ISaveBook.SaveBook(Book myBook)
        {
            throw new NotImplementedException();
        }
    }
}
