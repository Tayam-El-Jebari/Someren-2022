using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class ForgotPasswordDAO : BaseDao
    {
        public List<ForgotPassword> GetAllForgotPassword() 
        {
            // GROUP BY & HAVING. Boolean returnen met 0(false) of 1(true); 
            string query = "SELECT [username] [password] [passwordAgain] [licenseKey] [question] [answer] FROM [Register]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddRowForgotPassword(string username, string password, string licenseKey, string question, string answer)
        {
            string query = "INSERT INTO [Users](username, [password], question, answer) VALUES (@username, @password, @question, @answer)";
            SqlParameter[] sqlParameters = new SqlParameter[4] {

            new SqlParameter("@username", username),
            new SqlParameter("@password", password),
            new SqlParameter ("@question", question),
            new SqlParameter ("@answer", answer)
        };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<ForgotPassword> ReadTables(DataTable dataTable)
        {
            try
            {
                List<ForgotPassword> forgotPasswords = new List<ForgotPassword>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    ForgotPassword passwords = new ForgotPassword()
                    {
                        Username = (string)dr["username"],
                        Password = (string)dr["password"],
                        ConfirmPassword = (string)dr["confirmPassword"],
                        Question = (string)dr["question"],
                        Answer = (string)dr["answer"]
                    };
                    forgotPasswords.Add(passwords);
                };
                return forgotPasswords;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
    }
}
