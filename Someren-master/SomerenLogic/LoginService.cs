using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class LoginService
    {
        private LoginDAO loginDAO;

        public LoginService()
        {
            loginDAO = new LoginDAO();
        }

        public User LoginUser(string username, string password)
        {
            return loginDAO.Login(username, password);
        }
    }
}
