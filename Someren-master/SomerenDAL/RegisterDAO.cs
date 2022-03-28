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
    public class RegisterDAO : BaseDao
    {
        public List<Register> GetAllRegisters() 
        {
            // GROUP BY & HAVING. Boolean returnen met 0(false) of 1(true); 
            string query = "SELECT [username] [password] [question] [answer] FROM [Register]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddRowRegister(string username, string password, string question, string answer)
        {
            string query = "INSERT INTO [Users]([username], [password], question, answer) VALUES (@username, @password, @question, @answer)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@username", username);
            sqlParameters[1] = new SqlParameter("@password", password);
            sqlParameters[2] = new SqlParameter("@question", question);
            sqlParameters[3] = new SqlParameter("@answer", answer);
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Register> ReadTables(DataTable dataTable)
        {
            try
            {
                List<Register> registers = new List<Register>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Register register = new Register()
                    {
                        Username = (string)dr["username"],
                        Password = (string)dr["password"],
                        Question = (string)dr["question"],
                        Answer = (string)dr["answer"]
                    };
                    registers.Add(register);
                };
                return registers;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
    }
}
