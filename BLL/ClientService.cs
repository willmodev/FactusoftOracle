using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Infrastructure;

namespace BLL
{
    public class ClientService
    {

        private readonly ConnectionManager connectionManager;
        private readonly ClientRepository clientRepository;

        public ClientService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            clientRepository = new ClientRepository(connectionManager);
        }
        public SaveClientAnswer Save(Client client, Administrator admin)
        {
            Email email = new Email();
            SaveClientAnswer answer = new SaveClientAnswer();

             string messageEmail = string.Empty;

            try
            {
                connectionManager.OpenConnection();
                answer.Error = false;
                clientRepository.Save(client);
                messageEmail = email.SendEmail(client, admin);
                answer.Message = $"Los Datos del cliete {client.FirstName} se han guardado satisfactoriamente { messageEmail}" ;

                return answer;
            }
            catch (Exception e)
            {
                answer.Error = true;
                answer.Message = $"Error de aplicacion: {e.Message}";
                return answer;
            }
            finally { connectionManager.CloseConnection(); }

        }

        public ConsultClientAnswer Consult()
        {
            ConsultClientAnswer answer = new ConsultClientAnswer();

            try
            {
                connectionManager.OpenConnection();
                answer.Clients = clientRepository.Consult();
                answer.Message = (answer.Clients.Count() != 0) ? "Se consultaron los Clientes" : "No hay Clientes para consultar";
                answer.Error = false;
                return answer;
            }
            catch (Exception e)
            {
                answer.Message = $"Error de aplicacion: {e.Message}";
                answer.Error = true;
                return answer;


            }
            finally { connectionManager.CloseConnection(); }
        }

        public string Remove(string Cedula)
        {
            try
            {
                connectionManager.OpenConnection();

                return clientRepository.Remove(Cedula) ? $"El Cliente con identificacion {Cedula}, se ha eliminado satisfactoriamente!"
                                                    : $"Lo sentimos, {Cedula} no se encuentra registrado";
            }
            catch (Exception e)
            {
                return $"Error de la aplicacion: {e.Message}";
            }
            finally { connectionManager.CloseConnection(); }
        }

        public string Modify(Client client)
        {
            try
            {
                connectionManager.OpenConnection();

                return clientRepository.Modify(client) ? $"El Cliente {client.FirstName} {client.LastName}se ha modificado satisfactoriamente."
                                                         : $"Lo sentimos, {client.Cedula} no se encuentra registrado.";
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { connectionManager.CloseConnection(); }
        }

        public SearchClienttAnswer Search(string Cedula)
        {
            SearchClienttAnswer answer = new SearchClienttAnswer();

            try
            {
                connectionManager.OpenConnection();
                answer.Client = clientRepository.Search(Cedula);
                answer.Message = (answer.Client != null) ? "Se encontró la el Cliente buscado" : "El Cliente buscado no existe";
                answer.Error = false;
                return answer;
            }
            catch (Exception e)
            {

                answer.Message = $"Error de la Aplicacion: {e.Message}";
                answer.Error = true;
                return answer;
            }
            finally { connectionManager.CloseConnection(); }
        }

    }

    public class SaveClientAnswer
    {
        public bool Error { get; set; }
        public string Message { get; set; }
    }
    public class ConsultClientAnswer
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public IList<Client> Clients { get; set; }
    }

    public class SearchClienttAnswer
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public Client Client { get; set; }
    }

}
