using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udraw
{
    public class DatabaseConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public string GetConnectionString()
        {
            return $"Host={Host};Port={Port};Username={Username};Password={Password};Database={Database}";
        }

        private static DatabaseConfig _instance;

        public static DatabaseConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                   
                    _instance = new DatabaseConfig
                    {
                        Host = "localhost",
                        Port = 5432,
                        Username = "your_username",
                        Password = "your_password",
                        Database = "your_database"
                    };
                }
                return _instance;
            }
        }
    }
}
