using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
   
    public class ClientRepository
    {
        private readonly OracleConnection oracleConnection;
        public ClientRepository(ConnectionManager connection)
        {
            oracleConnection = connection.OracleConnection;
        }

        public void Save(Client client)
        {
            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = @"packageInsert.insert_client";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("w_firstName", OracleDbType.Varchar2).Value = client.FirstName;
                command.Parameters.Add("w_secondName", OracleDbType.Varchar2).Value = client.SecondName;
                command.Parameters.Add("w_lastName", OracleDbType.Varchar2).Value = client.LastName;
                command.Parameters.Add("w_secondLastName", OracleDbType.Varchar2).Value = client.SecondLastName;
                command.Parameters.Add("w_cedula", OracleDbType.Varchar2).Value = client.Cedula;
                command.Parameters.Add("w_sex", OracleDbType.Char).Value = client.Sex;
                command.Parameters.Add("w_dateOfBorn", OracleDbType.Date).Value = client.DateOfBorn;
                command.Parameters.Add("w_Age", OracleDbType.Int32).Value =  client.Age;
                command.Parameters.Add("w_Telephone", OracleDbType.Varchar2).Value = client.Telephone;
                command.Parameters.Add("w_E_mail", OracleDbType.Varchar2).Value = client.E_mail;
                command.Parameters.Add("w_AddressHome", OracleDbType.Varchar2).Value = client.AddressHome;
                command.Parameters.Add("w_Neighborhood", OracleDbType.Varchar2).Value = client.Neighborhood;
                command.Parameters.Add("w_City", OracleDbType.Varchar2).Value = client.City;
                command.ExecuteNonQuery();


            }
        }

        public bool Remove(string cedula)
        {
            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageDelete.deleteClient";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("w_cedula", OracleDbType.Varchar2).Value = cedula;
                return Math.Abs(command.ExecuteNonQuery()) > 0;
            }
        }

        public IList<Client> Consult()
        {
            OracleDataReader oracleDataReader;
            IList<Client> clients = new List<Client>();
            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageSelect.selectClients";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("lista", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                oracleDataReader = command.ExecuteReader();

                if (oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        Client client = DataReaderMapToClient(oracleDataReader);
                        clients.Add(client);
                    }
                }
            }

            return clients;
        }

        private Client DataReaderMapToClient(OracleDataReader oracleDataReader)
        {
            if (!oracleDataReader.HasRows) return null;

            Client client = new Client();

            client.FirstName = oracleDataReader.GetString(0);
            client.SecondName = oracleDataReader.GetString(1);
            client.LastName = oracleDataReader.GetString(2);
            client.SecondLastName = oracleDataReader.GetString(3);
            client.Cedula = oracleDataReader.GetString(4);
            client.Sex = oracleDataReader.GetString(5);
            client.DateOfBorn = oracleDataReader.GetDateTime(6);
            client.Age = (int)oracleDataReader.GetInt32(7);
            client.Telephone = oracleDataReader.GetString(8);
            client.E_mail = oracleDataReader.GetString(9);
            client.AddressHome = oracleDataReader.GetString(10);
            client.Neighborhood = oracleDataReader.GetString(11);
            client.City = oracleDataReader.GetString(12);


            return client;
        }

        public Client Search(string cedula)
        {
            OracleDataReader oracleDataReader;
            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageSelect.selectClient";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("cliente", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("w_cedula", OracleDbType.Varchar2).Value = cedula;
                oracleDataReader = command.ExecuteReader();

                return oracleDataReader.Read() ? DataReaderMapToClient(oracleDataReader) : null;

            }
        }

        public bool Modify(Client client)
        {
            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageUpdate.updateClient";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("w_firstName", OracleDbType.Varchar2).Value = client.FirstName;
                command.Parameters.Add("w_secondName", OracleDbType.Varchar2).Value = client.SecondName;
                command.Parameters.Add("w_lastName", OracleDbType.Varchar2).Value = client.LastName;
                command.Parameters.Add("w_secondLastName", OracleDbType.Varchar2).Value = client.SecondLastName;
                command.Parameters.Add("w_cedula", OracleDbType.Varchar2).Value = client.Cedula;
                command.Parameters.Add("w_sex", OracleDbType.Char).Value = client.Sex;
                command.Parameters.Add("w_dateOfBorn", OracleDbType.Date).Value = client.DateOfBorn;
                command.Parameters.Add("w_Age", OracleDbType.Int32).Value = client.Age;
                command.Parameters.Add("w_Telephone", OracleDbType.Varchar2).Value = client.Telephone;
                command.Parameters.Add("w_E_mail", OracleDbType.Varchar2).Value = client.E_mail;
                command.Parameters.Add("w_AddressHome", OracleDbType.Varchar2).Value = client.AddressHome;
                command.Parameters.Add("w_Neighborhood", OracleDbType.Varchar2).Value = client.Neighborhood;
                command.Parameters.Add("w_City", OracleDbType.Varchar2).Value = client.City;

                OracleTransaction transaction = oracleConnection.BeginTransaction();
                var filas = command.ExecuteNonQuery();
                transaction.Commit();
                return Math.Abs(filas) > 0;
                
            }
        }
    }
}
