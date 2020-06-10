using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using Entity;

namespace PulsacionesGUI
{
    public partial class ProductosFrm : Form
    {
        ProductService productService;
        
        public ProductosFrm()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            productService = new ProductService(connectionString);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Product product = MapOutProduct();
            MessageBox.Show(productService.Save(product));
            FillTable();
            EmptyTextBoxes();
            TxtID.Focus();
        }

        private Product MapOutProduct()
        {
            Product product = new Product();

            product.ID = TxtID.Text;
            product.Name = TxtName.Text;
            product.UnitValue = decimal.Parse( TxtUnitValue.Text);
            product.UnitMeasure = CmbUnitMeasure.Text;
            product.Quantity = float.Parse(TxtQuantity.Text);
            product.IVA = decimal.Parse(TxtIVA.Text);

            return product;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            bool accept = Meesage("Seguro que desea eliminar este producto", "Mensaje de confirmacion");
            if (accept) MessageBox.Show(productService.Remove(TxtID.Text));
            FillTable();
            ChangeStatus();

        }

        private bool Meesage(string message, string caption)
        {
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (result == DialogResult.Yes) ? true : false;
               
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchProductAnswer answer = productService.Search(TxtSearch.Text);
            Product product = answer.Product;

            if (product != null)
            {
                FillTextBoxes
                (
                   product.ID,
                   product.Name,
                   product.UnitValue.ToString(),
                   product.UnitMeasure,
                   product.Quantity.ToString(),
                   product.IVA.ToString()
                );
                DisplayButtons(true,false,false);
            }
            else MessageBox.Show(answer.Message);

            TxtSearch.Text = "";
            TxtSearch.Focus();
        }


        private void BtnModify_Click(object sender, EventArgs e)
        {
            ConsultProductAnswer answer = productService.Consult();
            Product product = MapOutProduct();
            MessageBox.Show(productService.Modify(product));
            ChangeStatus();
            FillTable();
        }


        private void FillTextBoxes(string id, string name, string unitValue, string unitMeasure, string quantity, string iva)
        {
            TxtID.Text = id;
            TxtName.Text = name;
            TxtUnitValue.Text = unitValue;
            CmbUnitMeasure.Text = unitMeasure;
            TxtQuantity.Text = quantity;
            TxtIVA.Text = iva;

        }
        

        private void EmptyTextBoxes()
        {
            FillTextBoxes("","","","","","");
        }

        private void DisplayButtons(bool remove, bool modify, bool save)
        {
            BtnRemove.Visible = remove;
            BtnModify.Visible = modify;
            BtnSave.Visible = save;
        }

        private void TxtID_MouseClick(object sender, MouseEventArgs e)
        {
            DisplayButtons(false,false,true);
        }

        private void TxtBoxes_ModifiedChanged(object sender, EventArgs e)
        {
            ModifyControls();
        }

        private void CmbUnitMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModifyControls();
        }

        private void ModifyControls()
        {
            if (BtnSave.Visible == false) DisplayButtons(false, true, false);
        }

        private void ChangeStatus()
        {
            EmptyTextBoxes();
            TxtID.Focus();
            DisplayButtons(false,false,true);
        }

        private void TxtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            EmptyTextBoxes();
            AlterModified();
            DisplayButtons(false, false, false);
        }

        private void AlterModified()
        {
            TxtID.Modified = false;
            TxtName.Modified = false;
            TxtUnitValue.Modified = false;
            TxtQuantity.Modified = false;
            TxtIVA.Modified = false;

           
        }

        private void BtnShowList_Click(object sender, EventArgs e)
        {
            if (DgvTableProducts.Visible == false)
            {
                DgvTableProducts.Visible = true;
                MessageBox.Show(FillTable());
            }
            else
                DgvTableProducts.Visible = false;

        }

        private string FillTable()
        {
            ConsultProductAnswer answer = productService.Consult();
            DgvTableProducts.DataSource = null;
            DgvTableProducts.DataSource = answer.Products;
            
            DgvTableProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            return answer.Message;

        }

        private void DgvTableProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DgvTableProducts.Rows[e.RowIndex];

              
                TxtID.Text = row.Cells[0].Value.ToString();
                TxtName.Text = row.Cells[1].Value.ToString();
                TxtUnitValue.Text = row.Cells[2].Value.ToString();
                CmbUnitMeasure.Text = row.Cells[3].Value.ToString();
                TxtQuantity.Text = row.Cells[4].Value.ToString();
                TxtIVA.Text = row.Cells[5].Value.ToString();

                AlterModified();
                DisplayButtons(true, false, false);
            }

        }

      
    }
}
