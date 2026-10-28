using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDBUSer.database
{
    public class DBConnect
    {
        private readonly string BasicConnString;


        public DBConnect()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .AddUserSecrets(Assembly.GetExecutingAssembly(), optional: true)
                .Build();

            BasicConnString = config["BasicConnString"];
        }

        public SqlConnection GetOpenDBConnection(string user, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(BasicConnString)
            {
                UserID = user,
                Password = password
            };

            string DBConnString = builder.ConnectionString;
            Console.WriteLine(DBConnString);

            SqlConnection connection = new SqlConnection(DBConnString);
            connection.Open();
            return connection;
        }


        
    }
}
