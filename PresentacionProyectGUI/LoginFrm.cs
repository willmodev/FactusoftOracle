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
    public partial class LoginFrm : Form
    {

        private AdministratorService administratorService;
        public LoginFrm()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            administratorService = new AdministratorService(connectionString);
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWinsows moveWinsows = new MoveWinsows();
            moveWinsows.MoverVentana(this.Handle);
        }

        

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "user") TxtUser.Text = "";
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "password") TxtPassword.Text = "";

                TxtPassword.UseSystemPasswordChar = true;
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUser.Text == "") TxtUser.Text = "user";
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {

            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "password";
                TxtPassword.UseSystemPasswordChar = false;
            }
                




        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text != "user")
            {
                if (TxtPassword.Text != "password")
                {
                    Administrator administrator = new Administrator(TxtUser.Text,TxtPassword.Text);
                    LoginAnswer  answer = administratorService.Login(administrator);

                    if (answer.Error == false)
                    {
                        if (answer.ValidData)
                        {
                            PrincipalFrm principalFrm = new PrincipalFrm();
                            principalFrm.Show();
                            this.Hide();
                        }
                        else
                        {
                            answer.Message = "Usuario y/o Contraseña incorrecta. intente de nuevo!";
                            MessageError(answer.Message);
                            TxtPassword.Clear();
                            TxtPassword.Focus();

                        }
                    }
                    else MessageBox.Show(answer.Message);


                }
                else MessageError("Por favor digite su CONTRASEÑA");

            }
            else MessageError("Por favor digite su USUARIO");

        }

        private void MessageError(string message)
        {
            LblMessage.Text = message;
            LblMessage.Visible = true;
        }
    }
}
