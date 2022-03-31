using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ForgotPasswordService
    {
        private ForgotPasswordDAO forgotPassworddb;

        public ForgotPasswordService()
        {
            forgotPassworddb = new ForgotPasswordDAO();
        }

        public List<ForgotPassword> ForgotPasswordList() 
        {
            List<ForgotPassword> forgotPasswords = forgotPassworddb.GetAllForgotPassword();
            return forgotPasswords;
        }
        public string Question(string username)
        {
            string question = forgotPassworddb.GetQuestion(username);
            return question;
        }
    }
}
