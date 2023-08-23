//added references to perform the BD connection (windowsSQL)
//added references to perform BD connection through Npgsql
using Npgsql;
using System;
//added references to use Output message
using System.Windows;
using System.Windows.Controls.Primitives;

namespace DataLayer
{
    public class BDConnection
    {
        readonly NpgsqlConnection connection =
        new NpgsqlConnection(
            "Server = localhost; " +
            "User Id = postgres; " +
            "Password = admin; " +
            "Database = projectPOS"
        );

        public void Connect()
        {
            connection.Open();
            //MessageBox.Show("connection established successfully");
        }
        public void Disconnect() {
            connection.Close();
        }

        public int ConnectionAttempt(string user, string password)
        {
            int counter;
            Connect();
            string query = "SELECT COUNT(*) " +
                "FROM BDUsers" +
                " WHERE BDUsers.user = '" + user + "'" +
                " AND BDUsers.password = '" + password + "'";

            NpgsqlCommand executableQuery = new NpgsqlCommand(query, connection);
            counter = Convert.ToInt32(executableQuery.ExecuteScalar());
            Disconnect();
            return counter;
        }
    }
}
