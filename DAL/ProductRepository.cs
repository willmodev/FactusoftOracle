using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Data;
namespace DAL
{
    public class ProductRepository
    {
        private readonly OracleConnection oracleConnection;
        

        public ProductRepository(ConnectionManager connection)
        {

            oracleConnection = connection.OracleConnection;
            
        }

        public void Save(Product product)
        {
            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = @"packageInsert.insert_product";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("w_Product_ID", product.ID);
                command.Parameters.Add("w_Descripcion", product.Name);
                command.Parameters.Add("w_UnitValue", product.UnitValue);
                command.Parameters.Add("w_UnitMeasure", product.UnitMeasure);
                command.Parameters.Add("w_Quantity", product.Quantity);
                command.Parameters.Add("w_IVA", product.IVA);

                command.ExecuteNonQuery();


            }
        }

        public bool Remove(string ID)
        {
            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageDelete.deleteProduct";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("w_Product_ID", OracleDbType.Varchar2).Value = ID;
                
                return Math.Abs(command.ExecuteNonQuery()) > 0;
            }
        }

        public IList<Product> Consult()
        {
            OracleDataReader oracleDataReader;
            IList<Product> products = new List<Product>();
            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Products";
                oracleDataReader = command.ExecuteReader();

                if (oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        Product product = DataReaderMapToProduct(oracleDataReader);
                        products.Add(product);
                    }
                }
            }

            return products;
        }

        private Product DataReaderMapToProduct(OracleDataReader oracleDataReader)
        {
            if (!oracleDataReader.HasRows) return null;

            Product product = new Product();

            product.ID = oracleDataReader.GetString(0);
            product.Name = oracleDataReader.GetString(1);
            product.UnitValue = oracleDataReader.GetDecimal(2);
            product.UnitMeasure = oracleDataReader.GetString(3);
            product.Quantity = (float)oracleDataReader.GetDouble(4);
            product.IVA = oracleDataReader.GetDecimal(5);

            return product;
        }

        public Product Search(string ID)
        {
            OracleDataReader oracleDataReader;
            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageSelect.selectProduct";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Product", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("w_Product_ID", OracleDbType.Varchar2).Value = ID;
                
                
                oracleDataReader = command.ExecuteReader();

                return oracleDataReader.Read() ? DataReaderMapToProduct(oracleDataReader) : null;

            }
        }
        
        public bool Modify(Product product)
        {
           
            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageUpdate.updateProduct";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("w_Product_ID", OracleDbType.Varchar2).Value = product.ID;
                command.Parameters.Add("w_Descripcion", OracleDbType.Varchar2).Value = product.Name;
                command.Parameters.Add("w_UnitValue", OracleDbType.Decimal).Value = product.UnitValue;
                command.Parameters.Add("w_UnitMeasure", OracleDbType.Varchar2).Value = product.UnitMeasure;
                command.Parameters.Add("w_Quantity", OracleDbType.Double).Value = product.Quantity;
                command.Parameters.Add("w_IVA", OracleDbType.Decimal).Value = product.IVA;

                OracleTransaction transaction = oracleConnection.BeginTransaction();
                var filas = command.ExecuteNonQuery();
                transaction.Commit();
                return Math.Abs(filas) > 0;
                
            }

           
        }


    }
}
