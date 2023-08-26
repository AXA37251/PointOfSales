//added references to perform the BD connection (windowsSQL)
//added references to perform BD connection through Npgsql
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable GetUsers()
        {
            string query = "SELECT * FROM BDUsers";
            NpgsqlCommand executableQuery = new NpgsqlCommand(query, connection);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(executableQuery);
            DataTable usersTable = new DataTable();
            dataAdapter.Fill(usersTable);

            return usersTable;
        }
        public DataTable GetInfoUsers_UserDocument()
        {
            string query = "SELECT \"user\", name, lastname, dni FROM BDUsers";
            NpgsqlCommand executableQuery = new NpgsqlCommand(query, connection);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(executableQuery);
            DataTable usersTable = new DataTable();
            dataAdapter.Fill(usersTable);

            return usersTable;
        }

        public int AddUser(string user, string password, string name, string lastname, string dni, string phone)
        {
            int affectedUsers;
            Connect();
            //using (NpgsqlConnection connection = new NpgsqlConnection())
            //{
                //Connect();

                string query = "INSERT INTO " +
                "BDUsers (\"user\", password, name, lastname, dni, phone)" +
                " VALUES('" + user + "','" + password + "','" + name + "','" + lastname + "','" + dni + "','" + phone + "');";
                
                NpgsqlCommand executableQuery = new NpgsqlCommand(query, connection);
                affectedUsers = executableQuery.ExecuteNonQuery();
            //}
            Disconnect();
            return affectedUsers;
        }
        public int EditUser(string user, string password, string name, string lastname, string dni, string phone) 
        {
            int affectedUsers;
            Connect();
            //using (NpgsqlConnection connection = new NpgsqlConnection())
            //{
                string query = "UPDATE BDUsers " +
                    "SET " + //\"user\" = '" + user + "'," +
	                    "password = '" + password + "', " +
                        "name = '" + name + "'," +
                        "lastname = '" + lastname + "', " +
                        "dni = '" + dni + "', " +
                        "phone = '" + phone + "' " +
                    "WHERE \"user\" = '"+ user + "'";

            NpgsqlCommand executableQuery = new NpgsqlCommand(query, connection);
            affectedUsers = executableQuery.ExecuteNonQuery();
            //}
            Disconnect();
            return affectedUsers;
        }
        public int DeleteUser(string dni) 
        {
            int affectedUsers = 0;
            //using (NpgsqlConnection connection = new NpgsqlConnection())
            //{
            Connect();

                string query = "DELETE FROM BDUsers " +
                    "WHERE dni = '" + dni + "';";

            NpgsqlCommand executableQuery = new NpgsqlCommand(query, connection);
            affectedUsers = executableQuery.ExecuteNonQuery();
            //}
            Disconnect();
            return affectedUsers;
        }
    }
}
