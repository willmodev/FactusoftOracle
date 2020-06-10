using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class AdministratorRepository
    {
        private readonly OracleConnection oracleConnection;

        public AdministratorRepository(ConnectionManager connection)
        {
            oracleConnection = connection.OracleConnection;
        }


        public bool Login(Administrator administrator)
        {
            OracleDataReader oracleDataReader;

            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageSelect.validate_user";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("validationLogin", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("w_userName", OracleDbType.Varchar2).Value =  administrator.User;
                command.Parameters.Add("w_passwordName", OracleDbType.Varchar2).Value = administrator.Password;

                oracleDataReader = command.ExecuteReader();

               return oracleDataReader.HasRows;


            }
        }

        public Administrator GetAdministrator()
        {
            OracleDataReader oracleDataReader;

            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageSelect.selectAdministrator";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("lista", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                oracleDataReader = command.ExecuteReader();

                return oracleDataReader.Read() ? DataReaderMapToAdministrator(oracleDataReader) : null;
            }
        }

        public Administrator DataReaderMapToAdministrator(OracleDataReader oracleDataReader)
        {
            if (!oracleDataReader.HasRows) return null;

            Administrator admin = new Administrator();

            admin.User = oracleDataReader.GetString(0);
            admin.Password = oracleDataReader.GetString(1);
            admin.Email = oracleDataReader.GetString(2);
            admin.PasswordEmail = oracleDataReader.GetString(3);

            return admin;
        }

    }
}
