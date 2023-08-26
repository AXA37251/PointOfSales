//reference to datalayer BDConnection
using DataLayer;
using System.Data;
using System.Security.Cryptography;

namespace LogicLayer
{
    public class Connection
    {
        readonly DataLayer.BDConnection connection = new DataLayer.BDConnection();

        public int BDConnect(string user, string pass)
        {
            return connection.ConnectionAttempt(user, pass);
        }
        public DataTable GetUsers()
        {
            return connection.GetUsers();
        }
        public DataTable GetInfoUsers_UserDocument()
        {
            return connection.GetInfoUsers_UserDocument();
        }
        public int LogicAddUser(string user, string password, string name, string lastname, string dni, string phone)
        {
            return connection.AddUser(user,password,name,lastname,dni,phone);
        }
        public int LogicEditUser(string user, string password, string name, string lastname, string dni, string phone)
        {
            return connection.EditUser(user, password, name, lastname, dni, phone);
        }
        public int LogicDeleteUser(string dni)
        {
            return connection.DeleteUser(dni);
        }

    }




}
