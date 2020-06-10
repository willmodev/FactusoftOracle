using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;
namespace DAL
{
    public class ConnectionManager
    {
        internal OracleConnection OracleConnection;

        public ConnectionManager(string connectionString)
        {
            OracleConnection = new OracleConnection(connectionString);
        }


        public void OpenConnection()
        {
            OracleConnection.Open();
        }

        public void CloseConnection()
        {
            OracleConnection.Close();
        }
    }
}
