//added references to perform the BD connection (windowsSQL)
//added references to perform BD connection through Npgsql
using Npgsql;
using System;
//added references to use Output message
using System.Windows;

namespace DataLayer
{
    public class BDConnection
    {
        NpgsqlConnection connection =
        new NpgsqlConnection(
            "Server = localhost; " +
            "User Id = postgres; " +
            "Password = admin; " +
            "Database = projectPOS"
        );

        public void Connect()
        {
            connection.Open();
            MessageBox.Show("connection established successfully");
        }

        public int ConnectionAttempt(string user, string password)
        {
            int counter;

            connection.Open();

            string query = "SELECT COUNT(*) " +
                "FROM \"User\"" +
                "WHERE \'user\' = '" + user + "' AND " +
                "\'password\' = '" + password + "'";

            NpgsqlCommand executableQuery = new NpgsqlCommand(query, connection);
            counter = Convert.ToInt32(executableQuery.ExecuteScalar());

            if (counter == 1)
            {

            }
            return 0;
        }
    }
}
