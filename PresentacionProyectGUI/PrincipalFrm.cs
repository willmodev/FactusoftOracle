using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace PulsacionesGUI
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
            AbrirFormHija(new InicioFrm());
        }
       
        private void RestaurarBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.RestaurarBtn.Visible = false;
            this.MaximizarBtn.Visible = true;

        }

        private void MinimizarBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizarBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizarBtn.Visible = false;
            this.RestaurarBtn.Visible = true;

        }

        private void CerrarBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public  void AbrirFormHija(object formHija)
        {
            if (this.PanelContenedorPnl.Controls.Count > 0)
                this.PanelContenedorPnl.Controls.RemoveAt(0);

            Form form = formHija as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.PanelContenedorPnl.Controls.Add(form);
            this.PanelContenedorPnl.Tag = form;
            form.Show();
        }
        private void productosBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ProductosFrm());
        }


        private void BarraTituloPnl_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWinsows moveWinsows = new MoveWinsows();
            moveWinsows.MoverVentana(this.Handle);
        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ClientesFrm());
        }

        private void FacturarBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FacturaFrm());
        }

        private void InicioBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new InicioFrm());
        }

        private void GestionFacturaBtn_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new GestionarFacturasFrm());
        }
    }
}
