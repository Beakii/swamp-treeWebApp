using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PlantATree.Models;

namespace PlantATree.Middleware.DatabaseManagement
{
    
    public class UserAccountDbm
    {
        private readonly string _user, _pass, _server, _database, _timeout;

        public UserAccountDbm()
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
                Id = int.Parse(read["id"].ToString()),
                Username = read["username"].ToString(),
                Password = read["password"].ToString(),
                Fname = read["fname"].ToString(),
                Lname = read["lname"].ToString(),
                Address = read["address"].ToString(),
                EMail = read["email"].ToString()
            };

            read.Close();
            conn.Close();

            return retAcc;
        }

        public List<UserAccount> GetAllUsers()
        {
            List<UserAccount> retList = new List<UserAccount>();

            MySqlConnection conn = new MySqlConnection(
                _user +
                _pass +
                _server +
                _database +
                _timeout);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Users;";

            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                retList.Add(new UserAccount()
                {
                    Id = int.Parse(read["id"].ToString()),
                    Username = read["username"].ToString(),
                    Password = read["password"].ToString(),
                    Fname = read["fname"].ToString(),
                    Lname = read["lname"].ToString(),
                    Address = read["address"].ToString(),
                    EMail = read["email"].ToString()
                });
            }

            read.Close();
            conn.Close();

            return retList;
        }

        public void AddNewUserAccount(UserAccount acc)
        {
            MySqlConnection conn = new MySqlConnection(
                _user +
                _pass +
                _server +
                _database +
                _timeout);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Users(username, password, fname, lname, address, email)" +
                "VALUES('"+ acc.Username + "','"+ acc.Password + "','"+ acc.Fname + "','"+ acc.Lname + "','"+ acc.Address + "','"+ acc.EMail + "');";

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public bool UserLogin(UserAccount acc)
        {
            MySqlConnection conn = new MySqlConnection(
                _user +
                _pass +
                _server +
                _database +
                _timeout);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Users WHERE username LIKE '" + acc.Username + "' AND password = '"+acc.Password+"';";

            MySqlDataReader read = cmd.ExecuteReader();

            if(read.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
