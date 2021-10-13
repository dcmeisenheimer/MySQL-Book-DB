using System;
using MySql.Data.MySqlClient;
using MySQLVideo.interfaces;

namespace MySQLVideo.database
{
    public class DeleteBook : IDeleteBook
    {
        public static void DropBookTable() //same as before you are just dropping if books exists but using mysql
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP TABLE IF EXISTS books";

            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
        }
        void IDeleteBook.DeleteBook(int id)
        {
            throw new NotImplementedException();
        }
    }
}
