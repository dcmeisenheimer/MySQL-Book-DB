using System;

namespace MySQLVideo
{
    public class ConnectionString //Server Connection Info
    {
        public string cs {get; set;}

        public ConnectionString() //store the heroku connection variables
        {
            string server = "x8autxobia7sgh74.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "ozq76y2wm2yt4axm";
            string port = "3306";
            string userName = "vhqfo1b5plazljxi";
            string password = "d1t74j5x6medxlcd";

            cs = $@"server = {server}; user = {userName}; database = {database}; port = {port}; password = {password};"; //sets the connection
        }
    }
}
