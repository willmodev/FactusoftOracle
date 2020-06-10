using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entity;
using System.IO;

namespace Infrastructure
{
    public class DocumentPDF
    {
        public void savePDF(Invoice invoice, string path)
        {
            FileStream fileStream = new FileStream(path,FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER,42,42,42,42);
            PdfWriter pdfWriter = PdfWriter.GetInstance(document,fileStream);

            document.AddAuthor("Aplicacion Factusoft");
            document.Open();
            var MyFont = FontFactory.GetFont("Arial", 12, Font.BOLD);
            Paragraph paragraph = new Paragraph("FACTUSOFT - SAN SEBASTIAN\n\n\n", MyFont);
            paragraph.Alignment =  Element.ALIGN_CENTER;
            document.Add(paragraph);
            document.Add(new Paragraph($"N° Factura: {invoice.Invoice_ID} \n"));
            document.Add(new Paragraph($"Tipo Factura: {invoice.InvoiceType} \n"));
            document.Add(new Paragraph($"Fecha Venta: {invoice.SaleDate} \n"));
            document.Add(new Paragraph($"Fecha Vencimiento: {invoice.DueData} \n"));
            document.Add(new Paragraph($"Cliente: {invoice.Client.FirstName} {invoice.Client.LastName} \n"));
            document.Add(new Paragraph($"Cedula: {invoice.Client.Cedula} \n\n\n"));
            document.Add(FillTable(invoice.InvoiceDetails));
            document.Add(new Paragraph("\n\n"));
            document.Add(new Paragraph($"Sub Total: {invoice.Subtotal.ToString("C")} \n"));
            document.Add(new Paragraph($"Total IVA: {invoice.TotalIva.ToString("C")} \n"));

           
            document.Add(new Paragraph($"Total Factura: {invoice.Total.ToString("C")} \n", MyFont));

            document.Close();
        }

        private PdfPTable FillTable(IList<InvoiceDetail> invoiceDetails)
        {
            
            PdfPTable pdfPTable = new PdfPTable(7);
            float[] widths = new float[] { 30f, 40f, 90f, 55f, 32f, 30f, 35f };
            pdfPTable.SetWidths(widths);

            var MyFont = FontFactory.GetFont("Arial", 12, Font.BOLD);
            pdfPTable.AddCell(new Paragraph("Cant.", MyFont));
            pdfPTable.AddCell(new Paragraph("Unidad", MyFont));
            pdfPTable.AddCell(new Paragraph("Descripcion", MyFont));
            pdfPTable.AddCell(new Paragraph("Valor Unit", MyFont));
            pdfPTable.AddCell(new Paragraph("Desc", MyFont));
            pdfPTable.AddCell(new Paragraph("IVA", MyFont));
            pdfPTable.AddCell(new Paragraph("Total",MyFont));

            foreach (var item in invoiceDetails)
            {
                pdfPTable.AddCell(new Paragraph(item.Quantity.ToString()));
                pdfPTable.AddCell(new Paragraph(item.Product.UnitMeasure.ToString()));
                pdfPTable.AddCell(new Paragraph(item.Product.Name.ToString()));
                pdfPTable.AddCell(new Paragraph(item.Product.UnitValue.ToString()));
                pdfPTable.AddCell(new Paragraph(item.Discount.ToString()));
                pdfPTable.AddCell(new Paragraph(item.Product.IVA.ToString()));
                pdfPTable.AddCell(new Paragraph(item.TolalDetail.ToString()));
            }

            return pdfPTable;
        }
    }
}
