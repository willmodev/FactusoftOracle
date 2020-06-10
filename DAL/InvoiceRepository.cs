using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Entity;

namespace DAL
{
    public class InvoiceRepository
    {
        private readonly OracleConnection oracleConnection;

        public InvoiceRepository(ConnectionManager connection)
        {
            oracleConnection = connection.OracleConnection;
        }


        public void SaveInvoice(Invoice invoice, OracleTransaction oracleTransaction)
        {
            using (var command = oracleConnection.CreateCommand())
            {
                
                command.Transaction = oracleTransaction;

                command.CommandText = "packageInsert.insert_invoice";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("w_Invoice_ID", OracleDbType.Int32).Value = invoice.Invoice_ID;
                command.Parameters.Add("w_SaleDate", OracleDbType.Date).Value = invoice.SaleDate;
                command.Parameters.Add("w_DueDate", OracleDbType.Date).Value = invoice.DueData;
                command.Parameters.Add("w_InvoiceType", OracleDbType.Varchar2).Value = invoice.InvoiceType;
                command.Parameters.Add("w_Cedula", OracleDbType.Varchar2).Value = invoice.Client.Cedula;
                command.Parameters.Add("w_SubTotal", OracleDbType.Decimal).Value = invoice.Subtotal;
                command.Parameters.Add("w_Total_IVA", OracleDbType.Decimal).Value = invoice.TotalIva;
                command.Parameters.Add("w_Total", OracleDbType.Decimal).Value = invoice.Total;

                command.ExecuteNonQuery();

            }
        }

        public void SaveTransaction(Invoice invoice)
        {
            using (OracleTransaction transaction = oracleConnection.BeginTransaction())
            {
                SaveInvoice(invoice, transaction);
                SaveInvoiceDetail(invoice.InvoiceDetails, transaction);
                transaction.Commit();
            }

        }

        public void SaveInvoiceDetail(IList<InvoiceDetail> invoiceDetails, OracleTransaction oracleTransaction)
        {
            foreach (var item in invoiceDetails)
            {
                using (var command = oracleConnection.CreateCommand())
                {
                    command.Transaction = oracleTransaction;

                    command.CommandText = "packageInsert.insert_InvoiceDetail";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("w_Quantity", OracleDbType.Double).Value = item.Quantity;
                    command.Parameters.Add("w_Discount", OracleDbType.Double).Value = item.Discount;
                    command.Parameters.Add("w_IVA", OracleDbType.Decimal).Value =  item.IVA;
                    command.Parameters.Add("w_product_ID", OracleDbType.Varchar2).Value =  item.Product.ID;
                    command.Parameters.Add("w_Invoice_ID", OracleDbType.Int32).Value = item.Invoice_ID;
                    command.Parameters.Add("w_TolalDetail", OracleDbType.Decimal).Value =  item.TolalDetail;

                    command.ExecuteNonQuery();
                }

            }

        }

        public Invoice SearchInvoice()
        {
            OracleDataReader oracleDataReader;
            Invoice invoice = new Invoice();

            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageSelect.selectInvoiceAndClients";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("lista", OracleDbType.RefCursor).Direction =  ParameterDirection.Output;

                oracleDataReader = command.ExecuteReader();

                if (oracleDataReader.Read())
                {
                    invoice = MapInvoice(oracleDataReader);
                    oracleDataReader.Close();
                    invoice.InvoiceDetails = ConsultInvoiceDetail(invoice.Invoice_ID);
                }
                else
                    invoice = null;
            }

            return invoice;
        }

        public IList<InvoiceDetail> ConsultInvoiceDetail(int invoice_id)
        {
            OracleDataReader oracleDataReader;
            IList<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();

            using (var command = oracleConnection.CreateCommand())
            {
                command.CommandText = "packageSelect.selectInvoiceDetailAndProducts";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("w_Invoice_ID", OracleDbType.Int32).Value = invoice_id;
                command.Parameters.Add("lista", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                

                oracleDataReader = command.ExecuteReader();

                if (oracleDataReader.HasRows)
                {
                    while (oracleDataReader.Read())
                    {
                        InvoiceDetail invoiceDetail = MapInvoiceDetail(oracleDataReader);
                        invoiceDetails.Add(invoiceDetail);
                    }
                }
                else
                    invoiceDetails = null;

            }
            oracleDataReader.Close();
            return invoiceDetails;
        }

        public InvoiceDetail MapInvoiceDetail(OracleDataReader oracleDataReader)
        {
            Product product = new Product();
            InvoiceDetail invoiceDetail = new InvoiceDetail();

            product.ID = oracleDataReader.GetString(3);
            product.Name = oracleDataReader.GetString(4);
            product.UnitValue = oracleDataReader.GetDecimal(5);
            product.UnitMeasure = oracleDataReader.GetString(6);
            product.IVA = oracleDataReader.GetDecimal(7);
            product.Quantity = (float)oracleDataReader.GetDouble(8);

            invoiceDetail.Product = product;
            invoiceDetail.Quantity = (float)oracleDataReader.GetDouble(0);
            invoiceDetail.Discount = (float)oracleDataReader.GetDouble(1);
            invoiceDetail.TolalDetail = oracleDataReader.GetDecimal(2);

            return invoiceDetail;
        }

        public Invoice MapInvoice(OracleDataReader oracleDataReader)
        {
            Client client = new Client();
            Invoice invoice = new Invoice();

            invoice.SaleDate = oracleDataReader.GetDateTime(0);
            invoice.DueData = oracleDataReader.GetDateTime(1);
            invoice.InvoiceType = oracleDataReader.GetString(2);
            invoice.Invoice_ID = oracleDataReader.GetInt32(3);
            invoice.Subtotal = oracleDataReader.GetDecimal(4);
            invoice.TotalIva = oracleDataReader.GetDecimal(5);
            invoice.Total = oracleDataReader.GetDecimal(6);

            client.Cedula = oracleDataReader.GetString(7);
            client.FirstName = oracleDataReader.GetString(8);
            client.SecondName = oracleDataReader.GetString(9);
            client.LastName = oracleDataReader.GetString(10);
            client.SecondLastName = oracleDataReader.GetString(11);
            client.Sex = oracleDataReader.GetString(12);
            client.DateOfBorn = oracleDataReader.GetDateTime(13);
            client.Age = oracleDataReader.GetInt32(14);
            client.Telephone = oracleDataReader.GetString(15);
            client.E_mail = oracleDataReader.GetString(16);
            client.AddressHome = oracleDataReader.GetString(17);
            client.Neighborhood = oracleDataReader.GetString(18);

            invoice.Client = client;

            return invoice;

        }

        public int CountInvoice
        {
            get
            {
                using (var command = oracleConnection.CreateCommand())
                {
                    command.CommandText = "packageSelect.countInvoice";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("NumberInvoices", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    var number = int.Parse(((object)command.ExecuteScalar()).ToString());
                    Console.WriteLine("El numero asignado es "+ number);
                    return number;
                }
            }
        }
    }
}
