﻿using SomerenModel;
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
            // table doesnt exist for now. 
            string query = "SELECT [username] [password] [passwordAgain] [licenseKey] [question] [answer] FROM [Register]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                        PasswordAgain = (string)dr["passwordAgain"],
                        LicenseKey = (string)dr["licenseKey"],
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
