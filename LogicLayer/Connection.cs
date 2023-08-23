//reference to datalayer BDConnection

namespace LogicLayer
{
    public class Connection
    {
        readonly DataLayer.BDConnection connection = new DataLayer.BDConnection();

        public int BDConnect(string user, string pass)
        {
            return connection.ConnectionAttempt(user, pass);
        }
    }
}
