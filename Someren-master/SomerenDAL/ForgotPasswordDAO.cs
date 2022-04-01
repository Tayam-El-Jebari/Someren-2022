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
            string query = "SELECT email, [password], [question], [answer] FROM [Users]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public string GetQuestion(string username)
        {
            string query = $"SELECT question FROM [Users] WHERE email = @email";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter ("@email", username)
            };
            string question = (string)ExecuteSelectQuery(query, sqlParameters).Rows[0]["question"];
            return question;
        }
        public void AddRowForgotPassword(string username, string password, string licenseKey, string question, string answer)
        {
            string query = "INSERT INTO [Users](email, [password], question, answer) VALUES (@username, @password, @question, @answer)";
            SqlParameter[] sqlParameters = new SqlParameter[4] {

            new SqlParameter("@email", username),
            new SqlParameter("@password", password),
            new SqlParameter ("@question", question),
            new SqlParameter ("@answer", answer)
        };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdatePassword(string username, string password)
        {
            string query = "declare @salt uniqueidentifier = newid(); UPDATE Users SET password=hashbytes('sha2_512', @password + cast(@salt as nvarchar(36))) WHERE email=@email; UPDATE Users SET salt=@salt WHERE email=@email";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@email", username);
            sqlParameters[1] = new SqlParameter("@password", password);
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
