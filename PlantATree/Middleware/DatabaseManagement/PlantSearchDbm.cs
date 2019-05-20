using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Middleware.DatabaseManagement
{
    public class PlantSearchDbm
    {
        private readonly string _user, _pass, _server, _database, _timeout;

        public PlantSearchDbm()
        {
            _user = "user id=3Rq4HGj0ys;";
            _pass = "password=VYGDugLkGf;";
            _server = "server=37.59.55.185;"; //remotemysql.com
            _database = "database=3Rq4HGj0ys;";
            _timeout = "connection timeout=10";
        }


    }
}
