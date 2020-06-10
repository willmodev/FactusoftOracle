using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class AdministratorService
    {
        private readonly ConnectionManager connectionManager;
        private readonly AdministratorRepository administratorRepository;

        public AdministratorService(string connectionString)
        {
            connectionManager = new ConnectionManager(connectionString);
            administratorRepository = new AdministratorRepository(connectionManager);
        }


        public LoginAnswer Login(Administrator administrator)
        {
            LoginAnswer loginAnswer = new LoginAnswer();

            try
            {
                loginAnswer.Error = false;
                connectionManager.OpenConnection();
                loginAnswer.ValidData = administratorRepository.Login(administrator);
                return loginAnswer;
            }
            catch (Exception e)
            {
                loginAnswer.Error = true;
                loginAnswer.Message = $"Error de aplicacion {e.Message}";
                return loginAnswer;
            }
            finally { connectionManager.CloseConnection(); }
        }

        public GetAdministratorAnswer GetAdministrator()
        {

            GetAdministratorAnswer answer = new GetAdministratorAnswer();
            try
            {
                connectionManager.OpenConnection();
                answer.Error = false;
                answer.Admin = administratorRepository.GetAdministrator();
                if (answer.Admin == null) answer.Message = "No existen datos del administrador";

                return answer;

            }
            catch (Exception e)
            {
                answer.Error = true;
                answer.Message = $"Error de aplicacion {e.Message}";
                answer.Admin = null;
                return answer;

            }
            finally { connectionManager.CloseConnection(); }
        }

    }

    public class GetAdministratorAnswer
    {
        public Administrator Admin { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
    }

    public class LoginAnswer
    {
        public bool ValidData { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
    }
}
