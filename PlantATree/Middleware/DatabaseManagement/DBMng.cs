using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PlantATree.Models;

namespace PlantATree.Middleware.DatabaseManagement
{
    
    public class DBMng
    {
        private readonly string _user, _pass, _server, _database, _timeout;

        public DBMng()
        {
            _user = "user id=3Rq4HGj0ys;";
            _pass = "password=VYGDugLkGf;";
            _server = "server=37.59.55.185;"; //remotemysql.com
            _database = "database=3Rq4HGj0ys;";
            _timeout = "connection timeout=10";
        }

        public UserAccount GetUserInfo(int id)
        {

            MySqlConnection conn = new MySqlConnection(
                _user+
                _pass+
                _server+
                _database+
                _timeout);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Users WHERE id = " + id + ";";

            MySqlDataReader read = cmd.ExecuteReader();

            read.Read();

            UserAccount retAcc = new UserAccount()
            {
                id = int.Parse(read["id"].ToString()),
                username = read["username"].ToString(),
                password = read["password"].ToString(),
                fname = read["fname"].ToString(),
                lname = read["lname"].ToString(),
                address = read["address"].ToString(),
                email = read["email"].ToString(),
            };

            read.Close();
            conn.Close();

            return retAcc;
        }
    }
}
