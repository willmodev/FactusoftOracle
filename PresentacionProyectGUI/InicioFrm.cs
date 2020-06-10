using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionesGUI
{
    public partial class InicioFrm : Form
    {
        public InicioFrm()
        {
            InitializeComponent();
        }

        private void HoraYFechaTimer_Tick(object sender, EventArgs e)
        {
            horaLbl.Text = DateTime.Now.ToString("h:mm:ss");
            fechaLbl.Text = DateTime.Now.ToLongDateString();
        }
    }
}
