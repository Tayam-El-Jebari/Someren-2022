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
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {

            string query = "SELECT studentId, firstName, lastName, dateOfBirth, roomNumber FROM [Student]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    StudentId = (int)dr["studentId"],
                    FirstName = (string)dr["firstName"],
                    LastName = (string)dr["lastName"],
                    DateOfBirth = (DateTime)dr["dateOfBirth"],
                    RoomNumber = (int)dr["roomNumber"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}
