using System;
using System.Collections.Generic;
using System.Linq;

namespace Entity
{
    public class Invoice
    {
        public int Invoice_ID { get; set; }
        public Client Client { get; set; }
        public string  InvoiceType { get;set; }
        public decimal Subtotal { get; set; }
        public decimal TotalIva { get; set; }
        public decimal Total { get; set; }
        public DateTime SaleDate { get; set; }
        public DateTime DueData { get; set; }

        public IList<InvoiceDetail> InvoiceDetails;

        public Invoice()
        {
            InvoiceDetails = new List<InvoiceDetail>();
        }

        public void AgregarDetalleFactura(Product product, float quantity, float discount)
        {
            InvoiceDetail invoicedetail = new InvoiceDetail(product, quantity, discount);
            invoicedetail.Invoice_ID = this.Invoice_ID;
            InvoiceDetails.Add(invoicedetail);
        }
        public void CalculateSubtotal()
        {
            Subtotal = InvoiceDetails.Sum(d => d.TolalDetail);
        }

        public void CalcularTotalIva()
        {
            TotalIva = InvoiceDetails.Sum(d => d.CalculateIva());
        }

        public void CalculaTeTotal()
        {
            CalculateSubtotal();
            CalcularTotalIva();
           
            Total = Subtotal + TotalIva ;
        }



    }
}
