using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.RepresentationModel;
using Npgsql;

namespace Udraw
{
    internal static class Program
    {
        private static string GetConnectionStringPartValue(string[] parts, string key)
        {
            foreach (var part in parts)
            {
                var keyValue = part.Split('=');
                if (keyValue.Length == 2 && keyValue[0].Trim().Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    return keyValue[1].Trim();
                }
            }
            return null;
        }

        private static int GetConnectionStringPartIntValue(string[] parts, string key)
        {
            string stringValue = GetConnectionStringPartValue(parts, key);
            if (int.TryParse(stringValue, out int result))
            {
                return result;
            }
            return 0;
        }

        private static string GetStringValue(YamlMappingNode node, string key)
        {
            if (node.Children.ContainsKey(new YamlScalarNode(key)) && node.Children[new YamlScalarNode(key)] is YamlScalarNode scalarNode)
            {
                return scalarNode.Value;
            }

            return null;
        }

        private static int GetIntValue(YamlMappingNode node, string key)
        {
            if (node.Children.ContainsKey(new YamlScalarNode(key)) && node.Children[new YamlScalarNode(key)] is YamlScalarNode scalarNode)
            {
                if (int.TryParse(scalarNode.Value, out int result))
                {
                    return result;
                }
            }

            return 0;
        }



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            string cnnString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            Console.WriteLine(cnnString);


            var connectionStringParts = cnnString.Split(';');

            // Create a DatabaseConfig object and set its properties
            var databaseConfig = new DatabaseConfig
            {
                Host = GetConnectionStringPartValue(connectionStringParts, "Host"),
                Port = GetConnectionStringPartIntValue(connectionStringParts, "Port"),
                Username = GetConnectionStringPartValue(connectionStringParts, "username"),
                Password = GetConnectionStringPartValue(connectionStringParts, "password"),
                Database = GetConnectionStringPartValue(connectionStringParts, "Database")
            };

            Console.WriteLine($"Host: {databaseConfig.Host}");
            Console.WriteLine($"Port: {databaseConfig.Port}");
            Console.WriteLine($"Username: {databaseConfig.Username}");
            Console.WriteLine($"Password: {databaseConfig.Password}");
            Console.WriteLine($"Database: {databaseConfig.Database}");

            string connectionString = $"Host={databaseConfig.Host};Port={databaseConfig.Port};Username={databaseConfig.Username};Password={databaseConfig.Password};Database={databaseConfig.Database}";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Database connection established successfully!");
                    // Continue with other database-related tasks...
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error connecting to the database: {ex.Message}");
                }
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenu());
        }

    }
}
