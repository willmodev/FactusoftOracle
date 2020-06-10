using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InvoiceDetail
    {
        public int Invoice_ID { get; set; }
        public Product Product { get; set; }
        public string NameProduct {get;set;}
        public decimal UnitValue { get; set; }
        public float Quantity { get; set; }
        public float Discount { get; set; }
        public decimal IVA { get; set; }
        public decimal TolalDetail { get; set; }

       
        public InvoiceDetail(Product product, float quantity, float discount)
        {
            Product = product;
            NameProduct = product.Name;
            UnitValue = product.UnitValue;
            Quantity = quantity;
            Discount = discount;
            IVA = product.IVA;
            CalculateTotalDetail();
            CalculateIva();
        }

        public InvoiceDetail() {}

        public void CalculateTotalDetail()
        {
            
            TolalDetail = Decimal.Round((((decimal)Quantity) * Product.UnitValue) * (1 - ((decimal)Discount/100)), 1);
        }


        public decimal CalculateIva()
        {
            return TolalDetail * (Product.IVA  / 100) ;
        }

    }
}
