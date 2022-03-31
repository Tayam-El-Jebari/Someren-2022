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

        public void AddRowRegister(string firstName, string lastName, string email, string password, string question, string answer)
        {
            string query = "declare @salt uniqueidentifier = newid(); INSERT INTO [Users]([firstName], [lastName], [email], [password], [salt], question, answer, [adminStatus]) VALUES (@firstName, @lastName, @email, hashbytes('sha2_512', @password + cast(@salt as nvarchar(36))), @salt, @question, @answer, 0)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@firstName", firstName);
            sqlParameters[1] = new SqlParameter("@lastName", lastName);
            sqlParameters[2] = new SqlParameter("@email", email);
            sqlParameters[3] = new SqlParameter("@password", password);
            sqlParameters[4] = new SqlParameter("@question", question);
            sqlParameters[5] = new SqlParameter("@answer", answer);
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
