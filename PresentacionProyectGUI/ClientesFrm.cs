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
using BLL;
using System.Configuration;

namespace PulsacionesGUI
{
    public partial class ClientesFrm : Form
    {
        private ClientService clientService;
        private AdministratorService adminService;

        public ClientesFrm()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            clientService = new ClientService(connectionString);
            adminService = new AdministratorService(connectionString);
        }

        private Administrator MapOutAdministrator()
        {
            GetAdministratorAnswer answer = adminService.GetAdministrator();

            if(!answer.Error)
            {
                if (answer.Admin == null) MessageBox.Show(answer.Message);
            }else
            {
                MessageBox.Show(answer.Message);
            }

            return answer.Admin;
        }

        private Client MapOutClient()
        {
            Client client = new Client();

            client.FirstName = TxtFistName.Text;
            client.SecondName = TxtSocondName.Text == "" ? "None" : TxtSocondName.Text;
            client.LastName = TxtLastName.Text;
            client.SecondLastName = TxtSecondLastName.Text;
            client.Cedula = TxtCedula.Text;
            client.Sex = CmbSex.Text;
            client.DateOfBorn = DtpDateOfBorn.Value;
            client.Telephone = TxtTelephone.Text;
            client.E_mail = TxtEmail.Text;
            client.AddressHome = TxtAddressHome.Text;
            client.Neighborhood = TxtNeighborhood.Text;
            client.City = TxtCity.Text;
            
            return client;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveClientAnswer answerClient = clientService.Save(MapOutClient(), MapOutAdministrator());
            MessageBox.Show(answerClient.Message);
            FillTable();
            EmptyTextBoxes();
            TxtCedula.Focus();
        }

        private void BtnRemove_Click_1(object sender, EventArgs e)
        {
            bool accept = Meesage("Seguro que desea eliminar este cliente", "Mensaje de confirmacion");
            if (accept) MessageBox.Show(clientService.Remove(TxtCedula.Text));
            EnabledComponets(true);
            FillTable();
            ChangeStatus();
        }

        private bool Meesage(string message, string caption)
        {
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (result == DialogResult.Yes) ? true : false;

        }

        private string FillTable()
        {
            ConsultClientAnswer  answer = clientService.Consult();
            DgvTableClients.DataSource = null;
            DgvTableClients.DataSource = answer.Clients;

            DgvTableClients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            return answer.Message;

        }
        private void ChangeStatus()
        {
            EmptyTextBoxes();
            TxtCedula.Focus();
            DisplayButtons(false, false, true);
        }

        public void EmptyTextBoxes()
        {
            FillTextBoxes("", "", "", "", "","","","","","","","");
        }


        private void FillTextBoxes(string firstName, string secondName, string lastName, string secondLastName, string cedula, string sex,
                                   string dateOfBorn, string telephone, string email, string addressHome, string neighborhood, string city)
        {
            TxtFistName.Text = firstName;
            TxtSocondName.Text = secondName;
            TxtLastName.Text = lastName;
            TxtSecondLastName.Text = secondLastName;
            TxtCedula.Text = cedula;
            CmbSex.Text = sex;
            DtpDateOfBorn.Text = dateOfBorn;
            TxtTelephone.Text = telephone;
            TxtEmail.Text = email;
            TxtAddressHome.Text = addressHome;
            TxtNeighborhood.Text = neighborhood;
            TxtCity.Text = city;


        }

        private void DisplayButtons(bool remove, bool modify, bool save)
        {
            BtnRemove.Visible = remove;
            BtnModify.Visible = modify;
            BtnSave.Visible = save;
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {

            SearchClienttAnswer answer = clientService.Search(TxtSearch.Text);
            Client client = answer.Client;

            if (client != null)
            {
                FillTextBoxes
                (
                  client.FirstName,
                  client.SecondName,
                  client.LastName,
                  client.SecondLastName,
                  client.Cedula,
                  client.Sex,
                  client.DateOfBorn.ToString(),
                  client.Telephone,
                  client.E_mail,
                  client.AddressHome,
                  client.Neighborhood,
                  client.City
                );
                DisplayButtons(true, false, false);
            }
            else MessageBox.Show(answer.Message);

            EnabledComponets(false);
            TxtSearch.Text = "";
            TxtSearch.Focus();
        
        }

        private void BtnModify_Click_1(object sender, EventArgs e)
        {
            ConsultClientAnswer answer = clientService.Consult();
            Client client = MapOutClient();
            MessageBox.Show(clientService.Modify(client));
            EnabledComponets(true);
            ChangeStatus();
            FillTable();
        }
      

        private void TxtCedula_MouseClick(object sender, MouseEventArgs e)
        {
            DisplayButtons(false, false, true);
        }

       

        private void TextBoxes_ModifiedChanged(object sender, EventArgs e)
        {
            ModifyControls();
        }

        private void CmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModifyControls();
        }

        private void ModifyControls()
        {
            if (BtnSave.Visible == false) DisplayButtons(false, true, false);
        }

       

        private void TxtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            EmptyTextBoxes();
            AlterModified();
            DisplayButtons(false, false, false);
        }

        private void AlterModified()
        {
            TxtFistName.Modified = false;
            TxtSocondName.Modified = false;
            TxtLastName.Modified = false;
            TxtSecondLastName.Modified = false;
            TxtCedula.Modified = false;
            TxtTelephone.Modified = false;
            TxtEmail.Modified = false;
            TxtAddressHome.Modified = false;
            TxtNeighborhood.Modified = false;
            TxtCity.Modified = false;

        }

        private void BtnShowList_Click(object sender, EventArgs e)
        {
            if (DgvTableClients.Visible == false)
            {
                DgvTableClients.Visible = true;
                MessageBox.Show(FillTable());
            }
            else
                DgvTableClients.Visible = false;

        }

        private void DgvTableClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0)
             {
                DataGridViewRow row = this.DgvTableClients.Rows[e.RowIndex];


                TxtFistName.Text = row.Cells[0].Value.ToString();
                TxtSocondName.Text = row.Cells[1].Value.ToString();
                TxtLastName.Text = row.Cells[2].Value.ToString();
                TxtSecondLastName.Text = row.Cells[3].Value.ToString();
                TxtCedula.Text = row.Cells[4].Value.ToString();
                CmbSex.Text = row.Cells[5].Value.ToString();
                DtpDateOfBorn.Text = row.Cells[6].Value.ToString();
                TxtTelephone.Text = row.Cells[7].Value.ToString();
                TxtEmail.Text = row.Cells[8].Value.ToString();
                TxtAddressHome.Text = row.Cells[9].Value.ToString();
                TxtNeighborhood.Text = row.Cells[10].Value.ToString();
                TxtCity.Text = row.Cells[11].Value.ToString();
                EnabledComponets(false);
                AlterModified();
                DisplayButtons(true, false, false);
             }

        }

        public void EnabledComponets(bool isEnable)
        {
            TxtCedula.Enabled = isEnable;
            DtpDateOfBorn.Enabled = isEnable;
        }

       
    }
}
