using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entity;
using System.Windows.Forms;

namespace Infrastructure
{
    public class Email
    {

        private  MailMessage mailMessage;
        private SmtpClient smtpClient;

        public Email()
        {
            smtpClient = new SmtpClient();
        }

        private void ConfigureSmtp(Administrator admin)
        {
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;

            smtpClient.Credentials = new System.Net.NetworkCredential(admin.Email, admin.PasswordEmail);
        }
        private void ConfigureEmail(Client client, Administrator admin)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string ruta = string.Empty;

            mailMessage = new MailMessage();
            mailMessage.To.Add(client.E_mail);
            mailMessage.From = new MailAddress(admin.Email);
            mailMessage.Subject = "Registro de cliente - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            mailMessage.Body = $"<b>Sr {client.FirstName} </b> <br>  Su registro en FACTUSOFT  ha sido exitoso!";

            //openFileDialog.ShowDialog();

            //if(openFileDialog.FileName.Equals("") == false)
            //    ruta = openFileDialog.FileName;

            //mailMessage.Attachments.Add( new Attachment(ruta));

            mailMessage.IsBodyHtml = true;
            mailMessage.Priority = MailPriority.Normal;

        }

        public string SendEmail(Client client, Administrator admin)
        {
            try
            {
                ConfigureSmtp(admin);
                ConfigureEmail(client, admin);
                smtpClient.Send(mailMessage);

                return "Correo enviado Satisfactoriamente";
            }
            catch (Exception e)
            {

                return $"Error al enviar el correo {e.Message}";
            }
            finally { mailMessage.Dispose(); }

        }


    }
}
