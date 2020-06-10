using BLL;
using Entity;
using System;
using System.Configuration;
using System.Windows.Forms;
namespace PulsacionesGUI
{
    public partial class ListaProductosFrm : Form
    {
        private readonly ProductService productService;
        public ListaProductosFrm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            productService = new ProductService(connectionString);
            ShowList();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWinsows moveWinsows = new MoveWinsows();
            moveWinsows.MoverVentana(this.Handle);

        }

        private void ShowList()
        {
            ConsultProductAnswer answer = productService.Consult();
            DgvProductsList.DataSource = null;
            DgvProductsList.DataSource = answer.Products;
            MessageBox.Show(answer.Message);

        }

        private void DgvProductsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FacturaFrm facturaFrm = Owner as FacturaFrm;



                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.DgvProductsList.Rows[e.RowIndex];


                    facturaFrm.TxtID.Text = row.Cells[0].Value.ToString();
                    facturaFrm.TxtName.Text = row.Cells[1].Value.ToString();
                    facturaFrm.TxtUnitValue.Text = row.Cells[2].Value.ToString();
                    facturaFrm.TxtUnitMeasure.Text = row.Cells[3].Value.ToString();
                    facturaFrm.TxtWarehouseQuantity.Text = row.Cells[4].Value.ToString();
                    facturaFrm.TxtIVA.Text = row.Cells[5].Value.ToString();
                    facturaFrm.TxtQuantity.Text = "0";
                    facturaFrm.TxtDiscount.Text = "0";

                }

            
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto Seleccionado!");
            this.Close();
        }

       
    }
}
