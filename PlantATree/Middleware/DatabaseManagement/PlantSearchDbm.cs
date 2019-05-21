using MySql.Data.MySqlClient;
using PlantATree.Models;
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

        public PlantInfo GetPlantInfo()
        {
            MySqlConnection conn = new MySqlConnection(
                _user +
                _pass +
                _server +
                _database +
                _timeout);

            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Plants WHERE id = 3;";

            MySqlDataReader read = cmd.ExecuteReader();

            read.Read();

            PlantInfo retPlant = new PlantInfo()
            {
                Id = read.GetInt32("id"),
                Name = read.GetString("name"),
                Description = read.GetString("desc"),
                MaintReq = read.GetString("maintReq"),
                Price = read.GetDouble("price"),
                Category = ConvertStrToCate(read.GetString("cate")),
                SoilDrain = ConvertStrToSoil(read.GetString("soilDrain")),
                Sun = ConvertStrToSun(read.GetString("sun")),
                Maint = ConvertStrToMaint(read.GetString("maint")),
                MaxHeight = read.GetInt32("maxHeight"),
                GrowthRate = ConvertStrToGrowthRate(read.GetString("growthRate"))
            };

            read.Close();
            conn.Close();

            return retPlant;
        }


        //*******************************************************
        //For getting database enums and converting to PlantEnums
        //*******************************************************
        private Category ConvertStrToCate(String str)
        {
            return (Category) Enum.Parse(typeof(Category), str);
        }

        private SoilDrain ConvertStrToSoil(String str)
        {
            return (SoilDrain)Enum.Parse(typeof(SoilDrain), str);
        }

        private Sun ConvertStrToSun(String str)
        {
            return (Sun)Enum.Parse(typeof(Sun), str);
        }

        private Maint ConvertStrToMaint(String str)
        {
            return (Maint)Enum.Parse(typeof(Maint), str);
        }

        private GrowthRate ConvertStrToGrowthRate(String str)
        {
            return (GrowthRate)Enum.Parse(typeof(GrowthRate), str);
        }

    }
}
