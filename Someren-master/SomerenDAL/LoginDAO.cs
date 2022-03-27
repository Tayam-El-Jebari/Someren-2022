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
    public class LoginDAO : BaseDao
    {
        public User Login(string username, string password)
        {
            string query = "SELECT email FROM Users WHERE email = @username";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@username", username);
            sqlParameters[1] = new SqlParameter("@password", password);
            if (ExecuteSelectQuery(query, sqlParameters).Rows.Count == 0)
            {
                throw new Exception("Username not found in database, please make sure you have spelled everything correctly and you have entered an correct email address.");
            }
            
            query = "SELECT firstName, lastName, adminStatus FROM Users WHERE email = @username AND password = hashbytes('sha2_512', @password + cast((SELECT salt FROM Users WHERE email = @username) AS NVARCHAR(36)))";
            if (ExecuteSelectQuery(query, sqlParameters).Rows.Count == 0)
            {
                throw new Exception("Incorrect password, please try again or press the forgot password button.");
            }
            else
            {
                return ReadUser(ExecuteSelectQuery(query, sqlParameters));
            }

        }
        private User ReadUser(DataTable dataTable)
        {
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    User user = new User()
                    {
                        FirstName = (string)dr["firstName"],
                        LastName = (string)dr["lastName"],
                        IsAdmin = (bool)dr["adminStatus"]
                    };
                    return user;
                };
                User newus = new User();
                return newus;
                
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again, error: " + e.Message);
            }
        }
    }
}
